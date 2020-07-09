using SmartScript_NETCore.Models;

namespace SmartScript_NETCore.Controllers.Resources
{
    public class UserVariantResource
    {
        public int Id { get; set; }

        // public int VariantID { get; set; }
        // public Variant Variant { get; set; }
        public int UserID { get; set; }
        public UserEndResource User { get; set; }
        public int RowNum { get; set; }

    }
}