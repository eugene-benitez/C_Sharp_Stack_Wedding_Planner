using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Wedding_Planner.Models
{
    public class Wedding
    {
        [Key]
        public int WeddingId { get; set; }

        public int CreatorId { get; set; }

        [MinLength(2)]
        [Required]
        [Display(Name = "Wedder One: ")]
        public string WedderOne { get; set; }

        [Required]
        [Display(Name = "Wedder Two: ")]
        public string WedderTwo { get; set; }

        [Required]
        [Display(Name = "Date: ")]
        public DateTime Date { get; set; }

        [Required]
        [Display(Name = "Wedding Address: ")]
        public String Address { get; set; }

        public List<RSVP> RSVP_Wedding { get; set; }

    }
}