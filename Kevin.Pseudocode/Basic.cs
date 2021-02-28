using System;

// ReSharper disable InconsistentNaming

namespace Kevin.Pseudocode
{
    public class Basic
    {
        public static object NULL => null;
        
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

        public static void SWAP(ref object A, ref object B)
        {
            object C = A;
            A = B;
            B = C;
        }

        public static void IF(Func<bool> judgement, Action ifRight, Action ifElse = null)
            => IF(judgement.Invoke(), ifRight, ifElse);

        public static void IF(bool judgement, Action ifRight, Action ifElse = null)
        {
            if (judgement)
                ifRight.Invoke();
            else
                ifElse?.Invoke();
        }
    }
}