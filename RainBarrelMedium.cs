using System;

namespace Buckets.Main
{
    public class RainBarrelMedium : Bucket
    {
        private int _capacity;

        public RainBarrelMedium() : base(capacity: 120)
        { }

        public override int Capacity
        {
            get => _capacity;
            set => throw new NotSupportedException("Capacity can not be set on RainBarrelMedium");
        }
    }
}
