using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            var lowercase = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            var uppercase = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            bool answer = false;

            for (int i = 0; i < lowercase.Length; i++)
            {
                if (c == lowercase[i])
                {
                    answer = true;
                }
                
            }

            for (int i = 0; i < uppercase.Length; i++)
            {
                if (c == uppercase[i])
                {
                    answer = true;
                }
                

            }

            return answer;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            var count = 0;
            for(int i = 0; i < vals.Length; i++)
            {
                count++; 
            }

            if (count % 2 == 0)
            {
                return true; 
            }
            else
            {
                return false; 
            }
        }

        public bool IsNumberEven(int number)
        {

            return (number % 2 == 0);

            // if (number % 2 == 0)
            //{
            //    return true;
            //}
            // else
            //{
            //    return false;
            //}

        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
            //if (num % 2 != 0)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            double min = 0;
            double max = 0;

            if(numbers == null || numbers.Count() == 0)
            {
                return 0;
            }

            foreach (var num in numbers)
            {
                if (numbers.Count() == 1)
                {
                    return num + num;
                }
            }

            foreach (var num in numbers)
            {
                if (num < min)
                {
                    min = num;
                }
                if (num > max)
                {
                    max = num;
                }
            }

            return min + max;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            int l1 = str1.Length;
            int l2 = str2.Length;

            return l1 < l2 ? l1 : l2;
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            int total = numbers.Sum();
            return total;
        }

        public int SumEvens(int[] numbers)
        {
            var sum = 0;

            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
            }

            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
                return false;

            var sum = numbers.Sum();

            return numbers.Count != 0 && sum % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
           return  (number <= 0) ? 0 : number / 2;
                

            
        }
    }
}
