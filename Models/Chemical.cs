using System.Collections.Generic;

namespace SmartScript_NETCore.Models
{
    public class Chemical : BaseEntity
    {
        public string Name { get; set; }
        public string Structure { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }
        public ICollection<Effect> Effects { get; set; }
    }
}