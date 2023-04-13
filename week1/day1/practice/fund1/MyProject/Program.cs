
    class Program
    {
        static void Main(string[] args)
        {
            // Loop that prints all values from 1-255
            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }

            // Loop that prints all values from 1-100 that are divisible by 3 or 5, but not both
            for (int i = 1; i <= 100; i++)
            {
                if ((i % 3 == 0 || i % 5 == 0) && !(i % 3 == 0 && i % 5 == 0))
                {
                    Console.WriteLine(i);
                }
            }

            // Loop that prints "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for multiples of both 3 and 5
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            // Loop that prints all values from 1-100 that are divisible by 3 or 5, but not both using a while loop
            int j = 1;
            while (j <= 100)
            {
                if ((j % 3 == 0 || j % 5 == 0) && !(j % 3 == 0 && j % 5 == 0))
                {
                    Console.WriteLine(j);
                }
                j++;
            }

            // Loop that prints "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for multiples of both 3 and 5 using a while loop
            int k = 1;
            while (k <= 100)
            {
                if (k % 3 == 0 && k % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (k % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (k % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(k);
                }
                k++;
            }
        }
    }

