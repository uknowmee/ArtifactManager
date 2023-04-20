using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ArtifactManager.DataBase.Context;
using ArtifactManager.DataBase.Models;

namespace ArtifactManager.Controller
{
    public class DbRoleBuilder
    {
        public List<Permission> Permissions { get; private set; }

        public List<Permission> RolePermissions { get; private set; }

        public string Name { get; private set; }

        public string Description { get; private set; }

        private const string RolePanelType = DbGenerator.DefUserPass;

        public DbRoleBuilder()
        {
            FreshRoleBuilder();
        }

        public void FreshRoleBuilder()
        {
            using (var db = new DbCtx())
            {
                Permissions = db.GetPermissions();
                RolePermissions = new List<Permission>();
                Name = "";
                Description = "";
            }
        }

        public void FromRoleName(string text)
        {
            using (var db = new DbCtx())
            {
                Role role = db.GetRole(text);

                RolePermissions = db.GetPermissions(role.RoleId);

                Permissions = db.GetPermissions();

                for (int i = Permissions.Count - 1; i >= 0; i--)
                {
                    foreach (Permission rolePermission in RolePermissions)
                    {
                        if (DbObjectCompare.PermissionCompare(Permissions[i], rolePermission))
                        {
                            Permissions.RemoveAt(i);
                            break;
                        }
                    }
                }

                Name = role.Name;
                Description = role.Description;
            }
        }

        private bool PermissionsCheck()
        {
            using (var db = new DbCtx())
            {
                int numOfEl = RolePermissions.Count;

                if ((from role in db.GetRoles()
                        let numOfEl1 =
                            db.GetPermissions(role.RoleId).Sum(permission => RolePermissions.Count(rolePermission =>
                                DbObjectCompare.PermissionCompare(permission, rolePermission)))
                        where numOfEl1 == numOfEl && numOfEl != 0 && db.GetPermissions(role.RoleId).Count == numOfEl1
                        select role).Any())
                {
                    return false;
                }
            }

            return true;
        }
        
        private bool PermissionsCheck(String oldName)
        {
            using (var db = new DbCtx())
            {
                List<Role> roles = db.GetRoles();
                Role roleToRemove = roles.Single(r=>r.Name == oldName);

                roles.Remove(roleToRemove);

                int numOfEl = RolePermissions.Count;

                if ((from role in roles
                        let numOfEl1 =
                            db.GetPermissions(role.RoleId).Sum(permission => RolePermissions.Count(rolePermission =>
                                DbObjectCompare.PermissionCompare(permission, rolePermission)))
                        where numOfEl1 == numOfEl && numOfEl != 0 && db.GetPermissions(role.RoleId).Count == numOfEl1
                        select role).Any())
                {
                    return false;
                }
            }

            return true;
        }

        private bool NoNullOldName(string oldName)
        {
            using (var db = new DbCtx())
            {
                List<string> roleNames = db.RoleNames();
                roleNames.Remove(oldName);

                if (roleNames.Contains(Name))
                {
                    MessageBox.Show(@"Name already exists!", @"CHANGE NAME", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return false;
                }

                if (!PermissionsCheck(oldName))
                {
                    MessageBox.Show(@"Role with same set of permissions exists!", @"Change permissions",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                return true;
            }
            
        }

        private bool NullOldName()
        {
            using (var db = new DbCtx())
            {
                if (db.RoleNames().Contains(Name))
                {
                    MessageBox.Show(@"Name already exists!", @"CHANGE NAME", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return false;
                }

                if (!PermissionsCheck())
                {
                    MessageBox.Show(@"Role with same set of permissions exists!", @"Change permissions",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                return true;
            }
        }

        public bool IsAvailable(String oldName)
        {
            if (Name != "") return oldName == null ? NullOldName() : NoNullOldName(oldName);

            MessageBox.Show(@"Name cant be empty!", @"FILL NAME", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }

        public void Save()
        {
            if (!IsAvailable(null)) return;

            using (var db = new DbCtx())
            {
                Role role = db.AddRole(Name, Description, RolePanelType);

                foreach (Permission rolePermission in RolePermissions)
                {
                    db.AddRolePermission(role.RoleId, rolePermission.PermissionId);
                }
            }

            MessageBox.Show(@"Role added!", @"SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        public void SaveExistingRole(String oldName)
        {
            if (!IsAvailable(oldName)) return;

            using (var db = new DbCtx())
            {
                Role oldRole = db.GetRole(oldName);

                db.ChangeRole(oldRole.RoleId, Name, Description, RolePermissions);
            }

            MessageBox.Show(@"Role added!", @"SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Update(String name, String description)
        {
            Name = name;
            Description = description;
        }

        public bool ToPermission(ComboBox cmbRolePermission)
        {
            if (cmbRolePermission.Text == "")
            {
                return false;
            }

            Permission permission = RolePermissions[cmbRolePermission.SelectedIndex];
            RolePermissions.RemoveAt(cmbRolePermission.SelectedIndex);
            Permissions.Add(permission);

            return true;
        }

        public bool ToRolePermission(ComboBox cmbPermission)
        {
            if (cmbPermission.Text == "")
            {
                return false;
            }

            Permission permission = Permissions[cmbPermission.SelectedIndex];
            Permissions.RemoveAt(cmbPermission.SelectedIndex);
            RolePermissions.Add(permission);

            return true;
        }

        public bool Compare(DbRoleBuilder newDbRoleBuilder)
        {
            return NameCompare(newDbRoleBuilder.Name) && DescriptionCompare(newDbRoleBuilder.Description) &&
                   RolePermissionCompare(newDbRoleBuilder.RolePermissions);
        }

        private bool NameCompare(string name)
        {
            return Name == name;
        }

        private bool DescriptionCompare(string description)
        {
            return Description == description;
        }

        private bool RolePermissionCompare(List<Permission> permissions)
        {
            int counter = 0;

            foreach (var rolePermission in RolePermissions)
            {
                foreach (Permission permission in permissions)
                {
                    if (DbObjectCompare.PermissionCompare(permission, rolePermission))
                    {
                        counter += 1;
                    }
                }
            }

            return RolePermissions.Count == permissions.Count && counter == permissions.Count;
        }

        public bool removeRole(string oldRoleName)
        {
            if (oldRoleName == "")
            {
                MessageBox.Show(@"Choose role you want to delete!", @"YOU DINT CHOSE", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            using (var db = new DbCtx())
            {
                if (db.GetRole(oldRoleName).RolePanelType == DbGenerator.DefGodPass)
                {
                    MessageBox.Show(@"You cant delete God role!", @"NO PERMISSION", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return false;
                }
            }
            
            using (var db = new DbCtx())
            {
                db.RemoveUsersOfRole(oldRoleName);
                db.RemoveRole(oldRoleName);
            }

            MessageBox.Show(@"Role removed!", @"SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return true;
        }
    }
}