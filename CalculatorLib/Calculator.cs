using System;

namespace CalculatorLib
{
    public class Calculator
    {
        public int Display { get; set; }

        public void PowerOn()
        {
           Display=0;
        }
        public void Press(string key)
        {
            Display = int.Parse(key);
        }
    }
}
