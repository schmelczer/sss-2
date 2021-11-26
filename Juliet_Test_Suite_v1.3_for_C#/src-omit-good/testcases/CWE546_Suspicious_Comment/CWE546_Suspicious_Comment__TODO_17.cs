/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE546_Suspicious_Comment__TODO_17.cs
Label Definition File: CWE546_Suspicious_Comment.label.xml
Template File: point-flaw-17.tmpl.cs
*/
/*
* @description
* CWE: 546 Suspicious Comment
* Sinks: TODO
*    GoodSink: does not contain suspicious comment
*    BadSink : does not contain a suspicious comment
* Flow Variant: 17 Control flow: for loops
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE546_Suspicious_Comment
{
class CWE546_Suspicious_Comment__TODO_17 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        for(int j = 0; j < 1; j++)
        {
            /* FLAW: This is the suspicious comment */
            /* TODO: There is a bug at this location...I'm not sure why! */
            IO.WriteLine("This a test of the emergency broadcast system");
        }
    }
#endif //omitbad

}
}
