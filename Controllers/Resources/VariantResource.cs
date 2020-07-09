using System.Collections.Generic;
using SmartScript_NETCore.Models;

namespace SmartScript_NETCore.Controllers.Resources
{
    public class VariantResource
    {
        public int Id { get; set; }

        public string RSID { get; set; }
        public string Chromosome { get; set; }
        public string Allele { get; set; }
        // public ICollection<EffectResource> Effects { get; set; }
        public ICollection<UserVariantResource> UserVariants { get; set; }

    }
}