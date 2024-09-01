//#define CONSTRUCTORS_CHECK
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    class Program
    {
        static void Main(string[] args)
        {
#if CONSTRUCTORS_CHECK
            Fraction A = new Fraction();
            A.Print();
            Fraction B = new Fraction(5);
            B.Print();
            Fraction C = new Fraction(1, 2);
            C.Print();
            Fraction D = new Fraction(2, 3, 4);
            D.Print(); 
#endif
            Fraction A = new Fraction(2, 3, 4);
            Fraction B = new Fraction(3, 4, 5);
            A.Print();
            B.Print();
            (A * B).Print();
            (A / B).Print();
            (A + B).Print();
            (B - A).Print();
            (++A).Print();
            --A; A.Print();
            Console.WriteLine(new Fraction(1, 2) >= new Fraction(1, 2));
            Fraction C =  new Fraction(2.76); C.Print();
          
            


        }
    }
}
