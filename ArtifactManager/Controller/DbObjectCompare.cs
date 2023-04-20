using ArtifactManager.DataBase.Models;

namespace ArtifactManager.Controller
{
    public static class DbObjectCompare
    {
        public static bool PermissionCompare(Permission permission1, Permission permission2)
        {
            return permission1.Add == permission2.Add && permission1.Delete == permission2.Delete &&
                   permission1.Edit == permission2.Edit && permission1.KillInstance == permission2.KillInstance &&
                   permission1.MakeInstance == permission2.MakeInstance && permission1.CategoryId == permission2.CategoryId;
        }

        public static bool UserCompare(User oldUser, User newUser)
        {
            return oldUser.Nick == newUser.Nick && oldUser.Password == newUser.Password &&
                   oldUser.RoleId == newUser.RoleId;
        }
    }
}