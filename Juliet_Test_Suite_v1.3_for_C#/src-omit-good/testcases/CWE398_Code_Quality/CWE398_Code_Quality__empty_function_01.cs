/*
 * @description call an empty function
 * 
 * */

using System;
using TestCaseSupport;

namespace testcases.CWE398_Code_Quality
{
    class CWE398_Code_Quality__empty_function_01 : AbstractTestCase
    {
#if (!OMITBAD)
        private void helperBad()
        {
            /* FLAW: Function does nothing */
        }

        public override void Bad()
        {
            helperBad();
        }
#endif // OMITBAD


}
}
