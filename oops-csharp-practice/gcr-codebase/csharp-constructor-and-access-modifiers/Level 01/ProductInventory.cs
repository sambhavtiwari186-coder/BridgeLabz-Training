using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Constructor
{
    internal class ProductInventory
    {
        // Creating a Class To Make Product Entry
        class Product
        {
            public static int totalProduct = 0;
            string productName;
            double price;
            // Creating a Constructor of this Class
            public Product(string productName,double price) {
                 this.productName = productName;
                this.price = price;
                totalProduct++;
            }
            // Method To Display Product Details
            public void DisplayProductDetails()
            {
                Console.WriteLine("The Product Name is "+ this.productName);
                Console.WriteLine("The Price of the Product is "+ this.price);
                Console.WriteLine();
            }
            // Method to Display the Total no of Products 
            public static void DisplayTotal()
            {
                Console.WriteLine("The Total No of Products is " +  totalProduct);
            }
        }
        public void DisplayProduct()
        {
            Product pro = new Product("Chips",10.0);
            pro.DisplayProductDetails();
            Product pro1 = new Product("Biscuits",20.0);
            pro1.DisplayProductDetails();
            Product pro2 = new Product("Coke", 50.0);
            pro2.DisplayProductDetails();
            Product.DisplayTotal();

        }
    }
}
