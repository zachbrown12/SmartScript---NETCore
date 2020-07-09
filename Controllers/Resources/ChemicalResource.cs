using System.Collections.Generic;
using SmartScript_NETCore.Models;

namespace SmartScript_NETCore.Controllers.Resources
{
    public class ChemicalResource
    {  
        public int Id { get; set; }
        public string Name { get; set; }
        public string Structure { get; set; }
        // public ICollection<IngredientResource> Ingredients { get; set; }
        public ICollection<EffectResource> Effects { get; set; }
    }
}