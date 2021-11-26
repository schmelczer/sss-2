/*
 * @description Infinite loop - for()
 *
 * */

using System;
using TestCaseSupport;

namespace testcases.CWE835_Infinite_Loop
{
    class CWE835_Infinite_Loop__for_01 : AbstractTestCase
    {
#if (!OMITBAD)
        public override void Bad()
        {
            int i = 0;

            /* FLAW: Infinite Loop - for() with no break point */
            for (i = 0; i >= 0; i = (i + 1) % 256)
            {
                IO.WriteLine(i);
            }
        }
#endif // OMITBAD



}
}
