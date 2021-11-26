/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE546_Suspicious_Comment__TODO_14.cs
Label Definition File: CWE546_Suspicious_Comment.label.xml
Template File: point-flaw-14.tmpl.cs
*/
/*
* @description
* CWE: 546 Suspicious Comment
* Sinks: TODO
*    GoodSink: does not contain suspicious comment
*    BadSink : does not contain a suspicious comment
* Flow Variant: 14 Control flow: if(IO.staticFive==5) and if(IO.staticFive!=5)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE546_Suspicious_Comment
{
class CWE546_Suspicious_Comment__TODO_14 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (IO.staticFive == 5)
        {
            /* FLAW: This is the suspicious comment */
            /* TODO: There is a bug at this location...I'm not sure why! */
            IO.WriteLine("This a test of the emergency broadcast system");
        }
    }
#endif //omitbad

}
}
