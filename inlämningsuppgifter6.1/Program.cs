using System;
namespace Uppgift_6_1
{
    class Program
    {
        static void Addera(int tal1, int tal2, int tal3)
        {
            Console.WriteLine($"Dina 3 tal blir adderat: {tal1+tal2+tal3}");
            return;
        }

        static void Main(string[] args)
        {

            Addera(1, 4, 6);
            
        }

        
    }
}

