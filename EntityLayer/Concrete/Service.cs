﻿using CoreLayer.Entities;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Service : IEntity
    {
        [Key]
        public int ServiceId { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
    }
}
