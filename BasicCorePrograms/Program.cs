﻿namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the following programs");
            Console.WriteLine("1. FlipCoin ");
            Console.WriteLine("0. Exit ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("1. Flip A Coin");
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.Read();
                    break;
                default:
                    break;
            }
        }
    }
}