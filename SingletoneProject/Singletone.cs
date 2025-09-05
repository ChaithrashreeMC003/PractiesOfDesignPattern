using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletoneProject
{
    public sealed class Singletone
    {
        private static int counter = 0;
        private static readonly object lockObj = new object();

        private Singletone()
        {
           
            Console.WriteLine("Counter Value: " + counter.ToString());
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

       
        private static Lazy<Singletone> object1 = new Lazy<Singletone>(() => new Singletone());

        public static Singletone GetIntence
        {
            get
            {
                counter++;
                return object1.Value;
            }
        }

      
        public int Counter => counter;

        // Reset for NUnit tests (not for production use)
        //public static void ResetForTests()
        //{
        //    counter = 0;
        //    object1 = new Lazy<Singletone>(() => new Singletone());
        //}

    }
}
