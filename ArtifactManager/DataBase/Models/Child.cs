using System.ComponentModel.DataAnnotations;

namespace ArtifactManager.DataBase.Models
{
    public class Child
    {
        public int ChildId { get; set; }
        
        public virtual Category Parent { get; set; }
        // public int ParentId { get; set; }
        
        public virtual Category Category { get; set; }
        // public int ChildCatId { get; set; }
    }
}