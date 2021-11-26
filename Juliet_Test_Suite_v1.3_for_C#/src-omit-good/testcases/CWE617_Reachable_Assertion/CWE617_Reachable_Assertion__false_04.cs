/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE617_Reachable_Assertion__false_04.cs
Label Definition File: CWE617_Reachable_Assertion.label.xml
Template File: point-flaw-04.tmpl.cs
*/
/*
* @description
* CWE: 617 Assertion is reachable
* Sinks: false
*    GoodSink: assert true, which will never trigger
*    BadSink : assert false, which will always trigger
* Flow Variant: 04 Control flow: if(PRIVATE_CONST_TRUE) and if(PRIVATE_CONST_FALSE)
*
* */

using TestCaseSupport;
using System;

using System.Diagnostics;

namespace testcases.CWE617_Reachable_Assertion
{
class CWE617_Reachable_Assertion__false_04 : AbstractTestCase
{
    /* The two variables below are declared "const", so a tool should
     * be able to identify that reads of these will always return their
     * initialized values.
     */
    private const bool PRIVATE_CONST_TRUE = true;
    private const bool PRIVATE_CONST_FALSE = false;
#if (!OMITBAD)
    public override void Bad()
    {
        if (PRIVATE_CONST_TRUE)
        {
            /* FLAW: this assertion can be reached, and will always trigger */
            Trace.Assert(false); /* INCIDENTAL: CWE 571 - expression is always true */
        }
    }
#endif //omitbad

}
}
