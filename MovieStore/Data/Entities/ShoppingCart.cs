﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Data.Entities
{
    public class ShoppingCart
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public int MovieId { get; set; }
        public double Price { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
