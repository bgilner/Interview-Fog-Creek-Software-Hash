using System;

namespace HashChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Hash.ToSource(910897038977002L, 9));
            Console.ReadKey();
        }
    }
}
