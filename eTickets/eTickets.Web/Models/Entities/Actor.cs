using eTickets.Web.Models.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Web.Entities
{
    public class Actor:BaseEntity
    {

        [Display(Name ="Profile Picture")]
        public string ProfilePictureUrl { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }


        public List<Actor_Movie> Actors_Movies { get; set; }


    }
}
