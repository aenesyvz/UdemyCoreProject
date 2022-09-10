using CoreLayer.Entities;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Protfolio :IEntity
    {
        [Key]
        public int ProtfolioId { get; set; }
        public string Name { get; set; }
        public string ProjectUrl { get; set; }
        public string ImageUrl { get; set; }
        public string ImageUrl2 { get; set; }
        public string Price { get; set; }
        public bool Status { get; set; }
        public int Value { get; set; }
    }
}
