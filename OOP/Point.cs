using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Point
    {
        double x;
         double y;
         public double X
         {
             get => x;
            set
            {
                if (value > 100) value = 100; 
                    x = value;// ключевое слово 'value' возвращает значение которое приходит извне.
            }
         }
         public double Y
         {
             get => y;
            set
            {
                y = value;
            }
         }

         public double Get_x() { return x; }
         public double Get_y() { return y; }
         public void Set_x(double x) { this.x = x; }
         public void Set_y(double y) { this.y = y; }
        // Auto Properties
        /* public double X { get; set; }
         public double Y { get; set; }*/
       public Point(double x=0, double y=0)
        {
            X = x;
            Y = y;
            Console.WriteLine($"Constructor {this.GetHashCode()}");
        }
        ~Point()
        {
            Console.WriteLine($"Destructor {this.GetHashCode()}");
        }
    }
}
