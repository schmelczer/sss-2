/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE617_Reachable_Assertion__false_15.cs
Label Definition File: CWE617_Reachable_Assertion.label.xml
Template File: point-flaw-15.tmpl.cs
*/
/*
* @description
* CWE: 617 Assertion is reachable
* Sinks: false
*    GoodSink: assert true, which will never trigger
*    BadSink : assert false, which will always trigger
* Flow Variant: 15 Control flow: switch(7)
*
* */

using TestCaseSupport;
using System;

using System.Diagnostics;

namespace testcases.CWE617_Reachable_Assertion
{
class CWE617_Reachable_Assertion__false_15 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        switch (7)
        {
        case 7:
            /* FLAW: this assertion can be reached, and will always trigger */
            Trace.Assert(false); /* INCIDENTAL: CWE 571 - expression is always true */
            break;
        default:
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
            break;
        }
    }
#endif //omitbad

}
}
