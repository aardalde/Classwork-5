/*
 * Aaron Alden
 * CSCI 352
 * February 10, 2023
 * TeddyBear.cs
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern_Practice
{
    public class TeddyBear : IToyBear
    {
        public void Hug()
        {
            Console.WriteLine("*You are now hugging the overpriced Build-A-Bear bear*");
        }
    }
}
