using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRefresher
{
    /// <summary>
    /// A class to refresh my C# programming skills
    /// </summary>
    class Program
    {
        /// <summary>
        /// Prints a rain message
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            const double C = 3.0E+8;


            Console.WriteLine("Hello, world");

            Card myCard = new Card(5);
            myCard.look();
        }
    }

    /// <summary>
    /// a dummy class
    /// </summary>
    class Card
    {
        public int number;

        public Card(int num)
        {
            number = num;
        }
        public void look()
        {
            Console.WriteLine(number);
        }


    }
}
