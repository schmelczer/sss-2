/*
 * @description uncontrolled recursion due to missing base or exit case
 *
 * */

using System;
using TestCaseSupport;
using System.Security.Cryptography;

namespace testcases.CWE674_Uncontrolled_Recursion
{
    class CWE674_Uncontrolled_Recursion__missing_base_01 : AbstractTestCase
    {


#if (!OMITGOOD)
        private static long helperGood1(long level)
        {
            /* FIX: add a case for termination */
            if (level < 0)
            {
                return 0;
            }

            long longSum = level + helperGood1(level - 1);
            return longSum;
        }

        private void Good1()
        {
            long longRandom = (new Random()).Next(100);

            IO.WriteLine(helperGood1(longRandom));
        }

        public override void Good()
        {
            Good1();
        }
#endif // OMITGOOD

}
}
