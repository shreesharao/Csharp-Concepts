using System;
using System.Collections.Generic;

namespace DotNet_store
{
    class Topic23
    {
        public void Entry()
        {
            Comparer<Company> comparer = new Comparer<Company>();
            Dictionary<Company, Company> pairs = new Dictionary<Company, Company>(comparer);

            Company c1 = new Company(1);
            Company c2 = new Company(1);
            try
            {
                pairs.Add(c1, c1);
                pairs.Add(c2, c2);
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }
           
        }

    }

    public class Comparer<T> : EqualityComparer<T> where T : Company
    {

        public override bool Equals(T x, T y)
        {
            return x.Id == y.Id;
        }

        //if GetHashCode returns different hash codes then Equals method is never called
        public override int GetHashCode(T obj)
        {
            int id = obj.Id;
            return id.GetHashCode();
        }
    }

    public class Company
    {
        public Company(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
