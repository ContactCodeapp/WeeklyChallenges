using System;
using System.Collections;
using System.Text;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {

            if (vals == null || vals.Length == 0)
            {
                return false;
            }


            return vals.Contains(false) ? true : false;

            // if (vals == null || vals.Length == 0)
            // {
            //     return false;
            // }

            //for(int i = 0; i < vals.Length; i++)
            // {
            //  if (vals[i] == false)
            //     {
            //         return true;
            //     }
            //  else
            //     {
            //         return false;
            //     }
            // }

            
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return false;
            }

            var sum = numbers.Sum();
            var result = sum % 2;

            return (result == 0) ? false : true;

            //if (result == 0)
            //{
            //    return false;
            //}
            //else
            //{
            //    return true;
            //}
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            //var lower = new List<string> { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            //var upper = new List<string> { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            //var num = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            bool lower = false; 
            bool upper = false;
            bool num = false;

            foreach (var x in password)
            {
                if (char.IsLower(x))
                {
                    lower = true;
                }

                if (char.IsUpper(x))
                {
                    upper = true; 
                }

                if (char.IsDigit(x))
                {
                    num = true;
                }

            }

            return (lower == true && upper == true && num == true) ? true : false;
            


            //password.Contains("a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z");
            //                       "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z",
            //                        0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10))
            //{

                //}

        }

        public char GetFirstLetterOfString(string val)
        {
           return val.First();
        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return (divisor == 0) ? 0 : dividend / divisor;

            //if (divisor == 0)
            //{
            //    return 0;
            //}

            //return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            var first = nums.First();
            var last = nums.Last();

            return last - first;
        }

        

        public int[] GetOddsBelow100()
        {
            List<int> odds = new List<int>();
            int num = 1;

            do
            {
                if (num % 2 != 0)
                {
                    odds.Add(num);
                }
                num++;
            } while (num <= 100);

            return odds.ToArray();

        }
        public void ChangeAllElementsToUppercase(string[] words)
        {
            for(int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
                
            }
     
                
        }
    }
}
