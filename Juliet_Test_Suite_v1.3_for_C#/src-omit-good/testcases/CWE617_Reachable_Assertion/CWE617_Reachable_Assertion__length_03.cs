/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE617_Reachable_Assertion__length_03.cs
Label Definition File: CWE617_Reachable_Assertion.label.xml
Template File: point-flaw-03.tmpl.cs
*/
/*
* @description
* CWE: 617 Assertion is reachable
* Sinks: length
*    GoodSink: assert true, which will never trigger
*    BadSink : assert false, which will always trigger
* Flow Variant: 03 Control flow: if(5==5) and if(5!=5)
*
* */

using TestCaseSupport;
using System;

using System.Diagnostics;

namespace testcases.CWE617_Reachable_Assertion
{
class CWE617_Reachable_Assertion__length_03 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (5 == 5)
        {
            /* FLAW: assertion is false */
            Trace.Assert("".Length > 0);
        }
    }
#endif //omitbad

}
}
