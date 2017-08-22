﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_store
{
    class Topic_16
    {
        public void Entry()
        {
            Example.ExampleMain();
        }
    }

    public class IdInfo
    {
        public int IdNumber;

        public IdInfo(int IdNumber)
        {
            this.IdNumber = IdNumber;
        }
    }

    public class Person
    {
        public int Age;
        public string Name;
        public IdInfo IdInfo;

        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }
        
        public Person DeepCopy()
        {
            Person other = (Person)this.MemberwiseClone();
            other.IdInfo = new IdInfo(this.IdInfo.IdNumber);
            other.Name = String.Copy(this.Name);
            return other;
        }

        //Below is another way of doing deep copy.Here class must be marked with [Serializable] attribute

        //public T DeepCopyAnotherApproach<T>(T obj)
        //{
        //    using (var ms = new MemoryStream())
        //    {
        //        var formatter = new BinaryFormatter();
        //        formatter.Serialize(ms, obj);
        //        ms.Position = 0;

        //        return (T)formatter.Deserialize(ms);
        //    }
        //}
    }

    public class Example
    {
        public static void ExampleMain()
        {
            // Create an instance of Person and assign values to its fields.
            Person p1 = new Person();
            p1.Age = 42;
            p1.Name = "Sam";
            p1.IdInfo = new IdInfo(6565);

            // Perform a shallow copy of p1 and assign it to p2.
            Person p2 = (Person)p1.ShallowCopy();

            // Display values of p1, p2
            Console.WriteLine("Original values of p1 and p2:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine("   p2 instance values:");
            DisplayValues(p2);

            // Change the value of p1 properties and display the values of p1 and p2.
            p1.Age = 32;
            p1.Name = "Frank";
            p1.IdInfo.IdNumber = 7878;
            Console.WriteLine("\nValues of p1 and p2 after changes to p1:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine("   p2 instance values:");
            DisplayValues(p2);

            // Make a deep copy of p1 and assign it to p3.
            Person p3 = p1.DeepCopy();
            // Change the members of the p1 class to new values to show the deep copy.
            p1.Name = "George";
            p1.Age = 39;
            p1.IdInfo.IdNumber = 8641;
            Console.WriteLine("\nValues of p1 and p3 after changes to p1:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine("   p3 instance values:");
            DisplayValues(p3);

            // Make an equal of p1 and assign it to p4.
            Person p4 = new Person();
            p4 = p1;
            // Change the members of the p1 class to new values to show the equal copy.
            p1.Name = "Will";
            p1.Age = 30;
            p1.IdInfo.IdNumber = 8484;
            Console.WriteLine("\nValues of p1 and p4 after changes to p1:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine("   p4 instance values:");
            DisplayValues(p4);
        }

        public static void DisplayValues(Person p)
        {
            Console.WriteLine("      Name: {0:s}, Age: {1:d}", p.Name, p.Age);
            Console.WriteLine("      Value: {0:d}", p.IdInfo.IdNumber);
        }

    }
}
