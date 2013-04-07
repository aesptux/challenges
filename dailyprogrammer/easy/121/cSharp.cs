using System;

namespace ByteExchangeChallenge
{
    class MainClass
    {
        static int ByteExchange (int coin)
        {
            if (coin == 0)
            {
                return 1;
            } else {
                return ByteExchange(coin/2) + ByteExchange(coin/3) + ByteExchange(coin/4);
            }
        }

        public static void Main (string[] args)
        {
            Console.WriteLine (ByteExchange(1000));
        }
    }
}
