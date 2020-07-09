namespace SmartScript_NETCore.Models
{
    public class Ingredient : BaseEntity
    {
        public int DrugID { get; set; }
        public Drug Drug { get; set; }
        public int ChemicalID { get; set; }
        public Chemical Chemical { get; set; }
    }
}