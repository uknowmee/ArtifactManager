using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ArtifactManager.DataBase.Context;
using ArtifactManager.DataBase.Models;

namespace ArtifactManager.Controller
{
    public class LoggedAdmin : LoggedIn
    {
        public LoggedAdmin(string nick) : base(nick)
        {
        }

        public bool IsMyDataChanged(string nick, string roleName, string roleDescription, string oldPass,
            string newPass1, string newPass2)
        {
            return User.Nick != nick || Role.Name != roleName || Role.Description != roleDescription || oldPass != "" ||
                   newPass1 != "" || newPass2 != "";
        }

        public bool IsMyNewDataValid(string nick, string roleName, string roleDescription, string oldPass,
            string newPass1, string newPass2)
        {
            using (var db = new DbCtx())
            {
                bool retFalse = false;

                var exNicks = db.UserNicksWithoutUserNick(User.Id);
                var exRoleNames = db.RoleNamesWithoutUserRole(User.Role.RoleId);

                if (exNicks.Contains(nick))
                {
                    MessageBox.Show(@"Nick already exists!", @"WRONG NICK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    retFalse = true;
                }

                if (exRoleNames.Contains(roleName))
                {
                    MessageBox.Show(@"Role name already exists!", @"WRONG ROLE", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    retFalse = true;
                }

                if (roleDescription == "")
                {
                    MessageBox.Show(@"Description cant be empty", @"WRONG DESCRIPTION", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    retFalse = true;
                }

                if (oldPass != "" || newPass1 != "" || newPass2 != "")
                {
                    if (!UserManager.TryAuth(User.Nick, oldPass))
                    {
                        MessageBox.Show(@"Old password is incorrect!", @"WRONG PASSWORD", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        retFalse = true;
                    }

                    if (newPass1 == "" || newPass2 == "")
                    {
                        MessageBox.Show(@"New passwords cant be empty!", @"WRONG PASSWORD", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        retFalse = true;
                    }

                    if (newPass1 != newPass2)
                    {
                        MessageBox.Show(@"New passwords arent same!", @"WRONG PASSWORD", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        retFalse = true;
                    }
                }

                return !retFalse;
            }
        }

        public bool SaveAdminData(string nick, string roleName, string roleDescription, string oldPass,
            string newPass1, string newPass2)
        {
            if (!IsMyNewDataValid(nick, roleName, roleDescription, oldPass, newPass1, newPass2))
            {
                return false;
            }

            using (var db = new DbCtx())
            {
                db.UpdateUserNick(User.Id, nick);
                db.UpdateUserRoleName(Role.RoleId, roleName);
                db.UpdateUserRoleDescription(Role.RoleId, roleDescription);

                if (oldPass != "")
                {
                    db.UpdateUserPass(User.Id, new PassHash(newPass1));
                }
            }

            Update(nick);

            return true;
        }

        public bool IsNewPermissionValid(bool add, bool delete, bool edit, bool make, bool kill, string categoryName)
        {
            using (var db = new DbCtx())
            {
                Permission permission1;

                if (categoryName == DbGenerator.AllCategories)
                {
                    permission1 = new Permission()
                    {
                        Add = add,
                        Delete = delete,
                        Edit = edit,
                        MakeInstance = make,
                        KillInstance = kill
                    };
                } else
                {
                    permission1 = new Permission()
                    {
                        CategoryId = db.GetCategory(categoryName).CategoryId,
                        Add = add,
                        Delete = delete,
                        Edit = edit,
                        KillInstance = kill,
                        MakeInstance = make
                    };
                }

                foreach (Permission permission in db.GetPermissions())
                {
                    if (DbObjectCompare.PermissionCompare(permission1, permission))
                    {
                        return false;
                    }
                }

                return true;
            }
        }
        
        public bool IsNewPermissionValid(Permission permission1)
        {
            using (var db = new DbCtx())
            {
                return db.GetPermissions().All(permission => !DbObjectCompare.PermissionCompare(permission1, permission));
            }
        }

        public void AddPermission(bool add, bool delete, bool edit, bool make, bool kill, string categoryName)
        {
            using (var db = new DbCtx())
            {
                if (categoryName == DbGenerator.AllCategories)
                {
                    db.AddPermission(DbGenerator.AllCategoriesCategoryId, add, delete, edit, make, kill);
                } else
                {
                    db.AddPermission(db.GetCategory(categoryName).CategoryId, add, delete, edit, make, kill);
                }
            }

            MessageBox.Show(@"Permission created!", @"INFO", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        
        public void EditPermission(Permission permission1, ComboBox comboBox, List<Permission> permissions)
        {
            int oldPermissionId = permissions[comboBox.SelectedIndex].PermissionId;
            
            using (var db = new DbCtx())
            {
                db.UpdatePermission(permission1, oldPermissionId);
            }
        }
    }
}