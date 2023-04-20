namespace ArtifactManager.DataBase.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Nick { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }

        public Role Role { get; set; }
        public int RoleId { get; set; }

        public override string ToString()
        {
            return "[(" + Role + ") " + Nick + "]";
        }
    }
}