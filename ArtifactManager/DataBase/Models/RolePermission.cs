namespace ArtifactManager.DataBase.Models
{
    public class RolePermission
    {
        public int RolePermissionId { get; set; }
        
        public Role Role { get; set; }
        public int RoleId { get; set; }
        
        public Permission Permission { get; set; }
        public int PermissionId { get; set; }
    }
}