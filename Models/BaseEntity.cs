using System.ComponentModel.DataAnnotations.Schema;

namespace SmartScript_NETCore.Models
{
    public class BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
    }
}