/*
 * Aaron Alden
 * CSCI 352
 * February 10, 2023
 * BearAdapter.cs
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern_Practice
{
    public class BearAdapter : IToyBear
    {
        IBear bear;

        public BearAdapter(IBear bear)
        {
            this.bear = bear;
        }

        public void Hug()
        {
            Console.WriteLine("Wait a minute. This teddy bear sure looks angry...");
            bear.Maul();
        }
    }
}
