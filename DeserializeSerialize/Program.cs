using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace DeserializeSerialize
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new Person();
            obj.Age = 42;
            obj.Name = "Anders";
            obj.Children = new List<Child>();
            obj.Children.Add(new Child() { Name = "Sophia" });
            obj.Children.Add(new Child() { Name = "Victoria" });

            var jsonString = JsonConvert.SerializeObject(obj);
            Console.WriteLine(jsonString);

            StoreOnDisk(jsonString);

            var obj2 = JsonConvert.DeserializeObject<Person>(jsonString);

            Console.WriteLine(obj2.Name);
            Console.WriteLine(obj2.Age);

            Console.ReadKey();
        }

        public static void StoreOnDisk(string content)
        {
            System.IO.File.WriteAllText(@"c:\tempz\appfactory.txt", content);
        }
    }

    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public List<Child> Children { get; set; }
    }

    class Child
    {
        public string Name { get; set; }
    }
}