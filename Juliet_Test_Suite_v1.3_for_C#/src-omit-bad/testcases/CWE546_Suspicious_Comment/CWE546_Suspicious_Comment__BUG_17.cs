/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE546_Suspicious_Comment__BUG_17.cs
Label Definition File: CWE546_Suspicious_Comment.label.xml
Template File: point-flaw-17.tmpl.cs
*/
/*
* @description
* CWE: 546 Suspicious Comment
* Sinks: BUG
*    GoodSink: does not contain suspicious comment
*    BadSink : contains suspicious comment
* Flow Variant: 17 Control flow: for loops
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE546_Suspicious_Comment
{
class CWE546_Suspicious_Comment__BUG_17 : AbstractTestCase
{

#if (!OMITGOOD)
    /* Good1() use the GoodSinkBody in the for statement */
    private void Good1()
    {
        for(int k = 0; k < 1; k++)
        {
            /* FIX: don't have those types of comments :) */
            IO.WriteLine("This a test of the emergency broadcast system");
        }
    }

    public override void Good()
    {
        Good1();
    }
#endif //omitgood
}
}
