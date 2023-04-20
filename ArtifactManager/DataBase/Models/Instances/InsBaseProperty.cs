using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArtifactManager.DataBase.Models.Instances
{
    public class InsBaseProperty
    {
        public int InsBasePropertyId { get; set; }
        public String Type { get; set; }
        public String Name { get; set; }
        public String Value { get; set; }
        
        public int InstanceId { get; set; }
        public Instance Instance { get; set; }
    }
}