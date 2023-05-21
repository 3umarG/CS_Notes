using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    // By using internal access modifier keyword the class can only be accessable inside the same class library/assembly
    // حتى لو ساتخدمت using  مش هعرف اوصله .... لازم من جوا نفس ال assembly
    internal class Maths
    {
        public Maths(int Id)
        {
            this.Id = Id;
        }


        public int Id { get; }
    }
}
