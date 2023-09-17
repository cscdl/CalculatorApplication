﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    public delegate T Formula<T>(T arg, T arg1);
    class CalculatorClass
    {
        public Formula<double> total;

        public double GetSum(double num1, double num2)
        {
            return num1 + num2;
        }

        public double GetDifference(double num1, double num2)
        {
            return num1 - num2;
        }

        public event Formula<double> CalculateEvent
        {
            add
            {
                Console.WriteLine("Added the Delegate");
                total += value;
            }
            remove
            {
                Console.WriteLine("Removed the Delegate");
                total -= value;
            }
        }

        public double GetProduct(double num1, double num2)
        {
            return num1 * num2;
        }

        public double GetQoutient(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
