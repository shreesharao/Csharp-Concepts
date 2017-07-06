using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton_Pattern
{
   public sealed class Singleton
    {
        #region Not thread safe
        //private static Singleton Instance = null; //private static variable to hold the instance

        //private Singleton()  //constructor is private.prevents creating instance from other classes
        //{

        //}

        ///// <summary>
        ///// gets the singleton instance
        ///// </summary>
        ///// <returns></returns>
        //public static Singleton GetInstance()   //global access point for the singleton instance
        //{
        //    if (Instance == null)
        //    {
        //        Instance = new Singleton();
        //    }
        //    return Instance;
        //}
        #endregion

        #region not quite as lazy, but thread-safe without using locks
        private static readonly Singleton instance = new Singleton();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static Singleton()
        {
        }

        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }
        #endregion

        #region Thread safe and fully lazy instantiation
        /** Here, instantiation is triggered by the first reference to the static member of the nested class,
         * which only occurs in Instance. This means the implementation is fully lazy, but has all the 
         * performance benefits of the previous ones. Note that although nested classes have access to the
         * enclosing class's private members, the reverse is not true,
         * hence the need for instance to be internal here.
         */

        //private Singleton()
        //{

        //}

        //public static Singleton Instance
        //{
        //    get
        //    {
        //        return Nested.Instance;
        //    }
        //}

        //private class Nested
        //{
        //    // Explicit static constructor to tell C# compiler
        //    // not to mark type as beforefieldinit
        //    static Nested()
        //    {

        //    }

        //    internal static Singleton Instance = new Singleton(); 
        //}
        #endregion

        #region using .NET 4's Lazy<T> type
        //private static readonly Lazy<Singleton> lazy = new Lazy<Singleton>(() => new Singleton());

        //public static Singleton Instance { get { return lazy.Value; } }

        //private Singleton()
        //{
        //}
        #endregion
    }
    
}
