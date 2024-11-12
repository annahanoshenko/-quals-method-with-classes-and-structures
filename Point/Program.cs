using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {

            X = x; Y = y;
        }
        public double DistanceTo(Point other)
        {
            return Math.Sqrt((X - other.X) * (X - other.X) + (Y - other.Y) * (Y - other.Y));

        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Person other = (Person)obj;
            return Name == other.Name && Age == other.Age;
        }

        //public override int GetHashCode()
        //{
        //    return GetHashCode.Combine(Name, Age);
        //}


        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
                Point p = new Point(5, 16);
                Point p1 = new Point(5, 16);

                Console.WriteLine(p.Equals(p1));


            Person person = new Person("John", 30);
            Person person2 = new Person("John", 30);
            Console.WriteLine(person.Equals(person2));
        }
    }
}
