/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE482_Comparing_Instead_of_Assigning__basic_09.cs
Label Definition File: CWE482_Comparing_Instead_of_Assigning__basic.label.xml
Template File: point-flaw-09.tmpl.cs
*/
/*
* @description
* CWE: 482 Comparing Instead of Assigning
* Sinks:
*    GoodSink: Assigning
*    BadSink : Comparing instead of assigning
* Flow Variant: 09 Control flow: if(IO.STATIC_READONLY_TRUE) and if(IO.STATIC_READONLY_FALSE)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE482_Comparing_Instead_of_Assigning
{
class CWE482_Comparing_Instead_of_Assigning__basic_09 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (IO.STATIC_READONLY_TRUE)
        {
            int zeroOrOne = (new Random()).Next(2);
            bool isZero = false;
            if ((isZero == (zeroOrOne == 0)) == true) /* FLAW: should be (isZero = (zeroOrOne == 0)) */
            {
                IO.WriteLine("zeroOrOne is 0");
            }
            IO.WriteLine("isZero is: " + isZero);
        }
    }
#endif //omitbad

}
}
