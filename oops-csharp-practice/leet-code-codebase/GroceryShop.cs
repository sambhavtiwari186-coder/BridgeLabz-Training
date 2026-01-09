using System;

namespace BridgeLabzTraining
{
    public class GroceryShop
    {
        // ---------------- PRODUCT CLASS ----------------
        class Product
        {
            public int productId;
            public string productName;
            public double price;
            public int stock;
        }

        // ---------------- APPLICATION CLASS ----------------
        class GroceryApp
        {
            Product[] products = new Product[50];
            Product[] cart = new Product[50];

            int productCount = 0;
            int cartCount = 0;

            // ENTRY METHOD FOR MENU
            public void Display()
            {
                int mainChoice;
                do
                {
                    Console.WriteLine("\n====== GROCERY SHOP ======");
                    Console.WriteLine("1. Owner");
                    Console.WriteLine("2. User");
                    Console.WriteLine("3. Exit");
                    Console.Write("Enter choice: ");
                    mainChoice = Convert.ToInt32(Console.ReadLine());

                    switch (mainChoice)
                    {
                        case 1:
                            OwnerMenu();
                            break;
                        case 2:
                            UserMenu();
                            break;
                        case 3:
                            Console.WriteLine("Thank you for visiting Grocery Shop!");
                            break;
                        default:
                            Console.WriteLine("Invalid choice!");
                            break;
                    }
                } while (mainChoice != 3);
            }

            // ---------------- OWNER MENU ----------------
            void OwnerMenu()
            {
                int choice;
                do
                {
                    Console.WriteLine("\n--- OWNER MENU ---");
                    Console.WriteLine("1. Add Product");
                    Console.WriteLine("2. View Products");
                    Console.WriteLine("3. Back");
                    Console.Write("Enter choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            AddProduct();
                            break;
                        case 2:
                            ViewProducts();
                            break;
                        case 3:
                            break;
                        default:
                            Console.WriteLine("Invalid choice!");
                            break;
                    }
                } while (choice != 3);
            }

            void AddProduct()
            {
                Product p = new Product();

                Console.Write("Enter Product ID: ");
                p.productId = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Product Name: ");
                p.productName = Console.ReadLine();

                Console.Write("Enter Price: ");
                p.price = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Stock Quantity: ");
                p.stock = Convert.ToInt32(Console.ReadLine());

                products[productCount] = p;
                productCount++;

                Console.WriteLine("Product added successfully!");
            }

            void ViewProducts()
            {
                if (productCount == 0)
                {
                    Console.WriteLine("No products available!");
                    return;
                }

                Console.WriteLine("\n--- PRODUCT LIST ---");
                for (int i = 0; i < productCount; i++)
                {
                    Console.WriteLine(
                        "ID: " + products[i].productId +
                        ", Name: " + products[i].productName +
                        ", Price: Rs" + products[i].price +
                        ", Stock: " + products[i].stock);
                }
            }

            // ---------------- USER MENU ----------------
            void UserMenu()
            {
                int choice;
                do
                {
                    Console.WriteLine("\n--- USER MENU ---");
                    Console.WriteLine("1. View Products");
                    Console.WriteLine("2. Buy Product");
                    Console.WriteLine("3. Checkout");
                    Console.WriteLine("4. Back");
                    Console.Write("Enter choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            ViewProducts();
                            break;
                        case 2:
                            BuyProduct();
                            break;
                        case 3:
                            Checkout();
                            break;
                        case 4:
                            break;
                        default:
                            Console.WriteLine("Invalid choice!");
                            break;
                    }
                } while (choice != 4);
            }

            void BuyProduct()
            {
                Console.Write("Enter Product ID to buy: ");
                int id = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < productCount; i++)
                {
                    if (products[i].productId == id)
                    {
                        Console.Write("Enter Quantity: ");
                        int qty = Convert.ToInt32(Console.ReadLine());

                        if (qty > products[i].stock)
                        {
                            Console.WriteLine("Insufficient stock!");
                            return;
                        }

                        Product item = new Product();
                        item.productId = products[i].productId;
                        item.productName = products[i].productName;
                        item.stock = qty;
                        item.price = products[i].price * qty;

                        cart[cartCount] = item;
                        cartCount++;

                        products[i].stock -= qty;

                        Console.WriteLine("Product added to cart!");
                        return;
                    }
                }

                Console.WriteLine("Product not found!");
            }

            void Checkout()
            {
                if (cartCount == 0)
                {
                    Console.WriteLine("Cart is empty!");
                    return;
                }

                double total = 0;
                Console.WriteLine("\n--- FINAL BILL ---");

                for (int i = 0; i < cartCount; i++)
                {
                    Console.WriteLine(
                        cart[i].productName +
                        " | Qty: " + cart[i].stock +
                        " | Price: ₹" + cart[i].price);
                    total += cart[i].price;
                }

                Console.WriteLine("----------------------");
                Console.WriteLine("Total Amount: ₹" + total);
                Console.WriteLine("Thank you for shopping!");

                cartCount = 0;
            }
        }

        // ---------------- MAIN METHOD ----------------
        public static void Main(string[] args)
        {
            GroceryApp app = new GroceryApp();
            app.Display();
        }
    }
}
