/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE617_Reachable_Assertion__length_13.cs
Label Definition File: CWE617_Reachable_Assertion.label.xml
Template File: point-flaw-13.tmpl.cs
*/
/*
* @description
* CWE: 617 Assertion is reachable
* Sinks: length
*    GoodSink: assert true, which will never trigger
*    BadSink : assert false, which will always trigger
* Flow Variant: 13 Control flow: if(IO.STATIC_READONLY_FIVE==5) and if(IO.STATIC_READONLY_FIVE!=5)
*
* */

using TestCaseSupport;
using System;

using System.Diagnostics;

namespace testcases.CWE617_Reachable_Assertion
{
class CWE617_Reachable_Assertion__length_13 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (IO.STATIC_READONLY_FIVE == 5)
        {
            /* FLAW: assertion is false */
            Trace.Assert("".Length > 0);
        }
    }
#endif //omitbad

}
}
