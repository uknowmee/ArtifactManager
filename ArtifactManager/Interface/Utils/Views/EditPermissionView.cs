using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ArtifactManager.Controller;
using ArtifactManager.DataBase.Context;
using ArtifactManager.DataBase.Models;

namespace ArtifactManager.Interface.Utils.Views
{
    public static class EditPermissionView
    {
        public static List<Permission> GetPermissions(List<Permission> permissions)
        {
            permissions.Clear();
            permissions.Add(new Permission());

            using (var db = new DbCtx())
            {
                var dbPermissions = db.GetPermissions();

                foreach (Permission dbPermission in dbPermissions)
                {
                    permissions.Add(dbPermission);
                }
            }

            return permissions;
        }

        public static ComboBox ShowPermissions(List<Permission> permissions, ComboBox comboBoxPermissions)
        {
            comboBoxPermissions.Items.Clear();

            comboBoxPermissions.Items.Add("");

            foreach (Permission permission in permissions.GetRange(1, permissions.Count - 1))
            {
                comboBoxPermissions.Items.Add(permission.ToString());
            }

            comboBoxPermissions.SelectedIndex = 0;

            return comboBoxPermissions;
        }

        public static Permission PermissionDetails(int selectedIndex, List<Permission> permissions)
        {
            Permission permission = permissions[selectedIndex];

            return permission;
        }

        public static bool IsEditedPermissionValid(LoggedAdmin loggedIn, Permission permission1, bool changed)
        {
            if (!changed)
            {
                MessageBox.Show(@"Edit permission!", @"NO PERMISSION EDITED", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }

            if (!loggedIn.IsNewPermissionValid(permission1))
            {
                MessageBox.Show(@"Specified Permission Already exists!", @"INFO", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }

            MessageBox.Show(@"You can create specified permission!", @"INFO", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            return true;
        }

        public static ComboBox ShowCategories(ComboBox comboBoxCategory)
        {
            comboBoxCategory.Enabled = false;

            comboBoxCategory.Items.Clear();
            comboBoxCategory.Items.Add("All");

            using (var db = new DbCtx())
            {
                foreach (Category category in db.GetCategories())
                {
                    comboBoxCategory.Items.Add(category.Name);
                }
            }

            return comboBoxCategory;
        }

        public static ComboBox ShowPermissionCategory(int permissionId, ComboBox comboBoxCategory)
        {
            using (var db = new DbCtx())
            {
                Permission permission = db.GetPermission(permissionId);

                if (permission.CategoryId == null)
                {
                    comboBoxCategory.SelectedIndex = 0;
                } else
                {
                    Category category = db.GetCategory(permission.CategoryId.Value);

                    foreach (String item in comboBoxCategory.Items)
                    {
                        if (item != category.Name) continue;

                        var toBeSelected = comboBoxCategory.Items.IndexOf(item);
                        comboBoxCategory.SelectedIndex = toBeSelected;
                        break;
                    }
                }
            }

            comboBoxCategory.Enabled = true;

            return comboBoxCategory;
        }

        public static void DeletePermission(List<Permission> permissions, ComboBox comboBoxPermissions)
        {
            var result = MessageBox.Show(@"Do you really want to delete permission?", @"PROCEED DELETE?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);

            if (result != DialogResult.Yes) return;
            
            Permission permission = PermissionDetails(comboBoxPermissions.SelectedIndex, permissions);

            using (var db = new DbCtx())
            {
                db.DeletePermission(permission.PermissionId);
            }
            
            MessageBox.Show(@"Permission has been deleted!", @"DELETED!", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            
            
        }
    }
}