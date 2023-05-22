using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced
{
    internal class CompareGeneric<T> where T : IComparable<T>
    {
        private readonly T num1;  
        private readonly T num2;

        public CompareGeneric(T num1, T num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        public bool FirstNumSmallest()
        {
            // Without using where T : IComparable<T> i can't compare objects as int , double , float ... etc
            //return num1 > num2;

            return num1.CompareTo(num2) > 0;

        }
    }
}
