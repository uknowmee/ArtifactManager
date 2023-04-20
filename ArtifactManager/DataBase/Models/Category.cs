using System;
using System.Reflection;
using ArtifactManager.DataBase.Context;

namespace ArtifactManager.DataBase.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public String Name { get; set; }
        public int? ParentId { get; set; }
        
        public User User { get; set; }
        public int UserId { get; set; }

        public override string ToString()
        {
            using (var db = new DbCtx())
            {
                return "Category: " + Name + ", Made by: " + db.GetUser(UserId);
            }
        }
    }
}