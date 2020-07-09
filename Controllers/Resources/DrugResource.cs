using System.Collections.Generic;
using SmartScript_NETCore.Models;

namespace SmartScript_NETCore.Controllers.Resources
{
    public class DrugResource
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Use { get; set; }
        public string Category { get; set; }
        public ICollection<IngredientResource> Ingredients { get; set;}
        // public ICollection<PrescriptionResource> Prescriptions { get; set; }
    }
}
