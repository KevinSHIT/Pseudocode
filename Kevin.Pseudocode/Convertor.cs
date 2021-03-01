namespace Kevin.Pseudocode
{
    public static class Convertor
    {
        #region TO_BOOL

        public static bool TO_BOOL(this bool obj)
            => obj;

        public static bool TO_BOOL(this object obj)
            => obj.TO_INT() > 0;

        #endregion

        #region TO_DOUBLE

        public static double TO_DOUBLE(this double obj)
            => obj;

        public static double TO_DOUBLE(this float obj)
            => obj;

        public static double TO_DOUBLE(this bool obj)
            => obj.TO_INT();

        public static double TO_DOUBLE(this object obj)
            => double.Parse(obj.ToString() ?? string.Empty);

        #endregion

        #region TO_INT

        public static int TO_INT(this int obj)
            => obj;

        public static int TO_INT(this bool obj)
            => obj ? 1 : 0;

        public static int TO_INT(this double obj)
            => (int) obj;

        public static int TO_INT(this float obj)
            => (int) obj;

        public static int TO_INT(this object obj)
            => int.Parse(obj.ToString() ?? string.Empty);

        #endregion

        #region TO_STRING

        public static string TO_STRING(this string obj)
            => obj;

        public static string TO_STRING(this object obj)
            => obj.ToString();

        #endregion
    }
}