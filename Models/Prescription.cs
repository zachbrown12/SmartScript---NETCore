namespace SmartScript_NETCore.Models
{
    public class Prescription : BaseEntity
    {
        public int DrugID { get; set; }
        public Drug Drug { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
    }
}