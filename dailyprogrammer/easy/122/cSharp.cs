using System;

namespace DigitalRootChallenge
{
    class MainClass
    {
        static int DigitalRoot (int n)
        {
            while (n > 9) {
                n = (n % 10) + (n / 10);
            }
            return n;
        }

        public static void Main (string[] args)
        {
            Console.WriteLine (DigitalRoot(31337));
        }
    }
}
