namespace FizzBuzzApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int max = 30;
            for (int i = 1; i <= max; i++)
            {
                Console.WriteLine($"{FizzBuzz(i)} ");
            }
        }

        public static string FizzBuzz(int i)
        {
            if (i % 15 == 0) return "FizzBuzz";
            else if (i % 3 == 0) return "Fizz";
            else if (i % 5 == 0) return "Buzz";            
            else return i.ToString();
        }

        
        public static int SmallestMultiple(int num)
        {
            //return 2520;
            int count = 1;
            int i = 0;
            while (i < num)
            {
                ++count;
                for (i = 1; i <= num; i++)
                {
                    if (count % i != 0)
                    {
                        break;
                    }
                }

            }
            return count;
        }
    }


}