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
#if (!OMITBAD)
        private static long helperBad(long level)
        {
            /* FLAW: Missing base case */
            long longSum = level + helperBad(level - 1);
            return longSum;
        }

        public override void Bad()
        {
            long longRandom = (new Random()).Next(100);

            IO.WriteLine(helperBad(longRandom));
        }
#endif // OMITBAD



}
}
