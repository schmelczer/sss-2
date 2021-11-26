/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE546_Suspicious_Comment__HACK_16.cs
Label Definition File: CWE546_Suspicious_Comment.label.xml
Template File: point-flaw-16.tmpl.cs
*/
/*
* @description
* CWE: 546 Suspicious Comment
* Sinks: HACK
*    GoodSink: does not contain suspicious comment
*    BadSink : contains suspicious comment
* Flow Variant: 16 Control flow: while(true)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE546_Suspicious_Comment
{
class CWE546_Suspicious_Comment__HACK_16 : AbstractTestCase
{

#if (!OMITGOOD)
    /* Good1() change the conditions on the while statements */
    private void Good1()
    {
        while(true)
        {
            /* FIX: don't have those types of comments :) */
            IO.WriteLine("This a test of the emergency broadcast system");
            break;
        }
    }

    public override void Good()
    {
        Good1();
    }
#endif //omitgood
}
}