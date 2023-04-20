using ArtifactManager.DataBase.Context;
using ArtifactManager.DataBase.Models;

namespace ArtifactManager.Controller
{
    public static class UserManager
    {
        public static bool TryAuth(string nick, string password)
        {
            using (var db = new DbCtx())
            {
                User user = db.GetUser(nick);
                PassHash passHash = new PassHash(password, user.Salt);

                if (user.Password == passHash.Password)
                {
                    return true;
                }
            }

            return false;
        }
    }
}