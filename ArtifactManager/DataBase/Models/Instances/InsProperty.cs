using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArtifactManager.DataBase.Models.Instances
{
    public class InsProperty
    {
        public int InsPropertyId { get; set; }
        public int ElementId { get; set; }

        public string Name { get; set; }
        
        public int InstanceId { get; set; }
        public Instance Instance { get; set; }
    }
}