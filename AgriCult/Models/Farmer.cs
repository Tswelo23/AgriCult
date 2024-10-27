using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace AgriCult.Models
{
    public class Farmer
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public DateTime ProductionDate { get; set; }
    }
}
