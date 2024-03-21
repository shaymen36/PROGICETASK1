using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    public class ElectronicProduct : Product
    {
        private readonly string brand;
        private readonly string model;

        public string Brand { get { return brand; } }
        public string Model { get { return model; } }

        public ElectronicProduct(string name, double price, ProductCategory category, string brand, string model)
            : base(name, price, category)
        {
            this.brand = brand;
            this.model = model;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Brand: {brand}, Model: {model}");
        }
    }
}
