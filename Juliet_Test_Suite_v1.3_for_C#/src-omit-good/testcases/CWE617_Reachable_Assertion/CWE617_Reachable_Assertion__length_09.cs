/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE617_Reachable_Assertion__length_09.cs
Label Definition File: CWE617_Reachable_Assertion.label.xml
Template File: point-flaw-09.tmpl.cs
*/
/*
* @description
* CWE: 617 Assertion is reachable
* Sinks: length
*    GoodSink: assert true, which will never trigger
*    BadSink : assert false, which will always trigger
* Flow Variant: 09 Control flow: if(IO.STATIC_READONLY_TRUE) and if(IO.STATIC_READONLY_FALSE)
*
* */

using TestCaseSupport;
using System;

using System.Diagnostics;

namespace testcases.CWE617_Reachable_Assertion
{
class CWE617_Reachable_Assertion__length_09 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (IO.STATIC_READONLY_TRUE)
        {
            /* FLAW: assertion is false */
            Trace.Assert("".Length > 0);
        }
    }
#endif //omitbad

}
}
