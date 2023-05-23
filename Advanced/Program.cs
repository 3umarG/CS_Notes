using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced
{
    public class Program
    {
        public static void Main()
        {
            var gList = new GenericList<int>();

            var dicGen = new Dictionary<int, string>();
            dicGen[1] = "Omar";
            Console.WriteLine(dicGen[1]);


            Console.WriteLine("Hello From Generic");

        }
    }
}
