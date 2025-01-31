using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01ِADV.Q1
{
    internal class Range<T> where T :IComparable<T>
    {
        public T Minimum { get; set; }
        public T Maximum { get; set; }
        public Range(T minimum,T maximum) 
        {
            Minimum = minimum;
            Maximum = maximum;
            if (Minimum.CompareTo(Maximum) == 1)
            {
                (Minimum, Maximum) = (Maximum, Minimum);
            }
        }
        public bool IsInRange(T value)
        {
            return Minimum.CompareTo(value) <= 0&& Maximum.CompareTo(value) >= 0;
        }
        //public int Length()
        //{
        //    int result = 0;
        //    for (T i = Minimum; i.CompareTo(Maximum) == -1;)
        //    {
        //        result++;

        //    }
        //    return result;
        //}
    }
}
