using System;

// ReSharper disable InconsistentNaming

namespace Kevin.Pseudocode
{
    public static class Extension
    {
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