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

        public static void FOR_LOOP_IN_RANGE(int from, int to, Func<bool> action)
        {
            for (int i = from; i < to; ++i)
            {
                if (action.Invoke())
                    break;
            }
        }

        public static void FOR_LOOP_IN_RANGE(int from, int to, Func<bool>[] actions)
        {
            for (int i = from; i < to; ++i)
            {
                foreach (var action in actions)
                {
                    if (action.Invoke())
                        return;
                }
            }
        }

        public static void FOR_LOOP_IN_RANGE(int from, int to, Func<int, bool> action)
        {
            for (int i = from; i < to; ++i)
            {
                if (action.Invoke(i))
                    break;
            }
        }

        public static void FOR_LOOP_IN_RANGE(int from, int to, Func<int, bool>[] actions)
        {
            for (int i = from; i < to; ++i)
            {
                foreach (var action in actions)
                {
                    if (action.Invoke(i))
                        return;
                }
            }
        }

        public static void FOR_LOOP_IN_RANGE(int from, int to, Func<int> action)
        {
            for (int i = from; i < to; ++i)
            {
                if (action.Invoke() != 0)
                    break;
            }
        }

        public static void FOR_LOOP_IN_RANGE(int from, int to, Func<int>[] actions)
        {
            for (int i = from; i < to; ++i)
            {
                foreach (var action in actions)
                {
                    if (action.Invoke() != 0)
                        return;
                }
            }
        }

        public static void FOR_LOOP_IN_RANGE(int from, int to, Func<int, int> action)
        {
            for (int i = from; i < to; ++i)
            {
                if (action.Invoke(i) != 0)
                    break;
            }
        }

        public static void FOR_LOOP_IN_RANGE(int from, int to, Func<int, int>[] actions)
        {
            for (int i = from; i < to; ++i)
            {
                foreach (var action in actions)
                {
                    if (action.Invoke(i) != 0)
                        return;
                }
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
            while (judgement.Invoke())
            {
            }
        }

        public static void WHILE(Func<bool> judgement, Action act)
        {
            while (judgement.Invoke())
            {
                act.Invoke();
            }
        }

        #endregion

        public static void LOOP(Func<bool> action)
        {
            while (true)
            {
                if (action.Invoke())
                {
                    break;
                }
            }
        }
        
        public static void LOOP(Func<int> action)
        {
            while (true)
            {
                if (action.Invoke() != 0)
                {
                    break;
                }
            }
        }
        
        public static void LOOP(Func<bool>[] actions)
        {
            while (true)
            {
                foreach (var action in actions)
                {
                    if (action.Invoke())
                    {
                        return;
                    }
                }
            }
        }
        
        public static void LOOP(Func<int>[] actions)
        {
            while (true)
            {
                foreach (var action in actions)
                {
                    if (action.Invoke() != 0)
                    {
                        return;
                    }
                }
            }
        }
        
        
        #region Compare

        public static bool EQ(object A, object B)
            => A == B;

        public static bool NE(object A, object B)
            => A != B;

        public static bool GE(object A, object B)
            => A.TO_DOUBLE() >= B.TO_DOUBLE();

        public static bool GEQ(object A, object B)
            => A.TO_DOUBLE() >= B.TO_DOUBLE();

        public static bool LE(object A, object B)
            => A.TO_DOUBLE() <= B.TO_DOUBLE();

        public static bool LEQ(object A, object B)
            => A.TO_DOUBLE() <= B.TO_DOUBLE();

        public static bool GREATER(object A, object B)
            => A.TO_DOUBLE() > B.TO_DOUBLE();

        public static bool LESS(object A, object B)
            => A.TO_DOUBLE() < B.TO_DOUBLE();

        #endregion
    }
}