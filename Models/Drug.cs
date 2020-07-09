using System.Collections.Generic;


namespace SmartScript_NETCore.Models
{
    public class Drug : BaseEntity
    {
        public string Name { get; set; }
        public string Use { get; set; }
        public string Category { get; set; }
        public ICollection<Ingredient> Ingredients { get; set;}
        public ICollection<Prescription> Prescriptions { get; set; }
    }
}
