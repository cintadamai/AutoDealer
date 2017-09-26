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
        static UnitOfWork uow = new UnitOfWork
        {
                ConnectionString = AutoDealer.DB.DMS.ConnectionHelper.ConnectionString
        };
        XPQuery<UserModel> user_coll = uow.Query<UserModel>();
        XPQuery<UserHasRolesModel> user_roles_coll = uow.Query<UserHasRolesModel>();
        XPQuery<RolesModel> roles_coll = uow.Query<RolesModel>();
        XPQuery<PermissionModel> permission_coll = uow.Query<PermissionModel>();
        XPQuery<RolesHasPermissionModel> role_permission_coll = uow.Query<RolesHasPermissionModel>();
        XPQuery<BranchModel> branch_coll = uow.Query<BranchModel>();
        XPQuery<UserHasBranchModel> user_has_branch_coll = uow.Query<UserHasBranchModel>();

        UserModel User;
        public bool Can(String permission)
        {
            bool returned = false;
            PermissionModel Permission = permission_coll.FirstOrDefault(p => p.permission_name == permission);

            /**
             * Cek Permission via Role
             **/
            var UserRoles = user_roles_coll.Where(ur => ur.username.username == User.username);

            //if (!UserRoles.Any())
            //{
              //  MessageBox.Show("User belum memiliki roles, silahkan hubungi sistem administrator terlebih dahulu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              //  return false;
            //}

            foreach (UserHasRolesModel UserRole in UserRoles)
            {
                RolesModel Role = roles_coll.FirstOrDefault(r => r.rolename == UserRole.rolename.rolename);
                var RoleHasPermission = role_permission_coll.Where(rp => rp.rolename.rolename == Role.rolename && rp.permission_name.permission_name == Permission.permission_name);
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

            var RolePermissions = role_permission_coll.Where(rp => rp.rolename == roles && rp.permission_name == permission);
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
                username = user,
                rolename = role
            };
            userHasRoles.Save();
        }

        public void RevokeRoleFromUser(UserModel user, RolesModel role)
        {
            UserHasRolesModel userHasRoles = user_roles_coll.FirstOrDefault(ur => ur.username == user&& ur.rolename == role);
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
                rolename = role,
                permission_name = permission
            };
            roleHasPermission.Save();
        }

        public void RemovePermissionFromRole(RolesModel role, PermissionModel permission)
        {
            RolesHasPermissionModel roleHasPermission = role_permission_coll.FirstOrDefault(rp => rp.rolename == role && rp.permission_name == permission);
            roleHasPermission.Delete();
        }

        public void AddBranchForUser(UserModel user, BranchModel branch)
        {
            var count = user_has_branch_coll.Where(uhb => uhb.username == user && uhb.branch_name == branch);
            if (count.Count() == 0)
            {
                UserHasBranchModel userHasBranch = new UserHasBranchModel(Session.DefaultSession)
                {
                    username = user,
                    branch_name = branch
                };
                userHasBranch.Save();
            }
        }

        public void RemoveBranchFromUser(UserModel user, BranchModel branch)
        {
            UserHasBranchModel userHasBranch = user_has_branch_coll.FirstOrDefault(uhb => uhb.username == user && uhb.branch_name == branch);
            userHasBranch.Delete();
        }

        public bool IsA(UserModel user, string rolename)
        {
            bool returned = false;
            var count = user_roles_coll.Where(ur => ur.username == user && ur.rolename.rolename == rolename);
            if(count.Count() > 0)
            {
                returned = true;
            }

            return returned;
        }


        public UserAkses()
        {
            User = user_coll.FirstOrDefault(u => u.username == Login.User.username);
        }
    }
}
