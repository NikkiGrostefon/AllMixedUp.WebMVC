﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllMixedUp.Data
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }

        //[Required]
        //public string Password { get; set; }

        [Required]
        public string Country { get; set; }
        [Required]
        public string State { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
    }
} 
