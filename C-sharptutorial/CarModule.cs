using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharptutorial
{
    public abstract class CarModule : IColor
    {
        public string Name { get; set; } //properties
        public string Description; //field
        public abstract void CarEngine();

        public void CarWindows()
        {
            Console.WriteLine("we have 6 windows in the suv car");
        }

        public void ColorNames()
        {
            Console.WriteLine("the car color is Black");
        }
    }
}
