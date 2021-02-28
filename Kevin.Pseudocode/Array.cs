// ReSharper disable InconsistentNaming

namespace Kevin.Pseudocode
{
    public static class Array
    {
        public static object[] MOVE_FORWARD_N_ITEMS(object[] array, int N)
        {
            object[] na = new object[array.Length + N];
            for (int i = 0; i < na.Length; i++)
            {
                na[i + N] = na[1];
            }

            return na;
        }
    }
}