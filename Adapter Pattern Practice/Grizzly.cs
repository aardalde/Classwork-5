/*
 * Aaron Alden
 * CSCI 352
 * February 10, 2023
 * Grizzly.cs
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern_Practice
{
    public class Grizzly : IBear
    {
        public void Maul()
        {
            Console.WriteLine("Call me Hugh Glass because I'm getting mauled by a Grizzly!");
        }

        public void Hibernate()
        {
            Console.WriteLine("Luckily, you will not get mauled by this hibernating bear!");
        }
    }
}
