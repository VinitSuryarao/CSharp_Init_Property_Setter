using System;

namespace InitOnly
{
    class Client
    {
        public int ID { get; init; } // Setter define as Init
        public string Name { get; set; }
        public string City { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Client obj = new Client { ID = 1 }; // Set value only when object creation
            
            obj.Name = "ABC";
            obj.City = "Mumbai";
            Console.WriteLine(obj.ID.ToString()+" "+obj.Name+" "+obj.City);

            obj.Name = "XYZ";
            obj.City = "Pune";
            Console.WriteLine(obj.ID.ToString() + " " + obj.Name + " " + obj.City);
            
            Console.ReadLine();
        }
    }
}
