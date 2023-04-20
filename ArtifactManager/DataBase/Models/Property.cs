using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using ArtifactManager.DataBase.Context;

namespace ArtifactManager.DataBase.Models
{
    public class Property
    {
        [Key] public int PropertyId { get; set; }
        public int ElementId { get; set; }
        public String Name { get; set; }

        public bool IsList { get; set; }
        public int NumOfObjects { get; set; }
        
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public override string ToString()
        {
            using (var db = new DbCtx())
            {
                return "(" + db.GetCategory(ElementId).Name + ") " + Name;
            }
        }
    }
}