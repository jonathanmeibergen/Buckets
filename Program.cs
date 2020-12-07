using System;

namespace Buckets
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Bucket bckt = new Bucket(5);
            bckt.Fill(15);
        }
    }
}
