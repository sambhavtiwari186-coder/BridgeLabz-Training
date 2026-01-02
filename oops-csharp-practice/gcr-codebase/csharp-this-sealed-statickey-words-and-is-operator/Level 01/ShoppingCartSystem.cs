using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.keywords_and_instances_in_oops
{
    internal class ShoppingCartSystem
    {
        // Creating a Product class 
        class Product
        {
            public static int discount = 20;
            string productName;
            int price;
            int quantity;
            readonly int productId;
            //Creating a Constructor of the Class
            public Product(int productId, string productName, int price, int quantity)
            {
                this.productId = productId;
                this.price = price;
                this.quantity = quantity;
                this.productName = productName;
            }
            // Creating a Method to Update Discount of the Product
            public static int UpdateDiscount(int newDiscount)
            {
                discount = newDiscount;
                return discount;
            }
            // Creating a Method to Display the Product Details
            public void DisplayProduct()
            {
                Console.WriteLine("The Name of the Product is " + this.productName);
                Console.WriteLine("The Price of the Product is " + this.price);
                Console.WriteLine("The Quantity of the Product is " + this.quantity);
                Console.WriteLine("The ProductID is " + this.productId);
            }
        }
            // Creating a Display Method to Create the object of the Class
        
        public void Display()
        {
            Product p1 = new Product(3001, "Socks", 56, 3);
            p1.DisplayProduct();
            bool show = p1 is Product;
            if (show)
            {
                Console.WriteLine("This obj is the instance of the Product");

            }
            int discount = Product.discount;
            int newdiscount = Product.UpdateDiscount(25);
            Console.WriteLine("The old Discount of the Product is " + discount + "% and the new discount is " + newdiscount + "%"); ;
        }
    }
}
