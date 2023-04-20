using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ArtifactManager.DataBase.Context;
using ArtifactManager.DataBase.Models;
using ArtifactManager.DataBase.Models.Instances;

namespace ArtifactManager.Controller
{
    public class LoggedIn
    {
        public User User;
        public Role Role;
        public List<Permission> Permissions;
        public List<Category> Categories;

        public List<Instance> Instances;

        public LoggedIn(string nick)
        {
            Update(nick);
        }

        public void Update(String nick)
        {
            using (var db = new DbCtx())
            {
                User = db.GetUser(nick);
                Role = db.UserRole(User.RoleId);
                Permissions = db.GetPermissions(Role.RoleId);
                Categories = db.GetCategories(User.Id);
                Instances = db.GetInstances(User.Id);
            }
        }

        public bool IsNewPasswordValid(string odlPass, string pass1, string pass2)
        {
            if (new PassHash(odlPass, User.Salt).Password != User.Password)
            {
                MessageBox.Show(@"Correct your old password!!", @"Bad Old Pass", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            
            if (pass1 == "" || pass2 == "")
            {
                MessageBox.Show(@"Passwords cant be empty!", @"Fill passwords", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (new PassHash(pass1, User.Salt).Password == User.Password)
            {
                MessageBox.Show(@"Change your password!", @"No changes!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (pass1 != pass2)
            {
                MessageBox.Show(@"Passwords arent same!", @"Correct your passwords!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public bool PasswordChange(string oldPass, string pass1, string pass2)
        {
            if (!IsNewPasswordValid(oldPass, pass1, pass2)) return false;

            using (var db = new DbCtx())
            {
                db.UpdateUserPass(User.Id, new PassHash(pass1));
            }

            return true;
        }

        public bool CanCreateInstance(string categoryName)
        {
            if (categoryName == DbGenerator.RootCategory)
            {
                MessageBox.Show(@"No user can create world instance!", @"Impossible", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            using (var db = new DbCtx())
            {
                Category category = db.GetCategory(categoryName);
                
                foreach (Permission permission in Permissions)
                {
                    if (permission.CategoryId == category.CategoryId && permission.MakeInstance ||
                        (permission.CategoryId == null && permission.MakeInstance) ||
                        (ParentPermission(permission.CategoryId, category.Name) && permission.MakeInstance))
                    {
                        return true;
                    }
                }
            }
            
            return false;
        }
        
        public bool CanDeleteInstance(string instanceName)
        {
            using (var db = new DbCtx())
            {
                Instance instance = db.GetInstance(instanceName);
                Category category = db.GetCategory(instance.CategoryId);
                
                foreach (Permission permission in Permissions)
                {
                    if ((permission.CategoryId == instance.CategoryId && permission.Delete) ||
                        (permission.CategoryId == null && permission.Delete) ||
                        (ParentPermission(permission.CategoryId, category.Name) && permission.Delete))
                    {
                        return true;
                    }
                }
            }
            
            return false;
        }

        public bool CanCreateCategory(string parentName, string newCategoryName)
        {
            if (parentName == DbGenerator.RootCategory)
            {
                foreach (Permission permission in Permissions)
                {
                    if (permission.CategoryId == null && permission.Add)
                    {
                        return true;
                    }
                }

                return false;
            }
            
            using (var db = new DbCtx())
            {
                Category category = db.GetCategory(parentName);
                
                foreach (Permission permission in Permissions)
                {
                    if (permission.CategoryId == category.CategoryId && permission.Add ||
                        (permission.CategoryId == null && permission.Add) ||
                        (ParentPermission(permission.CategoryId, parentName) && permission.Add))
                    {
                        return true;
                    }
                }
            }
            
            return false;
        }

        public bool CanDeleteCategory(string categoryName)
        {
            using (var db = new DbCtx())
            {
                Category category = db.GetCategory(categoryName);
                
                foreach (Permission permission in Permissions)
                {
                    if (permission.CategoryId == category.CategoryId && permission.Delete ||
                        (permission.CategoryId == null && permission.Delete) ||
                        (ParentPermission(permission.CategoryId, categoryName) && permission.Delete))
                    {
                        return true;
                    }
                }
            }
            
            return false;
        }

        public bool CanEditCategory(String categoryName)
        {
            if (categoryName == DbGenerator.RootCategory)
            {
                MessageBox.Show(@"No user can edit world category!", @"Impossible", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            
            using (var db = new DbCtx())
            {
                Category category = db.GetCategory(categoryName);
                
                foreach (Permission permission in Permissions)
                {
                    if ((permission.CategoryId == category.CategoryId && permission.Edit) || 
                        (permission.CategoryId == null && permission.Edit) || 
                        (ParentPermission(permission.CategoryId, categoryName) && permission.Edit))
                    {
                        return true;
                    }
                }
            }
            
            return false;
        }

        private bool ParentPermission(int? categoryId, String supposeChild)
        {
            if (categoryId == null) return false;

            using (var db = new DbCtx())
            {
                List<Category> parentCategories = DbTreeBuilder.MakeParentCategories(supposeChild);

                if (parentCategories.Select(c=>c.CategoryId).Contains(categoryId.Value))
                {
                    return true;
                }
            }

            return false;
        }
    }
}