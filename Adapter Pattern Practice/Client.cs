/*
 * Aaron Alden
 * CSCI 352
 * February 10, 2023
 * Client.cs
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern_Practice
{
    public class Client
    {
        static void Main(string[] args)
        {
            IBear grizzly = new Grizzly();
            IToyBear teddyBear = new TeddyBear();
            IToyBear bearAdapter = new BearAdapter(grizzly);

            Console.WriteLine("Output from grizzly.Maul(): ");
            grizzly.Maul();
            Console.WriteLine(" ");

            Console.WriteLine("Output from grizzly.Hibernate(): ");
            grizzly.Hibernate();
            Console.WriteLine(" ");

            Console.WriteLine("Output from  teddyBear.Hug(): ");
            teddyBear.Hug();
            Console.WriteLine(" ");

            Console.WriteLine("Output from bearAdapter.Hug(): ");
            bearAdapter.Hug();
            Console.WriteLine(" ");
        }
    }
}
