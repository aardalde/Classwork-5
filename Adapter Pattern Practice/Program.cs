/*
 * Aaron Alden
 * CSCI 352
 * February 10, 2023
 * Program.cs
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern_Practice
{
    public class Program
    {
        static void Main(string[] args)
        {
            IBear grizzly = new Grizzly();
            IToyBear teddyBear = new TeddyBear();
            IToyBear bearAdapter = new BearAdapter(grizzly);
            
            grizzly.Maul();
            grizzly.Hibernate();
            teddyBear.Hug();
            bearAdapter.Hug();
        }
    }
}
