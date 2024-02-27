using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationProduct.Models
{
    public class Product
    {
        static int unicId = 0;

        public int Id { get; }
        public string Name { get; }
        public Decimal Cost { get; }
        public string Description { get; }
        public string PathImage { get; }

        public Product(string name, decimal cost,string desc,string pathImage)
        {
            Name = name;
            Cost = cost;
            Description = desc;
            PathImage = pathImage;
            Id = unicId++;
        }

        public override string ToString()
        {
            return $"{Id} {Name} {Cost} {Description}";
        }
    }
}
