using System.Collections.Generic;

namespace SmartScript_NETCore.Models
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public int File { get; set; }
        public ICollection<UserVariant> UserVariants { get; set; }
        public ICollection<Prescription> Prescriptions { get; set; }
    }
}