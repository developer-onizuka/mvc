using System;
using Caluclation.Mathlib;

namespace Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
	    CalculationAdd val = new CalculationAdd();
            Console.WriteLine(val.Add(1,2));
        }
    }
}
