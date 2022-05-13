﻿using eTickets.Web.Models.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Web.Entities
{
    public class Cinema:BaseEntity
    {

        [Display(Name ="Cinema Logo")]
        public string Logo { get; set; }

        [Display(Name = "Cinema Name")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        public List<Movie> Movies { get; set; }


    }
}
