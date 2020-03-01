using System;

namespace SelectiveFearOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static bool AmIAfraid(string day, int num)
        {

            //Monday-- > 12

            //Tuesday-- > numbers greater than 95

            //Wednesday-- > 34

            //Thursday-- > 0

            //Friday-- > numbers divisible by 2

            //Saturday-- > 56

            //Sunday-- > 666 or - 666
            switch (day)
            {
                case "Monday": if (num == 12) return true; break;
                case "Tuesday": if (num > 95) return true; break;
                case "Wednesday": if (num == 34) return true; break;
                case "Thursday": if (num == 0) return true; break;
                case "Friday": if (num % 2 == 0) return true; break;
                case "Saturday": if (num == 56) return true; break;
                case "Sunday": if (Math.Abs(num) == 666) return true; break;
                default:
                    break;
            }
            return false;
        }
    }
}
