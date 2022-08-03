using System;
using System.Collections.Generic;
using System.Text;

namespace R_Workshop1
{
    internal class Calculator
    {
        private List<string> Operations { get; set; }

        public Calculator()
        {
            this.Operations = new List<string>();
        }

        public double add(double a, double b)
        {
            addOperation($"Added {a} and {b} got result: {a+b}");
            return a + b;
        }

        private void addOperation(string v)
        {
            this.Operations.Add(v);
        }

        private void clearOperations()
        {
            this.Operations = new List<string>();
        }
    }
}
