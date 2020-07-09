using SmartScript_NETCore.Models;

namespace SmartScript_NETCore.Controllers.Resources
{
    public class IngredientResource
    {
        public int Id { get; set; }
        // public int DrugID { get; set; }
        // public Drug Drug { get; set; }
        public int ChemicalID { get; set; }
        public ChemicalResource Chemical { get; set; }
    }
}