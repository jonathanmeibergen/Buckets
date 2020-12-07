using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buckets.Main
{
    public class RainBarrelSmall : Container
    {
        private int _capacity;

        public RainBarrelSmall() : base(capacity: 80)
        {}

        public override int Capacity { 
            get => _capacity; 
            set { }
        }
    }
}
