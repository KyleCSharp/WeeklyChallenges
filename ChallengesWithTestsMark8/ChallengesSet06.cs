using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            var wordx = false;
            if (string.Equals(words,null) || words.Contains(null))
            {
                return false;
            }
            if (ignoreCase== true)
            {
                word = word.ToLower();
                List<string> L = words.Select(x => x.ToLower()).ToList();

                wordx = L.Contains(word);
            }
            if (ignoreCase == false)
            {
                wordx = words.Contains(word);
            }
            return wordx;
        }

        public bool IsPrimeNumber(int num)
        {

            var Prime = false;

            if (num >= 0)
            {
                if (num % 2 != 0 && num % 3 != 0)
                {
                    Prime = true;
                }
            }

            if ((num == 2) || (num == 3))
            {
                Prime = true;
            }

            if (num == 1)
            {
                Prime = false;
            }

            return Prime;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1;
            bool uindex;

            for (int i = 0; i < str.Length; i++)
            {
                uindex = true;

                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        uindex = false;
                    }
                }

                if (uindex == true)
                {
                    index = i;
                }
            }
            return index;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentCount = 1;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] != numbers[j])
                    {
                        break;
                    }

                    currentCount++;
                }

                if (currentCount > count)
                {
                    count = currentCount;
                }
            }

            return count;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> nthElement = new List<double>();
            double[] nullCheck = new double[0];

            if (elements == null)
            {
                return nullCheck;
            }

            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i] % n == 0)
                {
                    nthElement.Add(elements[i]);
                }

                if (n < 0 || n > elements.Count)
                {
                    nthElement.Clear();
                }
            }

            double[] finalArray = nthElement.ToArray();

            return finalArray;
        }
    }
}
