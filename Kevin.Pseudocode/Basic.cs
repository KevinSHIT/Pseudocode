using System;

// ReSharper disable InconsistentNaming

namespace Kevin.Pseudocode
{
    public class Basic
    {
        public static object NULL => null;

        public static bool TRUE => true;
        public static bool FALSE => false;

        #region FOR

        public static void FOR_LOOP_IN_RANGE(int from, int to, Action<int> action)
        {
            for (int i = from; i < to; ++i)
            {
                action.Invoke(i);
            }
        }

        public static void FOR_LOOP_IN_RANGE(int from, int to, Action action)
        {
            for (int i = from; i < to; ++i)
            {
                action.Invoke();
            }
        }

        #endregion

        public static void SWAP(ref object A, ref object B)
        {
            object C = A;
            A = B;
            B = C;
        }

        #region IF

        public static void IF(Func<bool> judgement, Action ifRight, Action ifElse = null)
            => IF(judgement.Invoke(), ifRight, ifElse);

        public static void IF(bool judgement, Action ifRight, Action ifElse = null)
        {
            if (judgement)
                ifRight.Invoke();
            else
                ifElse?.Invoke();
        }

        #endregion

        #region WHILE

        public static void WHILE(Func<bool> judgement)
        {
            while (true)
            {
                if (judgement.Invoke())
                    break;
            }
        }
        
        public static void WHILE(Func<bool> judgement, Action act)
        {
            while (true)
            {
                if (judgement.Invoke())
                    break;
                act.Invoke();
            }
        }
        
        public static void WHILE(bool judgement, Action act)
        {
            while (true)
            {
                if (judgement)
                    break;
                act.Invoke();
            }
        }

        #endregion
    }
}