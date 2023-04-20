using System;

namespace ArtifactManager.DataBase.Models
{
    public class BaseProperty
    {
        public int BasePropertyId { get; set; }
        public String Type { get; set; }
        public String Name { get; set; }
        
        public bool IsList { get; set; }
        public int NumOfObjects { get; set; }

        
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        
        public override string ToString()
        {
            if (IsList)
            {
                return "(List<" + Type + ">)" + Name + "Lenght: " + NumOfObjects;

            }
            
            return "(" + Type + ") " + Name;
        }
    }
}