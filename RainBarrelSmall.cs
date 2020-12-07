using System;

namespace Buckets.Main
{
    public class RainBarrelSmall : Bucket
    {
        private int _capacity;

        public RainBarrelSmall() : base(capacity: 80)
        {}

        public override int Capacity {
            get => _capacity;
            set => throw new NotSupportedException("Capacity can not be set on RainBarrelSmall");
        }
    }
}
