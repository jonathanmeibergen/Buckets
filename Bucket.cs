using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buckets
{
    internal class Bucket : Container
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
    }
}
