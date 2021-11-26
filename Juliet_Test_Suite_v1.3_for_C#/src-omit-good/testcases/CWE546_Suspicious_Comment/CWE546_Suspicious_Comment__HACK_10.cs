/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE546_Suspicious_Comment__HACK_10.cs
Label Definition File: CWE546_Suspicious_Comment.label.xml
Template File: point-flaw-10.tmpl.cs
*/
/*
* @description
* CWE: 546 Suspicious Comment
* Sinks: HACK
*    GoodSink: does not contain suspicious comment
*    BadSink : contains suspicious comment
* Flow Variant: 10 Control flow: if(IO.staticTrue) and if(IO.staticFalse)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE546_Suspicious_Comment
{
class CWE546_Suspicious_Comment__HACK_10 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (IO.staticTrue)
        {
            /* FLAW: This is the suspicious comment */
            /* HACK: There is a bug at this location...I'm not sure why! */
            IO.WriteLine("This a test of the emergency broadcast system");
        }
    }
#endif //omitbad

}
}
