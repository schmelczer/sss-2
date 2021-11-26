/*
 * @description statement always evaluates to false
 * 
 * */

using System;
using TestCaseSupport;

namespace testcases.CWE570_Expression_Always_False
{
    class CWE570_Expression_Always_False__string_equals_01 : AbstractTestCase
    {
#if (!OMITBAD)
        public override void Bad()
        {
            string stringFalse = "false";
            /* FLAW: always evaluates to false */
            if (stringFalse.Equals("true"))
            {
                IO.WriteLine("never prints");
            }
        }
#endif // OMITBAD



}
}
