using CoreLayer.Entities;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Contact: IEntity
    {
        [Key]
        public int ContactId { get; set; }
        public string Title { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string Description { get; set; }
    }
}
