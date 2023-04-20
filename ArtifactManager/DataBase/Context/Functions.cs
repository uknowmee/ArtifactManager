using System;
using System.Collections.Generic;
using System.Linq;
using ArtifactManager.Controller;
using ArtifactManager.DataBase.Models;
using ArtifactManager.DataBase.Models.Instances;

namespace ArtifactManager.DataBase.Context
{
    public partial class DbCtx
    {

        public List<string> UserNicks()
        {
            return Users.Select(u => u.Nick).ToList();
        }

        public List<string> UserNicksWithoutUserNick(int userId)
        {
            return Users.Where(u => u.Id != userId).Select(u => u.Nick).ToList();
        }

        public List<string> RoleNamesWithoutUserRole(int roleId)
        {
            return Roles.Where(r => r.RoleId != roleId).Select(r => r.Name).ToList();
        }

        public List<String> CategoryNamesOfExistingInstances()
        {
            var categoryIds = Instances.Select(i => i.CategoryId);
            return Categories
                .Where(c => categoryIds.Contains(c.CategoryId))
                .Select(c => c.Name).ToList();
        }

        public List<Instance> InstancesOfCategory(String categoryName)
        {
            if (categoryName == "")
            {
                return new List<Instance>();
            }

            var categoryId = Categories.Single(c => c.Name == categoryName).CategoryId;

            return Instances.Where(i => i.CategoryId == categoryId).ToList();
        }

        public List<Instance> GetInstances(int userId)
        {
            return Instances.Where(i => i.Maker == userId).ToList();
        }

        public List<String> GetInstanceNames()
        {
            return Instances.Select(i => i.Name).ToList();
        }

        public List<Category> GetCategories(List<Property> properties)
        {
            var ids = properties.Select(p => p.CategoryId);

            return Categories.Where(c => ids.Contains(c.CategoryId)).ToList();
        }

        public List<Category> GetCategories()
        {
            return Categories.ToList();
        }

        public List<Category> GetCategories(int userId)
        {
            return Categories.Where(c => c.UserId == userId).ToList();
        }

        public Category GetCategory(int categoryId)
        {
            return Categories.Single(c => c.CategoryId == categoryId);
        }

        public Category GetCategory(String categoryName)
        {
            return Categories.Single(c => c.Name == categoryName);
        }

        public BaseProperty LimitProperty(int categoryId)
        {
            var limit = Limits.Single(l => l.MeansStronger && l.CategoryId == categoryId);
            return BaseProperties.Single(b => b.BasePropertyId == limit.BasePropertyId);
        }

        public List<InsBaseProperty> BasePropertiesNamed(string propName)
        {
            return InsBaseProperties
                .Where(p => p.Name == propName)
                .ToList();
        }

        public User GetUser(String nick)
        {
            return Users.Single(u => u.Nick == nick);
        }

        public User GetUser(int userId)
        {
            return Users.Single(u => u.Id == userId);
        }

        public Role UserRole(int roleId)
        {
            return Roles.Single(r => r.RoleId == roleId);
        }

        public List<Permission> GetPermissions(int roleId)
        {
            var rolePermissions = RolePermissions
                .Where(r => r.RoleId == roleId)
                .Select(r => r.PermissionId);

            return Permissions.Where(p => rolePermissions.Contains(p.PermissionId)).ToList();
        }

        public List<Permission> GetPermissions()
        {
            return Permissions.ToList();
        }

        public List<Modified> LastFewModified(int numToTake)
        {
            return RecentlyModified
                .OrderByDescending(m => m.ModifiedId)
                .Take(numToTake).ToList();
        }

        public void MakeAdmin(String nick, PassHash passHash, String description)
        {
            String roleName = nick;

            AddRole(roleName, description);
            AddUser(nick, passHash, roleName);
        }

        public void MakeGuest(String nick, PassHash passHash, String description)
        {
            String roleName = nick;

            AddRole(roleName, description);
            AddUser(nick, passHash, roleName);
        }

        public void MakeGod(String nick, PassHash passHash, String description)
        {
            String roleName = nick;

            AddRole(roleName, description);
            AddPermission(true, true, true, true, true, true);
            AddRolePermission(Roles.ToList().Last().RoleId, Permissions.ToList().Last().PermissionId);
            AddUser(nick, passHash, roleName);
        }

        public void AddRole(String roleName, String description)
        {
            Roles.Add(new Role()
            {
                Name = roleName,
                RolePanelType = roleName,
                Description = description
            });

            SaveChanges();
        }

        public void AddUser(String nick, PassHash passHash, String roleName)
        {
            Users.Add(new User()
            {
                Nick = nick,
                Password = passHash.Password,
                RoleId = Roles.Single(r => r.Name == roleName).RoleId,
                Salt = passHash.Salt
            });

            SaveChanges();
        }

        public void UpdateUser(string oldNick, string newNick, PassHash passHash, String roleName)
        {
            User user = Users.Single(u => u.Nick == oldNick);

            user.Nick = newNick;
            user.Password = passHash.Password;
            user.RoleId = Roles.Single(r => r.Name == roleName).RoleId;
            user.Salt = passHash.Salt;

            SaveChanges();
        }

        public void AddPermission(int categoryId, bool add, bool delete, bool edit, bool make, bool kill)
        {
            Permissions.Add(new Permission()
            {
                CategoryId = categoryId,
                Add = add,
                Delete = delete,
                Edit = edit,
                MakeInstance = make,
                KillInstance = kill
            });

            SaveChanges();
        }

        public void AddPermission(bool allCategory, bool add, bool delete, bool edit, bool make, bool kill)
        {
            if (allCategory)
            {
                Permissions.Add(new Permission()
                {
                    Add = add,
                    Delete = delete,
                    Edit = edit,
                    MakeInstance = make,
                    KillInstance = kill
                });

                SaveChanges();
            }
        }

        public void AddRolePermission(int roleId, int permissionId)
        {
            RolePermissions.Add(new RolePermission()
            {
                RoleId = roleId,
                PermissionId = permissionId
            });

            SaveChanges();
        }

        public Permission GetPermission(int permissionId)
        {
            return Permissions.Single(p => p.PermissionId == permissionId);
        }

        public void UpdatePermission(Permission permission1, int oldPermissionId)
        {
            Permission permission = Permissions.Single(p => p.PermissionId == oldPermissionId);
            permission.CategoryId = permission1.CategoryId;
            permission.Add = permission1.Add;
            permission.Delete = permission1.Delete;
            permission.Edit = permission1.Edit;
            permission.MakeInstance = permission1.MakeInstance;
            permission.KillInstance = permission1.KillInstance;

            SaveChanges();
        }

        public void UpdateUserNick(int userId, string nick)
        {
            User user = Users.Single(u => u.Id == userId);
            user.Nick = nick;
            SaveChanges();
        }

        public void UpdateUserRoleName(int roleId, string roleName)
        {
            Role role = Roles.Single(r => r.RoleId == roleId);
            role.Name = roleName;
            SaveChanges();
        }

        public void UpdateUserRoleDescription(int roleId, string roleDescription)
        {
            Role role = Roles.Single(r => r.RoleId == roleId);
            role.Description = roleDescription;
            SaveChanges();
        }

        public void UpdateUserPass(int userId, PassHash passHash)
        {
            User user = Users.Single(u => u.Id == userId);
            user.Password = passHash.Password;
            user.Salt = passHash.Salt;
            SaveChanges();
        }

        public void DeletePermission(int permissionId)
        {
            RolePermissions.RemoveRange(RolePermissions.Where(r => r.PermissionId == permissionId));
            SaveChanges();
            Permissions.RemoveRange(Permissions.Where(p => p.PermissionId == permissionId));
            SaveChanges();
        }

        public List<String> RoleNames()
        {
            return Roles.Select(r => r.Name).ToList();
        }

        public Role AddRole(string roleName, string description, string defUserPass)
        {
            Roles.Add(new Role()
            {
                Name = roleName,
                RolePanelType = defUserPass,
                Description = description
            });

            SaveChanges();

            return Roles.OrderByDescending(r => r.RoleId).Take(1).Single();
        }

        public void ChangeRole(int oldRoleId, string newName, string description, List<Permission> permissions)
        {
            Role role = Roles.Single(r => r.RoleId == oldRoleId);

            role.Name = newName;
            role.Description = description;

            RolePermissions.RemoveRange(RolePermissions.Where(rp => rp.RoleId == oldRoleId));

            foreach (Permission permission in permissions)
            {
                RolePermissions.Add(new RolePermission()
                {
                    RoleId = oldRoleId,
                    PermissionId = permission.PermissionId
                });

                SaveChanges();
            }

            SaveChanges();
        }

        public List<Role> GetRoles()
        {
            return Roles.ToList();
        }

        public Role GetRole(string roleName)
        {
            return Roles.Single(r => r.Name == roleName);
        }

        public Role RemoveRole(string oldName)
        {
            Role role = Roles.Single(r => r.Name == oldName);

            RolePermissions.RemoveRange(RolePermissions.Where(rp => rp.RoleId == role.RoleId));

            Roles.Remove(role);

            SaveChanges();

            return role;
        }

        public void RemoveUsersOfRole(string oldRoleName)
        {
            Role role = Roles.Single(r => r.Name == oldRoleName);

            Users.RemoveRange(Users.Where(u => u.RoleId == role.RoleId));

            SaveChanges();
        }

        public void EditRole()
        {
        }

        public List<Role> GetUserRole(string userNick)
        {
            int roleId = Users.Single(u => u.Nick == userNick).RoleId;

            return Roles.Where(r => r.RoleId == roleId).ToList();
        }

        public List<Role> GetRolesWithoutUserRole(Role userRole)
        {
            return Roles.Where(r => r.RoleId != userRole.RoleId &&
                                    r.RolePanelType != DbGenerator.DefAdminPass &&
                                    r.RolePanelType != DbGenerator.DefGuestPass).ToList();
        }

        public List<Role> GetRolesWithoutUserRole(String userRole)
        {
            int roleId = Roles.Single(r => r.Name == userRole).RoleId;

            return Roles.Where(r => r.RoleId != roleId &&
                                    r.RolePanelType != DbGenerator.DefAdminPass &&
                                    r.RolePanelType != DbGenerator.DefGuestPass).ToList();
        }

        public IEnumerable<Role> GetRolesNoAdminGuestGod()
        {
            return Roles.Where(r => r.RolePanelType != DbGenerator.DefAdminPass &&
                                    r.RolePanelType != DbGenerator.DefGuestPass).ToList();
        }

        public IEnumerable<Role> GetRolesNoAdmin()
        {
            return Roles.Where(r => r.RolePanelType != DbGenerator.DefAdminPass).ToList();
        }

        public List<String> UserNicksWithoutAdminGuest()
        {
            IEnumerable<int> roleIds = GetRolesNoAdminGuestGod().Select(r => r.RoleId);

            return Users.Where(u => roleIds.Contains(u.RoleId))
                .Select(u => u.Nick).ToList();
        }

        public List<String> UserNicksWithoutAdmin()
        {
            IEnumerable<int> roleIds = GetRolesNoAdmin().Select(r => r.RoleId);

            return Users.Where(u => roleIds.Contains(u.RoleId)).Select(u => u.Nick).ToList();
        }

        public void DeleteUser(string nick)
        {
            int userId = Users.Single(u => u.Nick == nick).Id;
            List<Role> rolesList = Roles.Where(r => r.RolePanelType == DbGenerator.DefGodPass).ToList();

            if (rolesList.Count == 0)
            {
                // Possible error :)
                Users.RemoveRange(Users.Where(c => c.Id == userId));
                Instances.RemoveRange(Instances.Where(c => c.Maker == userId));
            } else
            {
                int roleId = rolesList[0].RoleId;

                List<User> godList = Users.Where(u => u.RoleId == roleId && u.Id != userId).ToList();

                if (godList.Count == 0)
                {
                    // Possible error :)
                    Users.RemoveRange(Users.Where(c => c.Id == userId));
                    Instances.RemoveRange(Instances.Where(c => c.Maker == userId));
                } else
                {
                    SetUserIdToCategoriesAndInstances(godList[0].Id, userId);

                    Users.RemoveRange(Users.Where(c => c.Id == userId));
                }
            }

            SaveChanges();
        }

        private void SetUserIdToCategoriesAndInstances(int godUserId, int userId)
        {
            foreach (Modified modified in RecentlyModified.Where(rm => rm.UserId == userId))
            {
                modified.UserId = godUserId;
            }


            foreach (Category category in Categories.Where(rm => rm.UserId == userId))
            {
                category.UserId = godUserId;
            }


            foreach (Instance instance in Instances.Where(rm => rm.Maker == userId))
            {
                instance.Maker = godUserId;
            }
        }

        public Instance GetInstance(string instanceName)
        {
            return Instances.Single(i => i.Name == instanceName);
        }

        public List<String> GetCategoryNames()
        {
            return Categories.Select(c => c.Name).ToList();
        }

        public List<String> GetSubCategoriesNames(string parentCategoryName)
        {
            if (parentCategoryName == DbGenerator.RootCategory)
            {
                return Categories
                    .Where(c => c.ParentId == null)
                    .Select(c => c.Name).ToList();
            }

            Category parentCategory = GetCategory(parentCategoryName);
            List<int> childIds = Children
                .Where(ch => ch.Parent.CategoryId == parentCategory.CategoryId)
                .Select(ch => ch.Category.CategoryId).ToList();

            return Categories
                .Where(c => childIds.Contains(c.CategoryId))
                .Select(c => c.Name).ToList();
        }

        public Category GetParentCategory(string categoryName)
        {
            var category = Categories.Where(c => c.Name == categoryName).Select(c => c.ParentId).ToList();

            if (category[0] == null)
            {
                return null;
            } else
            {
                int id = category[0].Value;
                return Categories.Single(c => c.CategoryId == id);
            }
        }


        public Category CreateCategory(string parentName, string newCategoryName, int userId)
        {
            if (parentName == DbGenerator.RootCategory)
            {
                Categories.Add(new Category()
                {
                    Name = newCategoryName,
                    ParentId = null,
                    UserId = userId
                });
            } else
            {
                Category parent = GetCategory(parentName);

                Categories.Add(new Category()
                {
                    Name = newCategoryName,
                    ParentId = parent.CategoryId,
                    UserId = userId
                });
            }

            SaveChanges();
            Category category = Categories.OrderByDescending(c => c.CategoryId).Take(1).ToList()[0];

            if (parentName == DbGenerator.RootCategory) return category;

            Category parent1 = GetCategory(parentName);
            Children.Add(new Child()
            {
                Category = category,
                Parent = parent1
            });
            SaveChanges();

            CreateParentFields(parent1, category);
            return category;
        }

        public void CreateParentFields(Category parent1, Category category)
        {
            foreach (BaseProperty baseProperty in GetCategoryBaseProperties(parent1.CategoryId))
            {
                BaseProperties.Add(new BaseProperty()
                {
                    Type = baseProperty.Type,
                    Name = baseProperty.Name,
                    IsList = baseProperty.IsList,
                    NumOfObjects = baseProperty.NumOfObjects,
                    CategoryId = category.CategoryId
                });

                SaveChanges();
            }

            foreach (Property property in GetCategoryProperties(parent1.CategoryId))
            {
                Properties.Add(new Property()
                {
                    CategoryId = category.CategoryId,
                    ElementId = property.ElementId,
                    IsList = property.IsList,
                    Name = property.Name,
                    NumOfObjects = property.NumOfObjects,
                });

                SaveChanges();
            }

            foreach (Limit limit in GetCategoryLimits(parent1.CategoryId))
            {
                BaseProperty oldBaseProperty = BaseProperties.Single(bp => bp.BasePropertyId == limit.BasePropertyId);
                BaseProperty newBaseProperty = BaseProperties
                    .Single(bp => bp.CategoryId == category.CategoryId && bp.Name == oldBaseProperty.Name);

                Limits.Add(new Limit()
                {
                    BiggerThanRest = limit.BiggerThanRest,
                    BasePropertyId = newBaseProperty.BasePropertyId,
                    BasePropertyName = newBaseProperty.Name,
                    CategoryId = category.CategoryId,
                    Max = limit.Max,
                    MeansStronger = limit.MeansStronger,
                    Min = limit.Min,
                    SmallerThanRest = limit.SmallerThanRest
                });

                SaveChanges();
            }
        }

        public void ModifiedAdd(bool add, bool delete, bool edit, Category category, int userId)
        {
            RecentlyModified.Add(new Modified()
            {
                Add = add,
                CategoryId = category.CategoryId,
                CategoryName = category.Name,
                Delete = delete,
                Edit = edit,
                UserId = userId
            });
            SaveChanges();
        }

        public List<Property> GetCategoryProperties(int categoryId)
        {
            return Properties.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<BaseProperty> GetCategoryBaseProperties(int categoryId)
        {
            return BaseProperties.Where(bp => bp.CategoryId == categoryId).ToList();
        }

        public List<Limit> GetCategoryLimits(int categoryId)
        {
            return Limits.Where(l => l.CategoryId == categoryId).ToList();
        }

        public BaseProperty GetBaseProperty(int limitBasePropertyId)
        {
            return BaseProperties.Single(b => b.BasePropertyId == limitBasePropertyId);
        }

        public void AddBaseProperty(string attributeName, string type, bool strongest, int categoryId, int UserId)
        {
            BaseProperties.Add(new BaseProperty()
            {
                CategoryId = categoryId,
                Name = attributeName,
                Type = type
            });

            SaveChanges();
            var lstbase = BaseProperties.OrderByDescending(b => b.BasePropertyId).Take(1).ToList();
            var baseP = lstbase[0];

            Limits.Add(new Limit()
            {
                BasePropertyId = baseP.BasePropertyId,
                BasePropertyName = baseP.Name,
                MeansStronger = strongest,
                CategoryId = categoryId
            });

            ModifiedAdd(false, false, true, GetCategory(categoryId), UserId);

            foreach (Category category in DbTreeBuilder.MakeChildCategories(categoryId))
            {
                BaseProperties.Add(new BaseProperty()
                {
                    CategoryId = category.CategoryId,
                    Name = attributeName,
                    Type = type
                });
                SaveChanges();

                lstbase = BaseProperties.OrderByDescending(b => b.BasePropertyId).Take(1).ToList();
                baseP = lstbase[0];

                Limits.Add(new Limit()
                {
                    BasePropertyId = baseP.BasePropertyId,
                    BasePropertyName = baseP.Name,
                    MeansStronger = strongest,
                    CategoryId = category.CategoryId
                });
                SaveChanges();
            }
        }

        public void AddProperty(string attributeName, int elementId, int categoryId, int UserId)
        {
            Properties.Add(new Property()
            {
                CategoryId = categoryId,
                Name = attributeName,
                ElementId = elementId
            });

            SaveChanges();

            ModifiedAdd(false, false, true, GetCategory(categoryId), UserId);

            foreach (Category category in DbTreeBuilder.MakeChildCategories(categoryId))
            {
                if (GetCategoryProperties(category.CategoryId).Select(p => p.Name).Contains(attributeName))
                {
                    Properties.RemoveRange(Properties.Where(p =>
                        p.CategoryId == category.CategoryId && p.Name == attributeName));
                }

                Properties.Add(new Property()
                {
                    CategoryId = category.CategoryId,
                    Name = attributeName,
                    ElementId = elementId
                });
                SaveChanges();
            }
        }

        public void DeleteCategory(String categoryName)
        {
            var id = GetCategory(categoryName).CategoryId;
            var catIds = DbTreeBuilder.MakeChildCategories(categoryName).Select(c => c.CategoryId);

            DeleteChild(id);
            DeleteLimits(id);
            DeleteBaseProperties(id);
            DeleteProperties(id);
            DeleteInstances(id);

            foreach (int catId in catIds)
            {
                DeleteChild(catId);
                DeleteLimits(catId);
                DeleteBaseProperties(catId);
                DeleteProperties(catId);
                DeleteInstances(catId);
                DeleteCategories(catId);
            }

            DeleteCategories(id);
        }

        private void DeleteChild(int id)
        {
            Children.RemoveRange(Children.Where(c => c.Category.CategoryId == id));
            SaveChanges();
        }

        private void DeleteLimits(int id)
        {
            Limits.RemoveRange(Limits.Where(c => c.CategoryId == id));
            SaveChanges();
        }

        private void DeleteBaseProperties(int id)
        {
            BaseProperties.RemoveRange(BaseProperties.Where(c => c.CategoryId == id));
            SaveChanges();
        }

        private void DeleteProperties(int id)
        {
            Properties.RemoveRange(Properties.Where(c => c.CategoryId == id));
            SaveChanges();
        }

        public void DeleteInstances(int id)
        {
            var instanceIds = Instances.Where(i => i.CategoryId == id).Select(i => i.InstanceId);
            var elementIds = InsProperties.Where(i => instanceIds.Contains(i.InstanceId)).Select(i => i.ElementId);

            foreach (int elementId in elementIds)
            {
                using (var db = new DbCtx())
                {
                    db.DeleteInstances(elementId);
                    db.SaveChanges();
                }
            }

            Instances.RemoveRange(Instances.Where(i => i.CategoryId == id));
            SaveChanges();
        }

        private void DeleteCategories(int id)
        {
            Categories.RemoveRange(Categories.Where(c => c.CategoryId == id));
            SaveChanges();
        }

        public void DeleteBaseProperty(string categoryName, string basePropertyName)
        {
            var id = GetCategory(categoryName).CategoryId;
            var catIds = DbTreeBuilder.MakeChildCategories(categoryName).Select(c => c.CategoryId);

            Limits.RemoveRange(Limits.Where(l => l.BasePropertyName == basePropertyName && l.CategoryId == id));
            BaseProperties.RemoveRange(BaseProperties.Where(b => b.Name == basePropertyName && b.CategoryId == id));

            foreach (int catId in catIds)
            {
                Limits.RemoveRange(Limits.Where(l => l.BasePropertyName == basePropertyName && l.CategoryId == catId));
                BaseProperties.RemoveRange(
                    BaseProperties.Where(b => b.Name == basePropertyName && b.CategoryId == catId));
            }

            SaveChanges();
        }

        public void DeleteProperty(string categoryName, string propertyName)
        {
            var id = GetCategory(categoryName).CategoryId;
            var catIds = DbTreeBuilder.MakeChildCategories(categoryName).Select(c => c.CategoryId);

            Properties.RemoveRange(Properties.Where(b => b.Name == propertyName && b.CategoryId == id));

            foreach (int catId in catIds)
            {
                Properties.RemoveRange(Properties.Where(b => b.Name == propertyName && b.CategoryId == catId));
            }

            SaveChanges();
        }

        public Instance GetInstance(int propertyElementId)
        {
            return Instances.SingleOrDefault(i => i.InstanceId == propertyElementId);
        }
    }
}