using eTickets.Web.Models;
using System.Collections.Generic;

namespace eTickets.Web.Entities
{
    public class Cinema:BaseEntity
    {
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Movie> Movies { get; set; }


    }
}
