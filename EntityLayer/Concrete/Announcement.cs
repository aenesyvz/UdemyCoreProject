using CoreLayer.Entities;
using System;

namespace EntityLayer.Concrete
{
    public class Announcement : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public string Content { get; set; }
    }
}
