using System;

namespace Buckets.Main
{
    public class OilDrum : Container
    {
        private int _capacity;

        public OilDrum() : base(capacity: 159)
        { }

        public override int Capacity
        {
            get => _capacity;
            set => throw new NotSupportedException("Capacity can not be set on OilDrum");
        }

        public void Fill(OilDrum oilDrum)
        {
            base.Fill(oilDrum.Content);
            oilDrum.Empty();
        }
    }
}
