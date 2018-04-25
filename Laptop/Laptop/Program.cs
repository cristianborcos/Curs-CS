using System;

namespace Laptop
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop Laptop = new Laptop();
            Laptop.ShowAttributes();
            Laptop.color = "BLUE";
            Laptop.ShowAttributes();
            Console.WriteLine(Laptop.ModifyRamMemoryGB(16));
            Console.WriteLine(Laptop.ModifyprocessorFrequency(2));
            Console.WriteLine(Laptop.ModifyscreenSize(1));
            Console.WriteLine(Laptop.ModifiyhddCapacityGB(600));
            int result3 = Laptop.ModifyprocessorFrequency(2) + Laptop.ModifyprocessorFrequency(2);
            int result = Laptop.ModifyRamMemoryGB(16) + Laptop.ModifyRamMemoryGB(16);
            int result4 = Laptop.ModifyscreenSize(1) + Laptop.ModifyscreenSize(1);
            int result5 = Laptop.ModifiyhddCapacityGB(500) + Laptop.ModifiyhddCapacityGB(100);
            
            


            Laptop.ShowAttributes();

            Console.WriteLine(result);

            Console.WriteLine(Add(20, 2));

            int result2 = Add(16, 18);
            
            

            
            Console.ReadKey();
    
        }
        static int Add(int x, int y)

        {
            return x + y;

        }
    }
}
