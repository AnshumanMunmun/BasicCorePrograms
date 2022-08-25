namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the following programs");
            Console.WriteLine("1. FlipCoin ");
            Console.WriteLine("2. LeapYear ");
            Console.WriteLine("3. Power Of 2 ");
            Console.WriteLine("4. Odd And Even ");
            Console.WriteLine("0. Exit ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("1. Flip A Coin");
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.Read();
                    break;
                case 2:
                    Console.WriteLine("2. LeapYear ");
                    LeapYear leapyear = new LeapYear();
                    leapyear.Read();
                    break;
                case 3:
                    Console.WriteLine("3. Power Of 2 ");
                    PowerOfTwo power = new PowerOfTwo();
                    power.Read();
                    break;
                case 4:
                    Console.WriteLine("4. Odd And Even ");
                    OddEven oddeve = new OddEven();
                    oddeve.Read();
                    break;
                default:
                    break;
            }
        }
    }
}