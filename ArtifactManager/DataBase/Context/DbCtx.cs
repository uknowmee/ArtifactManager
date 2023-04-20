using System.Data.Entity;
using ArtifactManager.DataBase.Models;
using ArtifactManager.DataBase.Models.Instances;
using BaseProperty = ArtifactManager.DataBase.Models.BaseProperty;
using Property = ArtifactManager.DataBase.Models.Property;
using InsProperty = ArtifactManager.DataBase.Models.Instances.InsProperty;
using InsBaseProperty = ArtifactManager.DataBase.Models.Instances.InsBaseProperty;


namespace ArtifactManager.DataBase.Context
{
    public partial class DbCtx : DbContext
    {
        public DbCtx() : base("MyConnectionString")
        {
        }

        public DbSet<Permission> Permissions { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Child> Children { get; set; }
        public DbSet<Limit> Limits { get; set; }
        
        public DbSet<Property> Properties { get; set; }
        public DbSet<BaseProperty> BaseProperties { get; set; }

        public DbSet<Instance> Instances { get; set; }
        public DbSet<InsProperty> InsProperties { get; set; }
        public DbSet<InsBaseProperty> InsBaseProperties { get; set; }

        public DbSet<Modified> RecentlyModified { get; set; }
    }
}