using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class AdoptionApplication
    {
        [Key]
        public int Id { get; set; }
        public DateTime Applicationdate { get; set; }
        [ForeignKey("Pet")]
        public int PetId { get; set; }
        [Required]
        [StringLength(20)]
        public string ApplicationStatus { get; set; } = "Submitted";
        public DateTime? ReviewDate { get; set; }

        public string Notes { get; set; }
        public virtual Pet Pet { get; set; }
    }
}
