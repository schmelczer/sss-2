/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE617_Reachable_Assertion__false_02.cs
Label Definition File: CWE617_Reachable_Assertion.label.xml
Template File: point-flaw-02.tmpl.cs
*/
/*
* @description
* CWE: 617 Assertion is reachable
* Sinks: false
*    GoodSink: assert true, which will never trigger
*    BadSink : assert false, which will always trigger
* Flow Variant: 02 Control flow: if(true) and if(false)
*
* */

using TestCaseSupport;
using System;

using System.Diagnostics;

namespace testcases.CWE617_Reachable_Assertion
{
class CWE617_Reachable_Assertion__false_02 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (true)
        {
            /* FLAW: this assertion can be reached, and will always trigger */
            Trace.Assert(false); /* INCIDENTAL: CWE 571 - expression is always true */
        }
    }
#endif //omitbad

}
}
