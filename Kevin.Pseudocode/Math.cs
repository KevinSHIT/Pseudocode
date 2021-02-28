// ReSharper disable InconsistentNaming

namespace Kevin.Pseudocode
{
    public static class Math
    {
        public static double LOG(double x)
            => System.Math.Log(x);

        public static double LOG2(double x)
            => System.Math.Log2(x);

        public static double LOG10(double x)
            => System.Math.Log10(x);

        public static double LOGN(double x, double y)
            => System.Math.Log(x, y);

        public static int MOD(int x, int y)
            => x % y;

        public static double POW(double x, double y)
            => System.Math.Pow(x, y);

        public static double POW(int x, double y)
            => System.Math.Pow(x, y);

        public static double POW(int x, int y)
            => System.Math.Pow(x, y);

        public static double SQRT(double x)
            => System.Math.Sqrt(x);

        public static double SQRT(int x)
            => System.Math.Sqrt(x);

        public static double ABS(double x)
            => System.Math.Abs(x);

        public static double ABS(int x)
            => System.Math.Abs(x);

        public static double SIN(double x)
            => System.Math.Sin(x);

        public static double SINH(double x)
            => System.Math.Sinh(x);

        public static double ASIN(double x)
            => System.Math.Asin(x);

        public static double ASINH(double x)
            => System.Math.Asinh(x);

        public static double COS(double x)
            => System.Math.Cos(x);

        public static double COSH(double x)
            => System.Math.Cosh(x);

        public static double ACOS(double x)
            => System.Math.Acos(x);

        public static double ACOSH(double x)
            => System.Math.Acosh(x);

        public static double TAN(double x)
            => System.Math.Tan(x);

        public static double TANH(double x)
            => System.Math.Tanh(x);

        public static double ATAN(double x)
            => System.Math.Atan(x);

        public static double ATANH(double x)
            => System.Math.Atanh(x);

        public static double PI => System.Math.PI;

        public static double E => System.Math.E;
    }
}