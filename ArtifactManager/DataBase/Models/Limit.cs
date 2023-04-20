namespace ArtifactManager.DataBase.Models
{
    public class Limit
    {
        public int LimitId { get; set; }

        public int BasePropertyId { get; set; }
        public string BasePropertyName { get; set; }

        public bool MeansStronger { get; set; }
        public bool BiggerThanRest { get; set; }
        public bool SmallerThanRest { get; set; }

        public int Max { get; set; }
        public int Min { get; set; }

        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}