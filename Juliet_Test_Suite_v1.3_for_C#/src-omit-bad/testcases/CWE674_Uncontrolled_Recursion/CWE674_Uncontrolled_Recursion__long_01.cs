/*
 * @description Recursion not limited to a managed level
 *
 * */

using System;
using TestCaseSupport;

namespace testcases.CWE674_Uncontrolled_Recursion
{
    class CWE674_Uncontrolled_Recursion__long_01 : AbstractTestCase
    {
        private static readonly long RECURSION_LONG_MAX = 10;



#if (!OMITGOOD)
        private static void helperGood1(long level)
        {
            /* FIX: limit recursion to a sane level */
            if (level > RECURSION_LONG_MAX)
            {
                IO.WriteLine("ERROR IN RECURSION");
                return;
            }

            if (level == 0)
            {
                return;
            }
            
            helperGood1(level - 1);
        }

        private void Good1()
        {
            long longMax = long.MaxValue;

            helperGood1(longMax);
        }

        public override void Good()
        {
            Good1();
        }
#endif // OMITGOOD

}
}
