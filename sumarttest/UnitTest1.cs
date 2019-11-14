using NUnit.Framework;
using sumary;
using System;

namespace Tests
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
        }

        [TestCase("ABCDE", "E",5)]
        [TestCase("ABC", "A",13)]
        [TestCase("CGSKDJ", "G",2)]
        [TestCase("Ala ma kota", " ",7)]
        [TestCase("Ala ma kota", "o",9)]
        [TestCase("Ala ma kota", "a",11)]
        public void GetChar(string text, string result,int number)
        {
            FindNumber findNumber = new FindNumber();
            string wynik = findNumber.getNumber(text,number);
            Assert.AreEqual(result,wynik);
        }
        //[TestCase("12c3", 6)]
        //[TestCase("4c83", 15)]
        //[TestCase("1-9c34", 17)]
        //public void IsNotNumber(string liczba, int result)
        //{
            
        //}
    }
}