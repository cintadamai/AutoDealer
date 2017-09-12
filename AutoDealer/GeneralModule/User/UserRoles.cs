using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Xpo;
using AutoDealer.Additional.Permission;
using AutoDealer.DB.DMS;

namespace AutoDealer.GeneralModule.User
{
    public partial class UserRoles : DevExpress.XtraEditors.XtraForm
    {
        XPQuery<RolesModel> roles_coll = Session.DefaultSession.Query<RolesModel>();
        XPQuery<PermissionModel> permission_coll = Session.DefaultSession.Query<PermissionModel>();
        XPQuery<UserModel> user_coll = Session.DefaultSession.Query<UserModel>();
        XPQuery<UserHasRolesModel> user_has_roles_coll = Session.DefaultSession.Query<UserHasRolesModel>();
        XPQuery<RolesHasPermissionModel> roles_has_permission = Session.DefaultSession.Query<RolesHasPermissionModel>();
        UserAkses userAkses;
        public UserRoles()
        {
            InitializeComponent();
            RolesComboBoxEdit.TextChanged += RolesComboBoxEdit_TextChanged;
            userAkses = new UserAkses();
            PermissionTreeView.AfterCheck += PermissionTreeView_AfterCheck;
        }

        private void PermissionTreeView_AfterCheck(object sender, TreeViewEventArgs e)
        {
            foreach (TreeNode node in e.Node.Nodes)
            {
                node.Checked = e.Node.Checked;
            }
        }

        private void RolesComboBoxEdit_TextChanged(object sender, EventArgs e)
        {
            if(RolesComboBoxEdit.Text == "")
            {
                PermissionTreeView.Enabled = false;
                return;
            } else
            {
                PermissionTreeView.Enabled = true;
                var users = user_has_roles_coll.Where(uhr => uhr.rolename.rolename == RolesComboBoxEdit.Text).Select(uhr => uhr.username.username);
                UserGridControl.DataSource = user_coll.Where(u => users.Contains(u.username));

                var RolesPermissions = roles_has_permission.Where(rhp => rhp.rolename.rolename == RolesComboBoxEdit.Text).Select(rhp => rhp.permission_name.permission_name);
                var Permissions = permission_coll.Where(p => RolesPermissions.Contains(p.permission_name));
                var NotPermissions = permission_coll.Where(p => !RolesPermissions.Contains(p.permission_name));

                // Permission Type 1
                foreach (PermissionModel p in Permissions.Where(p => p.permission_type == 1))
                {
                    PermissionTreeView.Nodes[p.permission_name].Checked = true;
                }

                foreach (PermissionModel p in NotPermissions.Where(p => p.permission_type == 1))
                {
                    PermissionTreeView.Nodes[p.permission_name].Checked = false;
                }

                // Permission Type 2
                foreach (PermissionModel p in Permissions.Where(p => p.permission_type == 2))
                {
                    var Parent = permission_coll.FirstOrDefault(pr => pr.permission_name == p.parent_permission);
                    PermissionTreeView.Nodes[Parent.permission_name].Nodes[p.permission_name].Checked = true;
                }

                foreach (PermissionModel p in NotPermissions.Where(p => p.permission_type == 2))
                {
                    var Parent = permission_coll.FirstOrDefault(pr => pr.permission_name == p.parent_permission);
                    PermissionTreeView.Nodes[Parent.permission_name].Nodes[p.permission_name].Checked = false;
                }

                // Permission Type 3
                foreach (PermissionModel p in Permissions.Where(p => p.permission_type == 3))
                {
                    var Parent = permission_coll.FirstOrDefault(pr => pr.permission_name == p.parent_permission);
                    var Root = permission_coll.FirstOrDefault(pr => pr.permission_name == Parent.parent_permission);
                    PermissionTreeView.Nodes[Root.permission_name].Nodes[Parent.permission_name].Nodes[p.permission_name].Checked = true;
                }

                foreach (PermissionModel p in NotPermissions.Where(p => p.permission_type == 3))
                {
                    var Parent = permission_coll.FirstOrDefault(pr => pr.permission_name == p.parent_permission);
                    var Root = permission_coll.FirstOrDefault(pr => pr.permission_name == Parent.parent_permission);
                    PermissionTreeView.Nodes[Root.permission_name].Nodes[Parent.permission_name].Nodes[p.permission_name].Checked = false;
                }
            }
        }

        private void UserRoles_Load(object sender, EventArgs e)
        {
            RolesComboBoxEdit.Properties.Items.Clear();
            foreach(RolesModel roles in roles_coll)
            {
                RolesComboBoxEdit.Properties.Items.Add(roles.rolename);
            }
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            if(!validator.Validate())
            {
                return;
            }

            RolesModel roles = roles_coll.FirstOrDefault(r => r.rolename == RolesComboBoxEdit.Text);
            UserLookup f = new UserLookup();
            DialogResult dialog = f.ShowDialog(this);
            if(dialog == DialogResult.OK)
            {
                UserModel user = f.User;
                userAkses.AssignRoleToUser(user, roles);
                var users = user_has_roles_coll.Where(uhr => uhr.rolename.rolename == RolesComboBoxEdit.Text).Select(uhr => uhr.username.username);
                UserGridControl.DataSource = user_coll.Where(u => users.Contains(u.username));
            }
        }

        private void RekursifSaveNodes(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                RolesModel roles = roles_coll.FirstOrDefault(r => r.rolename == RolesComboBoxEdit.Text);
                PermissionModel permission = permission_coll.FirstOrDefault(p => p.permission_name == node.Name);

                if (node.Checked == true)
                {
                    if (!userAkses.RolesHasPermission(roles, permission))
                    {
                        userAkses.AddPermissionToRole(roles, permission);
                    }
                }
                else
                {
                    if (userAkses.RolesHasPermission(roles, permission))
                    {
                        userAkses.RemovePermissionFromRole(roles, permission);
                    }
                }

                TreeNodeCollection ChildNodes = node.Nodes;
                if (ChildNodes != null)
                {
                    RekursifSaveNodes(ChildNodes);
                }
            }
        }

        private void RemoveUser_Click(object sender, EventArgs e)
        {
            if (!validator.Validate())
            {
                return;
            }

            DialogResult dialog = MessageBox.Show("Yakin ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog != DialogResult.Yes)
            {
                return;
            }

            try
            {
                var selected = UserGridView.GetFocusedRowCellValue(colusername);
                UserModel userModel = user_coll.FirstOrDefault(u => u.username == selected.ToString());
                RolesModel roles = roles_coll.FirstOrDefault(r => r.rolename == RolesComboBoxEdit.Text);
                userAkses.RevokeRoleFromUser(userModel, roles);
                var users = user_has_roles_coll.Where(uhr => uhr.rolename.rolename == RolesComboBoxEdit.Text).Select(uhr => uhr.username.username);
                UserGridControl.DataSource = user_coll.Where(u => users.Contains(u.username));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Hapus_Click(object sender, EventArgs e)
        {
            if (!validator.Validate())
            {
                return;
            }

            DialogResult dialog = MessageBox.Show("Yakin untuk menghapus Role ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                RolesModel roles = roles_coll.FirstOrDefault(r => r.rolename == RolesComboBoxEdit.Text);
                roles.Delete();
                RolesComboBoxEdit.Properties.Items.Clear();
                foreach (RolesModel r in roles_coll)
                {
                    RolesComboBoxEdit.Properties.Items.Add(r.rolename);
                }

                RolesComboBoxEdit.ResetText();
            }
        }

        private void Tambah_Click(object sender, EventArgs e)
        {
            AddRoleDialog f = new AddRoleDialog();
            DialogResult dialog = f.ShowDialog(this);
            if(dialog == DialogResult.OK)
            {
                RolesModel roles = new RolesModel(Session.DefaultSession);
                roles.rolename = f.rolename.Text;
                roles.Save();
                RolesComboBoxEdit.Properties.Items.Clear();
                foreach (RolesModel r in roles_coll)
                {
                    RolesComboBoxEdit.Properties.Items.Add(r.rolename);
                }
            }
        }

        private void Simpan_Click(object sender, EventArgs e)
        {
            TreeNodeCollection nodes = PermissionTreeView.Nodes;
            RekursifSaveNodes(nodes);
            MessageBox.Show("Perubahan berhasil disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}