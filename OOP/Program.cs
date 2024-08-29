using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Get/Set: ");
            Point A = new Point(2,3);
           // A.Set_x(2);
           // A.Set_y(3);
            Console.WriteLine($"X = {A.Get_x()}, Y = {A.Get_y()} ");
            Console.WriteLine("Properties: ");
            Point B = new Point();
            B.X = 7;
            B.Y = 8;
            Console.WriteLine($"X = {B.X}, Y = {B.Y}");
            
        }
    }
}