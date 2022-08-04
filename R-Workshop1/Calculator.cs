using System;
using System.Collections.Generic;
using System.Text;

namespace R_Workshop1
{
    internal class Calculator
    {
        internal List<string> Operations { get; set; }

        public Calculator()
        {
            Operations = new List<string>();
        }

        public double add(double a, double b)
        {
            addOperation($"Added {a} and {b} got result: {a+b}");
            return a + b;
        }

        private void addOperation(string v)
        {
            Operations.Add(v);
        }

        private void clearOperations()
        {
            Operations = new List<string>();
        }
    }
}
