//Your task is to make two functions ( max and min, or maximum and minimum, etc., depending on the language ) that receive a list of integers as input, and return the largest and lowest number in that list, respectively. Each function returns one number.


using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
        public int Min(int[] list)
        {
            return list.Min();
        }

        public int Max(int[] list)
        {
            return list.Max();
        }
}
