using SmartScript_NETCore.Models;

namespace SmartScript_NETCore.Controllers.Resources
{
    public class EffectResource
    {
        public int Id { get; set; }

        // public int ChemicalID { get; set; }
        // public Chemical Chemical { get; set; }
        public int VariantID { get; set; }
        public VariantResource Variant { get; set; }
        public string Medical_Effect { get; set; }
        public string Notes { get; set; }

    }
}