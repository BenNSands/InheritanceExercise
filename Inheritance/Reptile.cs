using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Reptile : Animal
    {
        public int TailLength { get; set; }
        public int NumOfTeeth { get; set; }
        public string NativeRegion { get; set; }
        public bool Regeneration { get; set; }

    }
}
