using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class ApplicationHistory
    {
        [Key]
        public int HistoryId { get; set; }
        [Required]
        [ForeignKey("Application")]
        public int ApplicationId { get; set; }
        public string ApplicationStatus { get; set; }
        [Required]
        public int ChangedBy { get; set; }
        public DateTime ChangedAt { get; set; } = DateTime.Now;
        public virtual AdoptionApplication Application { get; set; }
    }
}
