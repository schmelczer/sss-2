/*
 * @description Infinite loop - for() 
 *
 * */

using System;
using TestCaseSupport;

namespace testcases.CWE835_Infinite_Loop
{
    class CWE835_Infinite_Loop__for_empty_01 : AbstractTestCase
    {


#if (!OMITGOOD)
        private void Good1()
        {
            int i = 0;

            for (;;)
            {
                /* FIX: Add a break point for the loop if i = 10 */
                if (i == 10)
                {
                    break;
                }
                IO.WriteLine(i);
                i++;
            }
        }

        public override void Good()
        {
            Good1();
        }
#endif // OMITGOOD

}
}
