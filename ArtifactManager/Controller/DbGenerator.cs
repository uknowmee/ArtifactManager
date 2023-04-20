using System;
using ArtifactManager.DataBase.Context;
using ArtifactManager.DataBase.Models;

namespace ArtifactManager.Controller
{
    public static class DbGenerator
    {
        public const String DefAdminPass = "Admin";
        public const String DefGodPass = "God";
        public const String DefUserPass = "User";
        public const String DefGuestPass = "Guest";
        public const String RootCategory = "World";

        private const String AdminRoleDescription =
            "- His responsibility is managing users, guest and admin account\r\n" +
            "- He can create new Permissions and Roles";

        private const String GodRoleDescription = "- His responsibility is managing Categories and instances\r\n" +
                                                  "- He can create, edit and delete new Categories and Instances";

        private const String GuestRoleDescription = "- He can look through existing categories and instances";

        public const String AllCategories = "All";
        public const bool AllCategoriesCategoryId = true;

        public enum ValueType
        {
            Int,
            String,
            Bool
        }
        
        public static bool ShouldMakeDb()
        {
            using (var db = new DbCtx())
            {
                return !db.Database.Exists();
            }
        }

        public static void MakeDb(bool shouldMakeDb)
        {
            using (var db = new DbCtx())
            {
                if (!shouldMakeDb) return;

                db.Database.CreateIfNotExists();

                MakeAdmin();
                MakeGod();
                MakeGuest();
            }
        }

        public static Permission MakeTempPermission(string categoryName, bool add, bool delete, bool edit,
            bool makeInstance, bool killInstance)
        {
            using (var db = new DbCtx())
            {
                if (categoryName == AllCategories)
                {
                    return new Permission()
                    {
                        Add = add,
                        Delete = delete,
                        Edit = edit,
                        MakeInstance = makeInstance,
                        KillInstance = killInstance
                    };
                }

                return new Permission()
                {
                    CategoryId = db.GetCategory(categoryName).CategoryId,
                    Add = add,
                    Delete = delete,
                    Edit = edit,
                    MakeInstance = makeInstance,
                    KillInstance = killInstance
                };
            }
        }

        private static void MakeAdmin()
        {
            using (var db = new DbCtx())
            {
                db.MakeAdmin(DefAdminPass, new PassHash(DefAdminPass), AdminRoleDescription);
            }
        }

        private static void MakeGod()
        {
            using (var db = new DbCtx())
            {
                db.MakeGod(DefGodPass, new PassHash(DefGodPass), GodRoleDescription);
            }
        }

        private static void MakeGuest()
        {
            using (var db = new DbCtx())
            {
                db.MakeGuest(DefGuestPass, new PassHash(DefGuestPass), GuestRoleDescription);
            }
        }
    }
}