using System;

// ReSharper disable MethodOverloadWithOptionalParameter
// ReSharper disable InconsistentNaming

namespace Kevin.Pseudocode
{
    public static class IO
    {
        #region READLINE

        public static string READLN()
            => Console.ReadLine();

        public static string READLINE()
            => Console.ReadLine();

        #endregion

        #region PRINT

        public static void PRINT(object o)
            => Console.Write($"{o}");

        public static void PRINT(params object[] os)
            => PRINT(os, false);

        public static void PRINT(object[] os, bool skipFirstItem = false)
        {
            foreach (object o in os)
            {
                if (skipFirstItem)
                {
                    skipFirstItem = false;
                    continue;
                }

                Console.Write($"{o} ");
            }
        }

        #endregion

        #region PRINTLINE

        public static void PRINTLINE(object o)
            => Console.WriteLine($"{o}");

        public static void PRINTLN(object o)
            => Console.WriteLine($"{o}");


        public static void PRINTLINE(params object[] os)
            => PRINTLINE(os, false);

        public static void PRINTLINE(object[] os, bool skipFirstItem = false)
        {
            foreach (object o in os)
            {
                if (skipFirstItem)
                {
                    skipFirstItem = false;
                    continue;
                }

                Console.Write($"{o} ");
            }

            Console.WriteLine();
        }

        #endregion
    }
}