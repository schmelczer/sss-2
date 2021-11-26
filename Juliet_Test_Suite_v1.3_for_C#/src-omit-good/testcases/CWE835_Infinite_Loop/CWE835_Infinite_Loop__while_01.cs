/*
 * @description Infinite loop - while()
 *
 * */

using System;
using TestCaseSupport;

namespace testcases.CWE835_Infinite_Loop
{
    class CWE835_Infinite_Loop__while_01 : AbstractTestCase
    {
#if (!OMITBAD)
        public override void Bad()
        {
            int i = 0;

            /* FLAW: Infinite Loop - while() with no break point */
            while (i >= 0)
            {
                IO.WriteLine(i);
                i = (i + 1) % 256;
            }
        }
#endif // OMITBAD



}
}
