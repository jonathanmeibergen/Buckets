using System;

namespace Buckets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Buckets!");
            Bucket b = new Bucket(12);
            b.Fill(b.Capacity-5);
            Bucket b2 = new Bucket(12);
            b2.Fill(b2.Capacity-3);
            b2.Fill(b);

        }
    }
}
