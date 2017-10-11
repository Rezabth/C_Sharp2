using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace RegexUnitTestProject1
{
    [TestClass]
    public class EmployeeConverterTests
    {
        [TestMethod]
        public void TestMethod1()
        {

            string pattern = @"\""""?([^\""""]*)\""? (\d{2}) (\d{5}.\d{2}) (\d{3}-\d{7})";
            string input = @"""Mattias Aspuland"" 46 35000.00 070-7829978";

            Match m = Regex.Match(input, pattern);
            Console.WriteLine("'{0}' found at index {1}", m.Value, m.Index);
        }
    }
}
