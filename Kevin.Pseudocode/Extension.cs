using System;

// ReSharper disable InconsistentNaming

namespace Kevin.Pseudocode
{
    public static class Extension
    {
        public static double TO_DOUBLE(this object obj)
            => double.Parse(obj.ToString() ?? string.Empty);

        public static int TO_INT(this object obj)
            => int.Parse(obj.ToString() ?? string.Empty);

        public static string TO_TO_STRING(this object obj)
            => obj.ToString();

        public static Exception Try(this Action act)
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
    }
}