using System;
using System.Collections;

namespace WorkingWithCollection
{
    class Collection
    {
        public void log()
        {
            Car car1 = new Car();
            Car car2 = new Car();
            Book book1 = new Book();
            // // array
            // ArrayList csArray = new ArrayList();
            // csArray.Add("Hello");
            // csArray.Add("World");


            ArrayList csArray = new ArrayList() {"Hello", "world"};
            foreach (string item in csArray)
            {
                Console.WriteLine(item);
            }

            // // List<T>
            // List<Car> csList = new List<Car>();
            // csList.Add(car1);
            // csList.Add(car2);
            // // csList.Add(book1);
            

            // List<Car> csList = new List<Car>(){car1, car2};
            // foreach (Car item in csList)
            // {
            //     item.Log();
            // }


            // Dictionary<TKey, TValue>
            // Dictionary<string, Car> csDict = new Dictionary<string, Car>(); // dictionary
            // csDict.Add("key-1", car1);
            // csDict.Add("key-2", car2);

            // Console.WriteLine(csDict["key-1"].Ster());

            // foreach (Car item in csDict)
            // {
            //     item.log();
            // }


            // string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            // foreach (string item in weekDays)
            // {
            //     Console.WriteLine(item);
            // }

            // Car car3 = new Car() { Prop1 = "value1", Prop2 = "value2" };
        }
    }

    class Car
    {

        public string Prop1;
        public string Prop2;
        public string Prop3;



        public string Ster()
        {
            return "Hello Car";
        }
        public void Log()
        {
            Console.WriteLine("Car logged ...");
        }
    }

    class Book
    {
        public void log()
        {
            Console.WriteLine("Book logged ...");
        }
    }
}