using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OneiricGigs.Models
{
    public class Attendance
    {
        public Gig Gig { get; set; }
        public ApplicationUser Atendee { get; set; }
        [Key]
        [Column(Order =1)]
        public int GigId { get; set; }
        [Key]
        [Column(Order=2)]
        public string AtendeeId { get; set; }
    }
}