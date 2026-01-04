using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Inheritence
{
    // Interface
    interface Worker
    {
        void PerformDuties();
    }

    // Superclass
    class Per
    {
        public string Name;
        public int Id;

        public Per(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name --> {Name}");
            Console.WriteLine($"ID   --> {Id}");
        }
    }

    // Chef
    class Chef : Per, Worker
    {
        public Chef(string name, int id) : base(name, id) { }

        public void PerformDuties()
        {
            Console.WriteLine("Chef Duties --> Cooking and managing kitchen");
        }
    }

    // Waiter
    class Waiter : Per, Worker
    {
        public Waiter(string name, int id) : base(name, id) { }

        public void PerformDuties()
        {
            Console.WriteLine("Waiter Duties --> Serving and assisting customers");
        }
    }

    // Making Display Class
    class Display
    {
        public  void DisplayIn()
        {
            Per chef = new Chef("Shyam", 101);
            Per waiter = new Waiter("Satyam", 102);

            chef.DisplayInfo();
            ((Worker)chef).PerformDuties();
            Console.WriteLine("--------------------------------");
            waiter.DisplayInfo();
            ((Worker)waiter).PerformDuties();
        }
    }
}
