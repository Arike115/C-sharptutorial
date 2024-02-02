using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharptutorial
{
    public static class ExtensionClass
    {
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }
    }
}
