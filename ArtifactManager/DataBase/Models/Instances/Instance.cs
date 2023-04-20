using System;
using System.Collections.Generic;
using ArtifactManager.DataBase.Context;

namespace ArtifactManager.DataBase.Models.Instances
{
    public class Instance
    {
        public int InstanceId { get; set; }
        public String Name { get; set; }
        public int Maker { get; set; }
        public int CategoryId { get; set; }
        
        public ICollection<InsProperty> InsProperties { get; set; }
        public ICollection<InsBaseProperty> InsBaseProperties { get; set; }

        public override string ToString()
        {
            using (var db = new DbCtx())
            {
                return "Id: " + InstanceId + ", Name: " + Name + ", Maker: " + db.GetUser(Maker).Nick;
            }
        }
    }
}