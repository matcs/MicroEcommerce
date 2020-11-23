using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMVC.Models
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public byte[] Image { get; set; }
        public string Description { get; set; }

        public ProductViewModel() { }

        public ProductViewModel(int productId, string name, byte[] image, string description)
        {
            ProductId = productId;
            Name = name;
            Image = image;
            Description = description;
        }
    }
}
