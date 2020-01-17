using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CustomerManager.Code.Models
{
    public class Guest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [StringLength(64)]
        [Display(Name = "Guest Name")]
        public string FullName { get; set; }

        [Required]
        [StringLength(15)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(64)]
        [Display(Name = "Email Address")]
        public string EmailId { get; set; }

        [Display(Name = "Date for RSVP")]
        public string RSVPDate { get; set; }

        [Display(Name = "Time of RSVP")]
        public DateTime TimeOfRSVP { get; set; }
    }
}