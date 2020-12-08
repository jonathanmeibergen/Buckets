using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buckets
{
    public class Bucket : Container
    {
        private int _capacity;

        public Bucket(int capacity) : base(capacity) 
        {}

        public override int Capacity
        {
            get => _capacity;
            set { 
                _capacity = value < 10 ? 10 : value; 
            }
        }

        public void Fill(Bucket bucket)
        {
            base.Fill(bucket.Content);

            bucket.Content = 0;
        }

        public void Fill(Bucket bucket, bool AllowOverflow)
        {
            if (AllowOverflow)
                Fill(bucket);
            else
            {
                if (Content == Capacity)
                {
                    int vacuity = Capacity - Content;
                    int overflow = bucket.Content - vacuity;
                    Console.WriteLine($"{this.ToString()} {this.GetHashCode().ToString()} is about to overflow with {overflow} liters, continue filling? Y|N");
                    ConsoleKeyInfo choice = Console.ReadKey(intercept: true);
                    if (choice.Key.Equals(ConsoleKey.Y))
                    {
                        Fill(bucket);
                    }
                    else if (choice.Key.Equals(ConsoleKey.N))
                    {
                        return;
                    }
                }
                else
                {
                    Fill(bucket);
                }

                /*while (bucket.Content != 0)
                {
                    bucket.Content--;
                    Content++;
                    if (Content == Capacity)
                    {
                        Console.WriteLine($"{this.ToString()} {this.GetHashCode().ToString()} is about to overflow with {overflow} liters, continue filling? Y|N");
                        ConsoleKeyInfo choice = Console.ReadKey(intercept:true);
                        if (choice.Key.Equals(ConsoleKey.Y))
                        {
                            Console.WriteLine($"{this.ToString()} {this.GetHashCode().ToString()} is overflowing");
                            continue;
                        } else if (choice.Key.Equals(ConsoleKey.N))
                        {
                            break;
                        }

                    } else if (bucket.Content == 0)
                    {
                        Console.WriteLine($"{this.ToString()} {this.GetHashCode().ToString()} has overflowed");
                    }
                }*/
            }
        }
    }
}
