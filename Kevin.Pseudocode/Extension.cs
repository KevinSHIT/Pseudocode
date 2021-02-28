using System;

// ReSharper disable InconsistentNaming

namespace Kevin.Pseudocode
{
    public static class Extension
    {
        public static bool TO_BOOL(this object obj)
            => obj.TO_INT() > 0 ? true : false;

        public static double TO_DOUBLE(this object obj)
            => double.Parse(obj.ToString() ?? string.Empty);

        public static double TO_DOUBLE(this bool obj)
            => obj.TO_INT();

        public static int TO_INT(this bool obj)
            => obj ? 1 : 0;

        public static int TO_INT(this double obj)
            => (int) obj;

        public static int TO_INT(this float obj)
            => (int) obj;

        public static int TO_INT(this object obj)
            => int.Parse(obj.ToString() ?? string.Empty);

        public static string TO_TO_STRING(this object obj)
            => obj.ToString();

        public static Exception TRY(this Action act)
        {
            try
            {
                act.Invoke();
            }
            catch (Exception ex)
            {
                return ex;
            }

            return null;
        }

        public static string TRIME(this string str)
            => str.Trim();

        public static string SUBSTRING(this string str, int index)
            => index < 0 ? str.Substring(0, str.Length - index) : str.Substring(index);

        public static string SUBSTRING(this string str, int index, int length)
            => str.Substring(index, length);
    }
}