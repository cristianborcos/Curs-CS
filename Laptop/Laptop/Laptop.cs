using System;
using System.Collections.Generic;
using System.Text;

namespace Laptop
{
    class Laptop
    {
        public int screenSize = 14;
        public int ramMemoryGB = 16;
        public int processorFrequency = 3;
        public int hddCapacityGB = 500;
        public string color = "BLUE";
        public string keyboardLayout = "US";

        public void ShowAttributes()

        {
            Console.WriteLine($"ScreenSize:{screenSize}, RamMemoryGB:{ramMemoryGB}, processorFrequency:{processorFrequency}, HDDCapacity:{hddCapacityGB}, Color:{color}, KeyboardLayout:{keyboardLayout}");
        }

        public int ModifyprocessorFrequency(int newprocessorFrequency)
        {
            processorFrequency = processorFrequency + newprocessorFrequency;

            return processorFrequency;
        }

        public int ModifyRamMemoryGB(int newRamMemoryGB)
        {
            ramMemoryGB = ramMemoryGB + newRamMemoryGB;

            return ramMemoryGB;
        }
        public int ModifyscreenSize(int newscreenSize)
        {
            screenSize = screenSize + newscreenSize;

            return screenSize;
        }
       
       public int ModifiyhddCapacityGB(int newhddCapacityGB)
        {
            hddCapacityGB = hddCapacityGB + newhddCapacityGB;

            return hddCapacityGB;

        }

       
        
        

        
    }
}
