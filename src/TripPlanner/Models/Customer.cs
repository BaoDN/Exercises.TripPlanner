﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TripPlanner.Models
{
    public class Customer
    {
        public int Id { get; set; }
          [Required]
          public string FirstName { get; set; }
          [Required]
          public string LastName { get; set; }
          [Required]
          public DateTime DateOfBirth { get; set; }
          [Required]
          public string StreetAddress { get; set; }
          [Required]
          public string Suburb { get; set; }
          [Required]
          [Column(TypeName = "varchar(3)")]
          public string State { get; set; }
          [Required]
          [Column(TypeName = "varchar(4)")]
          public string Postcode { get; set; }

         public List<Package> Packages { get; set; }

    }
}
