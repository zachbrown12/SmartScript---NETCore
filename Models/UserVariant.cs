namespace SmartScript_NETCore.Models
{
    public class UserVariant : BaseEntity
    {
        public int VariantID { get; set; }
        public Variant Variant { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public int RowNum { get; set; }

    }
}