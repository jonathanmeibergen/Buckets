using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buckets
{
    internal abstract class Container
    {
        //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-declare-and-use-read-write-properties
        private int _content;
        public int Content { get; set; }
        public abstract int Capacity { get; set; }

        public event EventHandler Overflowing = delegate { };

        public event EventHandler Overflowed = delegate { };

        public event EventHandler Full = delegate { };

        public Container(int capacity)
        {
            Capacity = capacity;
            Overflowing += (a, b) => Console.WriteLine($"{a.ToString()} is overflowing");
            Overflowed += (a, b) => Console.WriteLine($"{a.ToString()} has overflowed");
        }

        public void Fill(int amount)
        {
            int vacuity = Capacity - Content;
            if(amount > vacuity)
            {
                Content += vacuity;
                Overflowing.Invoke(this, EventArgs.Empty);
                int overflow = amount - vacuity;
                Content += overflow;
                Overflowed.Invoke(this, EventArgs.Empty);
            } else
            {
                Content += amount;
            }
        }

        public void Empty()
        {
            Content = 0;
        }

        public void Empty(int amount)
        {
            if (amount < Content)
                Content -= amount;
            else
                Empty();
        }
    }
}
