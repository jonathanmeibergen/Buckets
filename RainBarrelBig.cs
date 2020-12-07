using System;

namespace Buckets.Main
{
    public class RainBarrelBig : Bucket
    {
        private int _capacity;

        public RainBarrelBig() : base(capacity: 160)
        { }

        public override int Capacity
        {
            get => _capacity;
            set => throw new NotSupportedException("Capacity can not be set on RainBarrelBig");
        }
    }
}
