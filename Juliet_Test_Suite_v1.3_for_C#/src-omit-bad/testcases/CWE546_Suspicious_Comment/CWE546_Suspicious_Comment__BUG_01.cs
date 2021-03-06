/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE546_Suspicious_Comment__BUG_01.cs
Label Definition File: CWE546_Suspicious_Comment.label.xml
Template File: point-flaw-01.tmpl.cs
*/
/*
* @description
* CWE: 546 Suspicious Comment
* Sinks: BUG
*    GoodSink: does not contain suspicious comment
*    BadSink : contains suspicious comment
* Flow Variant: 01 Baseline
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE546_Suspicious_Comment
{
class CWE546_Suspicious_Comment__BUG_01 : AbstractTestCase
{

#if (!OMITGOOD)
    public override void Good()
    {
        Good1();
    }

    private void Good1()
    {
        /* FIX: don't have those types of comments :) */
        IO.WriteLine("This a test of the emergency broadcast system");
    }
#endif //omitgood
}
}
