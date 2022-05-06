using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(123);
            al.Add("reshmi");
            al.Add(false);
            al.Add(12.4);
            al.Insert(2, "what");
            al.Remove(3);
            foreach (object o in al)
            {
                Console.WriteLine(o);
            }


            Console.ReadKey();












            //Car car = new Car();

            //Console.WriteLine(car.speed);
            //Console.WriteLine(car.wheel);
            //car.go();

            //Bike bike = new Bike();
            //Console.WriteLine(bike.wheel);
            //Console.WriteLine(bike.speed);
            //bike.go();

            //try
            //{
            //    int[] a = { 3, 4, 5 };
            //    Console.WriteLine(a[3]);



            //}
            //catch (Exception ex)
            //{
            //    // logic

            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("This is should work any way");
            //}




            Console.ReadKey();
        }
    }
}
