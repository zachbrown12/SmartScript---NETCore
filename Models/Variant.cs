using System.Collections.Generic;

namespace SmartScript_NETCore.Models
{
    public class Variant : BaseEntity
    {
        public string RSID { get; set; }
        public string Chromosome { get; set; }
        public string Allele { get; set; }
        public ICollection<Effect> Effects { get; set; }
        public ICollection<UserVariant> UserVariants { get; set; }

    }
}