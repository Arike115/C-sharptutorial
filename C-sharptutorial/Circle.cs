#define airtel
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharptutorial
{
    //#define
    //#undef
    //#if
    //#else
    //#elif
    //#endif
    //#line
    //#error
    //#region
    //#endregion

    public class Circle
    {
#warning this method do not need any changes
        public static void Radius()
        {
#if (glo)
            Console.WriteLine("Start is defined");
#else
             Console.WriteLine("Start is defined");
#endif
            Console.ReadKey();
        }
    }
}
