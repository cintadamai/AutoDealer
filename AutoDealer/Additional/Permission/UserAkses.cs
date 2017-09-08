using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using AutoDealer.DB.DMS;
using System.Windows.Forms;

namespace AutoDealer.Additional.Permission
{
    class UserAkses
    {
        XPQuery<UserModel> user_coll = Session.DefaultSession.Query<UserModel>();
        XPQuery<UserHasRolesModel> user_roles_coll = Session.DefaultSession.Query<UserHasRolesModel>();
        XPQuery<RolesModel> roles_coll = Session.DefaultSession.Query<RolesModel>();
        XPQuery<PermissionModel> permission_coll = Session.DefaultSession.Query<PermissionModel>();
        XPQuery<RolesHasPermissionModel> role_permission_coll = Session.DefaultSession.Query<RolesHasPermissionModel>();
        XPQuery<BranchModel> branch_coll = Session.DefaultSession.Query<BranchModel>();
        XPQuery<UserHasBranchModel> user_has_branch_coll = Session.DefaultSession.Query<UserHasBranchModel>();

        UserModel User;
        public bool Can(String permission)
        {
            bool returned = false;
            PermissionModel Permission = permission_coll.FirstOrDefault(p => p.permission_name == permission);

            /**
             * Cek Permission via Role
             **/
            var UserRoles = user_roles_coll.Where(ur => ur.username == User.username);

            //if (!UserRoles.Any())
            //{
              //  MessageBox.Show("User belum memiliki roles, silahkan hubungi sistem administrator terlebih dahulu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              //  return false;
            //}

            foreach (UserHasRolesModel UserRole in UserRoles)
            {
                RolesModel Role = roles_coll.FirstOrDefault(r => r.rolename == UserRole.rolename);
                var RoleHasPermission = role_permission_coll.Where(rp => rp.rolename == Role.rolename && rp.permission_name == Permission.permission_name);
                if (RoleHasPermission.Count() > 0)
                {
                    returned = true;
                    break;
                }
            }

            return returned;
        }

        public bool RolesHasPermission(RolesModel roles, PermissionModel permission)
        {
            bool returned = false;

            var RolePermissions = role_permission_coll.Where(rp => rp.rolename == roles.rolename && rp.permission_name == permission.permission_name);
            if (RolePermissions.Count() > 0)
            {
                returned = true;
            }
            return returned;
        }

        public void AssignRoleToUser(UserModel user, RolesModel role)
        {
            if(IsA(user, role.rolename))
            {
                return;
            }

            UserHasRolesModel userHasRoles = new UserHasRolesModel(Session.DefaultSession)
            {
                username = user.username,
                rolename = role.rolename
            };
            userHasRoles.Save();
        }

        public void RevokeRoleFromUser(UserModel user, RolesModel role)
        {
            UserHasRolesModel userHasRoles = user_roles_coll.FirstOrDefault(ur => ur.username == user.username && ur.rolename == role.rolename);
            userHasRoles.Delete();
        }

        public void AddPermissionToRole(RolesModel role, PermissionModel permission)
        {
            if(RolesHasPermission(role, permission))
            {
                return;
            }

            RolesHasPermissionModel roleHasPermission = new RolesHasPermissionModel(Session.DefaultSession)
            {
                rolename = role.rolename,
                permission_name = permission.permission_name
            };
            roleHasPermission.Save();
        }

        public void RemovePermissionFromRole(RolesModel role, PermissionModel permission)
        {
            RolesHasPermissionModel roleHasPermission = role_permission_coll.FirstOrDefault(rp => rp.rolename == role.rolename && rp.permission_name == permission.permission_name);
            roleHasPermission.Delete();
        }

        public void AddBranchForUser(UserModel user, BranchModel branch)
        {
            var count = user_has_branch_coll.Where(uhb => uhb.username == user.username && uhb.branch_name == branch.branch_name);
            if (count.Count() == 0)
            {
                UserHasBranchModel userHasBranch = new UserHasBranchModel(Session.DefaultSession)
                {
                    username = user.username,
                    branch_name = branch.branch_name
                };
                userHasBranch.Save();
            }
        }

        public void RemoveBranchFromUser(UserModel user, BranchModel branch)
        {
            UserHasBranchModel userHasBranch = user_has_branch_coll.FirstOrDefault(uhb => uhb.username == user.username && uhb.branch_name == branch.branch_name);
            userHasBranch.Delete();
        }

        public bool IsA(UserModel user, string rolename)
        {
            bool returned = false;
            var count = user_roles_coll.Where(ur => ur.username == user.username && ur.rolename == rolename);
            if(count.Count() > 0)
            {
                returned = true;
            }

            return returned;
        }


        public UserAkses() => User = Login.User;
    }
}
