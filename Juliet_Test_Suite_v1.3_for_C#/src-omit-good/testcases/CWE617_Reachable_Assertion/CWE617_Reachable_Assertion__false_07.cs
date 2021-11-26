/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE617_Reachable_Assertion__false_07.cs
Label Definition File: CWE617_Reachable_Assertion.label.xml
Template File: point-flaw-07.tmpl.cs
*/
/*
* @description
* CWE: 617 Assertion is reachable
* Sinks: false
*    GoodSink: assert true, which will never trigger
*    BadSink : assert false, which will always trigger
* Flow Variant: 07 Control flow: if(privateFive==5) and if(privateFive!=5)
*
* */

using TestCaseSupport;
using System;

using System.Diagnostics;

namespace testcases.CWE617_Reachable_Assertion
{
class CWE617_Reachable_Assertion__false_07 : AbstractTestCase
{
    /* The variable below is not declared "readonly", but is never assigned
     * any other value so a tool should be able to identify that reads of
     * this will always give its initialized value.
     */
    private int privateFive = 5;
#if (!OMITBAD)
    public override void Bad()
    {
        if (privateFive == 5)
        {
            /* FLAW: this assertion can be reached, and will always trigger */
            Trace.Assert(false); /* INCIDENTAL: CWE 571 - expression is always true */
        }
    }
#endif //omitbad

}
}
