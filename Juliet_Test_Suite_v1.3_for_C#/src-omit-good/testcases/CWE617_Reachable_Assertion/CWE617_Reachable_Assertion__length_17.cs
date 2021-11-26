/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE617_Reachable_Assertion__length_17.cs
Label Definition File: CWE617_Reachable_Assertion.label.xml
Template File: point-flaw-17.tmpl.cs
*/
/*
* @description
* CWE: 617 Assertion is reachable
* Sinks: length
*    GoodSink: assert true, which will never trigger
*    BadSink : assert false, which will always trigger
* Flow Variant: 17 Control flow: for loops
*
* */

using TestCaseSupport;
using System;

using System.Diagnostics;

namespace testcases.CWE617_Reachable_Assertion
{
class CWE617_Reachable_Assertion__length_17 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        for(int j = 0; j < 1; j++)
        {
            /* FLAW: assertion is false */
            Trace.Assert("".Length > 0);
        }
    }
#endif //omitbad

}
}
