﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllMixedUp.Models
{
    public class IngredientCreate
    {
        public int MaterialID { get; set; }

        [Display(Name = "Quantity")]
        public double Quantity { get; set; }

        public int GlazeID { get; set; }


    }
}