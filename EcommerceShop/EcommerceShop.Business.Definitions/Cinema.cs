﻿using System.ComponentModel.DataAnnotations;

namespace EcommerceShop.Business.Definitions
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }

        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}