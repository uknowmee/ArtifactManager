using System;

namespace ArtifactManager.DataBase.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        public String Name { get; set; }
        
        public String RolePanelType { get; set; }
        public String Description { get; set; }
        
        public override string ToString()
        {
            return "#Role name:\n- " + Name + "\n" + "#Role description:\n" + Description;
        }
    }
}