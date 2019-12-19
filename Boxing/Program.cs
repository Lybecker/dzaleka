using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var myPet = new Pet { Name = "Vuffie" };  // value type
            var s = "fish"; // reference type
            int i = 42; // reference type
            var c = new Coordinate { X = 1, Y = 2 }; // reference type because it is a struct


            Object o = myPet;
            Pet p = (Pet)o;

            // Boxing / Unboxing
            Object intObject = i;
            int ii = (int)intObject;

            // Boxing
            var list = new ArrayList();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            // Use generics without boxing
            var betterList = new List<int>();
            betterList.Add(1);
            betterList.Add(2);
            betterList.Add(3);

            // type casting
            var number = Int32.Parse("101");

            int result;
            if (Int32.TryParse("102", out result))
            {
                Console.WriteLine(result);
            }
        }
    }

    class Pet
    {
        public string Name { get; set; }
    }

    struct Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
