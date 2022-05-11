using eTickets.Web.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Web.Entities
{
    public class Producer:BaseEntity
    {

        [Display(Name = "Profile Picture")]
        public string ProfilePictureUrl { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        public List<Movie> Movies { get; set; }
    }
}
