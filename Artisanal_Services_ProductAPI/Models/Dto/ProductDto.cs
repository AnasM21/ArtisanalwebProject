﻿using System.ComponentModel.DataAnnotations;

namespace Artisanal_Services_ProductAPI.Models.Dto
{
    public class ProductDto
    {
        
        public int ProductId { get; set; }
        
        public string Name { get; set; }

        public double Price { get; set; }

        public string Description { get; set; }

        public string CategoryName { get; set; }

        public string ImageURL { get; set; }
    }
}
