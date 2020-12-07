using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buckets
{
    public abstract class Container
    {
        private int _content;

        public int Content { 
            get => _content; 
            set { 
                _content = value < Capacity ? value : Capacity; 
            } 
        }
        public abstract int Capacity { get; set; }

        public event EventHandler<int> Overflowing = delegate { };

        public event EventHandler Overflowed = delegate { };

        public event EventHandler Full = delegate { };

        public Container(int capacity)
        {
            Capacity = capacity;
            Overflowing += (a, b) => Console.WriteLine($"{a.ToString()} {a.GetHashCode().ToString()} is overflowing");
            Overflowed += (a, b) => Console.WriteLine($"{a.ToString()} {a.GetHashCode().ToString()} has overflowed");
        }

        public void Fill(int amount)
        {
            int vacuity = Capacity - Content;
            if(amount > vacuity)
            {
                Content += vacuity;
                int overflow = amount - vacuity;
                Overflowing.Invoke(this, overflow);
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
