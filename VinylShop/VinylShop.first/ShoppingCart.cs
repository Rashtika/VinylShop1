using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VinylShop.first
{
    public class ShoppingCart
    {
        public string? Name { get; set; }
        private List<Vinyl> cartItems;

        public ShoppingCart(string name)
        {
            Name = name;
            cartItems = new List<Vinyl>();
        }

        public void AddToCart(Vinyl item)
        {
            cartItems.Add(item);
            Console.WriteLine($"Added to cart: {item.Title} by {item.Artist}");
        }
        public void ListCartItems()
        {
            if(cartItems.Count == 0)
            {
                Console.WriteLine("Your shopping cart is empty");
                return;
            }
            Console.WriteLine("\nItems in your shopping cart:");
            foreach(var item in cartItems)
            {
                Console.WriteLine(item);
            }
        }



    }
}
