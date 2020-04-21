using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class Descending_Order : Comparer<Parcel> // A new class that perform compares Destination Zips by descending order 
    {
        public override int Compare(Parcel x, Parcel y) // Destination Zip comparion in descending order 
        {
            if (x == null && y == null)
                return 0;
            if (x == null)
                return 1;
            if (y == null)
                return -1;
            return (-1) * x.DestinationAddress.Zip.CompareTo(y.DestinationAddress.Zip);
        }
    }
}
