using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalog.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public byte[] Image { get; set; }
        public string Description { get; set; }

        public static byte[] ReadFile(string sPath)
        {
            byte[] data = null;

            FileInfo fInfo = new FileInfo(sPath);
            long numBytes = fInfo.Length;

            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);

            BinaryReader br = new BinaryReader(fStream);

            data = br.ReadBytes((int)numBytes);

            return data;
        }

        public Product() { }

        public Product(int productId, string name, byte[] image, string description)
        {
            ProductId = productId;
            Name = name;
            Image = image;
            Description = description;
        }
    }
}
