using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }

        #region Operator Overloading

        // must be Static member function
        // Can't overload = or []

        public static Complex operator +(Complex l, Complex r)
        {
            return new Complex()
            {
                Real = (l?.Real ?? 0) + (r?.Real ?? 0),
                Imag = (l?.Imag ?? 0) + (r?.Imag ?? 0)
            };
        }

        /*        public static Complex operator +(Complex l, int r)
                {
                    return new Complex()
                    {
                        Real = (l?.Real ?? 0) + r,
                        Imag = (l?.Imag ?? 0)
                    };
                }


                // You can't Explicitly overload assignment operators (+= , -= , ...)
                // if you overload original operator (+ , - ,..) , 
                // assignment operators will be supported by default


                public static Complex operator -(Complex c)
                {
                    return new Complex()
                    {
                        Real = -c.Real,
                        Imag = -c.Imag
                    };
                }


                // Prefix & Postfix
                public static Complex operator ++(Complex c)
                {
                    return new Complex()
                    {
                        Real = c.Real + 1,
                        Imag = -c.Imag
                    };
                }


                // Compar. operators comes in pairs
                public static bool operator >(Complex l, Complex r)
                {
                    if (l.Real == r.Real)
                        return l.Imag > r.Imag;
                    return l.Real > r.Real;
                }

                public static bool operator <(Complex l, Complex r)
                {
                    if (l.Real == r.Real)
                        return l.Imag < r.Imag;

                    return l.Real < r.Real;
                }*/


        #region Casting Operator Overloading

        public static explicit operator int(Complex c)
        {
            return c?.Real ?? 0;
        }

        public static implicit operator string(Complex c) { return c?.ToString() ?? "NA"; } 
        #endregion



        #endregion

        public override string ToString()
        {
            return $"{Real}:{Imag}";
        }
    }
}
