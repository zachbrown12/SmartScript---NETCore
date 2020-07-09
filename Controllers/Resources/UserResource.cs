using System.Collections.Generic;
using SmartScript_NETCore.Models;

namespace SmartScript_NETCore.Controllers.Resources
{
    public class UserResource
    {
        public int Id { get; set; }

        public string Username { get; set; }
        public string Name { get; set; }
        public int File { get; set; }
        // public ICollection<UserVariantResource> UserVariants { get; set; }
        public ICollection<PrescriptionResource> Prescriptions { get; set; }
    }
}