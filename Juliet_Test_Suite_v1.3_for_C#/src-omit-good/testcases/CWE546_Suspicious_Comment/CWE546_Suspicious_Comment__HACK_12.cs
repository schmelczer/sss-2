/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE546_Suspicious_Comment__HACK_12.cs
Label Definition File: CWE546_Suspicious_Comment.label.xml
Template File: point-flaw-12.tmpl.cs
*/
/*
* @description
* CWE: 546 Suspicious Comment
* Sinks: HACK
*    GoodSink: does not contain suspicious comment
*    BadSink : contains suspicious comment
* Flow Variant: 12 Control flow: if(IO.StaticReturnsTrueOrFalse())
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE546_Suspicious_Comment
{
class CWE546_Suspicious_Comment__HACK_12 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (IO.StaticReturnsTrueOrFalse())
        {
            /* FLAW: This is the suspicious comment */
            /* HACK: There is a bug at this location...I'm not sure why! */
            IO.WriteLine("This a test of the emergency broadcast system");
        }
        else
        {
            /* FIX: don't have those types of comments :) */
            IO.WriteLine("This a test of the emergency broadcast system");
        }
    }
#endif //omitbad

}
}