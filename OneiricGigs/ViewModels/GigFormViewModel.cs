﻿using OneiricGigs.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OneiricGigs.ViewModels
{
    public class GigFormViewModel
    {   [Required]
        public string Club { get; set; }
        [Required]
        [FutureDate]
        public string Date { get; set; }
        [Required]
        [ValidTime]
        public string Time { get; set; }
        [Required]
        public byte Genre { get; set; }
        [Required]
        public IEnumerable<Genre> Genres { get; set; }

       

        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time)); 


        }

    }
}