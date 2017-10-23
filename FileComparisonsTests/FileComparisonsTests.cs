using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FileComparisonsTests
{
    [TestClass]
    public class FileComparisonsTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            byte[] fileOne = FileComparisonsTests.ReadAllBytes("hello1.txt");
            byte[] fileTwo = FileComparisonsTests.ReadAllBytes("hello2.txt");
            var alg = SHA512.Create();
            byte[] fileOneHash = alg.ComputeHash(fileOne);
            byte[] fileTwoHash = alg.ComputeHash(fileTwo);
            Assert.IsTrue(HashesAreEqual(fileOneHash,fileTwoHash));


        }
    }
}
