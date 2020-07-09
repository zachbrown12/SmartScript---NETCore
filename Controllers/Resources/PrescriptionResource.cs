using SmartScript_NETCore.Models;

namespace SmartScript_NETCore.Controllers.Resources
{
    public class PrescriptionResource
    {
        public int Id { get; set; }

        public int DrugID { get; set; }
        public DrugResource Drug { get; set; }
        // public int UserID { get; set; }
        // public User User { get; set; }
    }
}