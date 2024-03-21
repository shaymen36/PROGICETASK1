using System;

namespace ShoppingCartApp
{
    public enum ProductCategory
    {
        Clothing,
        Electronics,
        Home,
        Beauty,
        Groceries
    }
     
    class Program
    {
        static void Main(string[] args)
        {
            
            ClothingProduct shirt = new ClothingProduct("Shirt", 19.99, ProductCategory.Clothing, "M", "Blue");
            ElectronicProduct laptop = new ElectronicProduct("Laptop", 999.99, ProductCategory.Electronics, "Dell", "XPS 13");

            ShoppingCart cart = new ShoppingCart(5);
            cart.AddProduct(shirt);
            cart.AddProduct(laptop);

            Console.WriteLine("Products in the shopping cart:");
            foreach (Product product in cart.Products)
            {
                if (product != null)
                    product.GetInfo();
            }

            cart.RemoveProduct(shirt);

            Console.WriteLine("\nProducts in the shopping cart after removing a product:");
            foreach (Product product in cart.Products)
            {
                if (product != null)
                    product.GetInfo();
            }
        }
    }
}
