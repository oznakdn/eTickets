using eTickets.Web.Entities;
using eTickets.Web.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Web.Models.Entities
{
    public class Producer:BaseEntity
    {

        [Display(Name = "Profile Picture")]
        public string ProfilePictureUrl { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        public string Bio { get; set; }

        public List<Movie> Movies { get; set; }
    }
}
