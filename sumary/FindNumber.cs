using System;
using System.Collections.Generic;
using System.Text;

namespace sumary
{
    public class FindNumber
    {
        public string getNumber(string text,int number) {
            char[] tekstchar = text.ToCharArray();
            int sumary;
            string wynik;
            var i = (number % tekstchar.Length)-1;
            if (i == -1)
            {
                wynik = tekstchar[tekstchar.Length-1].ToString();
            }
            else
            {
                sumary = (number % tekstchar.Length) - 1;
                wynik = tekstchar[sumary].ToString();
            }
            return wynik;
        }
    }
}
