using System;

namespace StringCalc
{
    public class ProgramCalc
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add("1,-2,-3"));
        }

        public static int Add(string num)
        {
            char[] delimiters = { ';', '\n', '/', ',' };
            List<int> negativeNumbers = new List<int> { };
            if (num == "") return 0;

            else if (num.Contains("-"))
            {
                negativeNumbers = num.Split(delimiters).Select(int.Parse).ToList();
                foreach (int i in negativeNumbers)
                {
                    if (i < 0)
                    {
                        Console.WriteLine(i);
                        negativeNumbers.Add(i);

                    }
                }
                throw new ArgumentOutOfRangeException($"negatives not allowed {negativeNumbers}");
            }
            else
            {
                List<int> numbers = num.Split(delimiters).Select(int.Parse).ToList();
                return numbers.Sum();
            }
               

            
        }        
    }
}