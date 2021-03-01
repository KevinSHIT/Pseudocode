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
                => _type switch
                {
                    LETTYPE.INT => (double) _data,
                    LETTYPE.DOUBLE => (double) _data,
                    LETTYPE.STRING => ((string) _data).TO_DOUBLE(),
                    _ => throw new ArgumentOutOfRangeException()
                };

            public static implicit operator int(LET L)
                => _type switch
                {
                    LETTYPE.INT => (int) _data,
                    LETTYPE.DOUBLE => (int) _data,
                    LETTYPE.STRING => ((string) _data).TO_INT(),
                    _ => throw new ArgumentOutOfRangeException()
                };

            public static implicit operator string(LET L)
                => _type switch
                {
                    LETTYPE.INT => ((int) _data).ToString(),
                    LETTYPE.DOUBLE => ((double) _data).ToString(),
                    LETTYPE.STRING => (string) _data,
                    _ => null
                };

            public static LET operator ++(LET L)
                =>
                    L.GET_TYPE() switch
                    {
                        LETTYPE.DOUBLE => new LET((double) L + 1.0),
                        LETTYPE.INT => new LET((int) L + 1),
                        _ => L
                    };

            public static LET operator --(LET L)
                =>
                    L.GET_TYPE() switch
                    {
                        LETTYPE.DOUBLE => new LET((double) L - 1.0),
                        LETTYPE.INT => new LET((int) L - 1),
                        _ => L
                    };

            public static LET operator ==(LET l1, LET l2)
            {
                throw new NotImplementedException();
            }

            public static LET operator !=(LET l1, LET l2)
            {
                throw new NotImplementedException();
            }

            public static LET operator >(LET l1, LET l2)
            {
                throw new NotImplementedException();
            }

            public static LET operator <(LET l1, LET l2)
            {
                throw new NotImplementedException();
            }

            public static LET operator >=(LET l1, LET l2)
            {
                throw new NotImplementedException();
            }

            public static LET operator <=(LET l1, LET l2)
            {
                throw new NotImplementedException();
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
                => this;

            public static explicit operator LET(int i) => new LET(i);
            public static explicit operator LET(double d) => new LET(d);
            public static explicit operator LET(string s) => new LET(s);
        }
    }
}