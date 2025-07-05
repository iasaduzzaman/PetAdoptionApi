using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Pet
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Species { get; set; }
        [Required]
        public string Breed { get; set; }
        [Required]
        public string Gender { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public virtual ICollection<AdoptionApplication> AdoptionApps { get; set; }
        public Pet()
        {
            AdoptionApps = new List<AdoptionApplication>();
        }
    }
}
