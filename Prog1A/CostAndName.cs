using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class Extra_Credit : Comparer<Parcel>
    {
        public override int Compare(Parcel x, Parcel y)
        {
            string t1 = x.GetType().Name; // Gettype returns types of X, Y and name in string representation 
            string t2 = y.GetType().Name;

            if (x == null && y == null) // Null handling 
                return 0;
            if (x == null)
                return -1;
            if (y == null)
                return 1;

            if (t1.Equals(t2)) // Comparison by cost
            {
                if (x.CalcCost().Equals(y.CalcCost()))
                    return 0;
                return (x.CalcCost().CompareTo(y.CalcCost()));
            }
            return t1.CompareTo(t2); // Sort by Name

        }
    }
}
