using System;

// ReSharper disable NonReadonlyMemberInGetHashCode
// ReSharper disable SpecifyACultureInStringConversionExplicitly
// ReSharper disable MemberCanBeMadeStatic.Global
// ReSharper disable CA1822
// ReSharper disable IdentifierTypo
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable InconsistentNaming

namespace Kevin.Pseudocode
{
    public class Type
    {
        public enum LETTYPE
        {
            DOUBLE,
            INT,
            STRING
        }

        public class LET
        {
            #region Obj Base

            public override string ToString()
                => this;

            protected bool Equals(LET other)
                => this == other;

            public override bool Equals(object obj)
            {
                if (ReferenceEquals(null, obj)) return false;
                if (ReferenceEquals(this, obj)) return true;
                return obj.GetType() == GetType() && Equals((LET) obj);
            }

            public override int GetHashCode()
                => _data.GetHashCode();

            #endregion

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

            #region Implicit Cast

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

            public static explicit operator LET(int i) => new LET(i);
            public static explicit operator LET(double d) => new LET(d);
            public static explicit operator LET(string s) => new LET(s);

            #endregion

            public static LET operator ++(LET L)
                => L.GET_TYPE() switch
                {
                    LETTYPE.DOUBLE => new LET((double) L + 1.0),
                    LETTYPE.INT => new LET((int) L + 1),
                    _ => L
                };

            public static LET operator --(LET L)
                => L.GET_TYPE() switch
                {
                    LETTYPE.DOUBLE => new LET((double) L - 1.0),
                    LETTYPE.INT => new LET((int) L - 1),
                    _ => L
                };

            private static LETTYPE GetCommonType(LET l1, LET l2)
            {
                return GetCommonType(l1, l2, out bool _);
            }

            private static LETTYPE GetCommonType(LET l1, LET l2, out bool restrict)
            {
                restrict = true;
                if (l1.GET_TYPE() == l2.GET_TYPE())
                    return l1.GET_TYPE();
                restrict = false;
                if (l1.GET_TYPE() == LETTYPE.STRING ||
                    l2.GET_TYPE() == LETTYPE.STRING)
                {
                    return LETTYPE.STRING;
                }

                if (l1.GET_TYPE() == LETTYPE.DOUBLE ||
                    l2.GET_TYPE() == LETTYPE.DOUBLE)
                {
                    return LETTYPE.DOUBLE;
                }

                return LETTYPE.INT;
            }

            public static bool operator ==(LET l1, LET l2)
                => GetCommonType(l1, l2) switch
                {
                    // FIXME: Double -> Decimal
                    LETTYPE.DOUBLE => System.Math.Abs((double) l1 - (double) l2) < 0.0000003,
                    LETTYPE.INT => (int) l1 == (int) l2,
                    LETTYPE.STRING => (string) l1 == (string) l2,
                    _ => throw new ArgumentOutOfRangeException()
                };

            public static bool operator !=(LET l1, LET l2) => !(l1 == l2);

            public static bool operator >(LET l1, LET l2)
                => GetCommonType(l1, l2) switch
                {
                    // FIXME: Double -> Decimal
                    LETTYPE.DOUBLE => (double) l1 > (double) l2,
                    LETTYPE.INT => (int) l1 > (int) l2,
                    LETTYPE.STRING => ((string) l1).Length > ((string) l2).Length,
                    _ => throw new ArgumentOutOfRangeException()
                };

            public static bool operator <(LET l1, LET l2)
                => GetCommonType(l1, l2) switch
                {
                    // FIXME: Double -> Decimal
                    LETTYPE.DOUBLE => (double) l1 < (double) l2,
                    LETTYPE.INT => (int) l1 < (int) l2,
                    LETTYPE.STRING => ((string) l1).Length < ((string) l2).Length,
                    _ => throw new ArgumentOutOfRangeException()
                };

            public static bool operator >=(LET l1, LET l2)
                => (l1 == l2) || (l1 > l2);

            public static bool operator <=(LET l1, LET l2)
                => (l1 == l2) || (l1 < l2);


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
        }
    }
}