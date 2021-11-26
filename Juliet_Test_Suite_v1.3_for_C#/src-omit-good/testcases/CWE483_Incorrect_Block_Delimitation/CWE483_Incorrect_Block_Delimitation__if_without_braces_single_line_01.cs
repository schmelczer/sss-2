/*
 * @description Incorrect Block Delimitation
 *
 * */

using System;
using TestCaseSupport;

namespace testcases.CWE483_Incorrect_Block_Delimitation
{
    class CWE483_Incorrect_Block_Delimitation__if_without_braces_single_line_01 : AbstractTestCase
    {
#if (!OMITBAD)
        public override void Bad()
        {
            int x, y;

            x = (new Random()).Next(3);
            y = 0;

            /* FLAW: forgot to put these two statements within braces
             * (on the same line) */
            if (x == 0) IO.WriteLine("x == 0"); y = 1;

            if (y == 1)
            {
                IO.WriteLine("x was 0");
            }
        }
#endif // OMITBAD

}
}
