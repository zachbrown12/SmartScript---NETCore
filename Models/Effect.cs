namespace SmartScript_NETCore.Models
{
    public class Effect : BaseEntity
    {
        public int ChemicalID { get; set; }
        public Chemical Chemical { get; set; }
        public int VariantID { get; set; }
        public Variant Variant { get; set; }
        public string Medical_Effect { get; set; }
        public string Notes { get; set; }

    }
}