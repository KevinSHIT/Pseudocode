using System;

// ReSharper disable InconsistentNaming

namespace Kevin.Pseudocode
{
    public class Type
    {
        public enum LETTYPE
        {
            DOUBLE,
            INT,
            [Obsolete] STRING
        }

        public class LET
        {
            private static LETTYPE _type;
            private static object _data;

            public LETTYPE GET_TYPE()
                => _type;

            #region Constructors

            public LET(double d)
            {
                _type = LETTYPE.DOUBLE;
                _data = d;
            }

            public LET(string s)
            {
                _type = LETTYPE.STRING;
                _data = s;
            }

            public LET(int i)
            {
                _type = LETTYPE.INT;
                _data = i;
            }

            #endregion

            public static implicit operator double(LET L)
            {
                if (_type == LETTYPE.DOUBLE)
                {
                    return (double) _data;
                }

                return _data.TO_DOUBLE();
            }

            public static implicit operator int(LET L)
            {
                if (_type == LETTYPE.INT)
                {
                    return (int) _data;
                }

                return _data.TO_INT();
            }

            public static implicit operator string(LET L)
            {
                if (_type == LETTYPE.STRING)
                {
                    return (string) _data;
                }

                return _data.TO_STRING();
            }

            public static LET operator +(LET l1, LET l2)
            {
                throw new NotImplementedException();
            }

            public static LET operator -(LET l1, LET l2)
            {
                throw new NotImplementedException();
            }

            public static LET operator *(LET l1, LET l2)
            {
                throw new NotImplementedException();
            }

            public static LET operator /(LET l1, LET l2)
            {
                throw new NotImplementedException();
            }

            public static LET operator %(LET l1, LET l2)
            {
                throw new NotImplementedException();
            }

            #region Operator Overloads

            public static LET operator +(LET l1, double l2)
                => l1 + (LET) l2;

            public static LET operator +(double l1, LET l2)
                => (LET) l1 + l2;

            public static LET operator +(int l1, LET l2)
                => (LET) l1 + l2;

            public static LET operator +(LET l1, int l2)
                => l1 + (LET) l2;


            public static LET operator -(int l1, LET l2)
                => (LET) l1 - l2;


            public static LET operator -(LET l1, int l2)
                => l1 - (LET) l2;


            public static LET operator -(double l1, LET l2)
                => (LET) l1 - l2;

            public static LET operator -(LET l1, double l2)
                => l1 - (LET) l2;


            public static LET operator *(int l1, LET l2)
                => (LET) l1 * l2;

            public static LET operator *(LET l1, int l2)
                => l1 * (LET) l2;

            public static LET operator *(double l1, LET l2)
                => (LET) l1 * l2;

            public static LET operator *(LET l1, double l2)
                => l1 * (LET) l2;


            public static LET operator /(double l1, LET l2)
                => (LET) l1 / l2;

            public static LET operator /(LET l1, double l2)
                => l1 / (LET) l2;

            public static LET operator /(int l1, LET l2)
                => (LET) l1 / l2;

            public static LET operator /(LET l1, int l2)
                => l1 / (LET) l2;


            public static LET operator %(int l1, LET l2)
                => (LET) l1 % l2;

            public static LET operator %(LET l1, int l2)
                => l1 % (LET) l2;

            public static LET operator %(double l1, LET l2)
                => (LET) l1 % l2;

            public static LET operator %(LET l1, double l2)
                => l1 % (LET) l2;

            #endregion

            public override string ToString()
                => TO_STRING();

            private string TO_STRING()
            {
                switch (_type)
                {
                    case LETTYPE.INT:
                        return ((int) _data).ToString();
                    case LETTYPE.DOUBLE:
                        return ((double) _data).ToString();
                    case LETTYPE.STRING:
                        return (string) _data;
                }

                return null;
            }

            public static explicit operator LET(int i) => new LET(i);
            public static explicit operator LET(double d) => new LET(d);
            public static explicit operator LET(string s) => new LET(s);
        }
    }
}