using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterNumbers
{
    class EnterNumbersMain
    {
        static void Main(string[] args)
        {
            try
            {
                int previuosNum = 0;
                List<int> numbers = new List<int>();
                for (int i = 0; i < 10; i++)
                {
                    int currentNum = ReadNumber(2, 99);
                    if (i > 0 && currentNum <= previuosNum)
                    {
                        throw new ArgumentException();
                    }
                    numbers.Add(currentNum);
                    previuosNum = currentNum;


                }

                Console.WriteLine(string.Join(", ", numbers));
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The number is equal or smaller than the previous number.");              
            }
        }


        public static int ReadNumber(int start, int end)
        {
            int n = start - 1;
            try
            {
                n = int.Parse(Console.ReadLine());
                if (n < start || n > end)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number.Try again");
                while (true)
                {
                    try
                    {
                        n = int.Parse(Console.ReadLine());
                        if (n < start || n > end)
                        {
                            throw new ArgumentOutOfRangeException();
                        }
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid number.Try again");
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine(String.Format("The number is not in the range [{0}-{1}]",
                        start, end));
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine(String.Format("The number is not in the range [{0}-{1}].Try again",
                        start, end));
                while (true)
                {
                    try
                    {
                        n = int.Parse(Console.ReadLine());
                        if (n < start || n > end)
                        {
                            throw new ArgumentOutOfRangeException();
                        }
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid number.Try again");
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine(String.Format("The number is not in the range [{0}-{1}].Try again",
                        start, end));
                    }
                }
            }
        

            return n;
        }
    }
}
