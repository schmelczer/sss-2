/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE546_Suspicious_Comment__FIXME_02.cs
Label Definition File: CWE546_Suspicious_Comment.label.xml
Template File: point-flaw-02.tmpl.cs
*/
/*
* @description
* CWE: 546 Suspicious Comment
* Sinks: FIXME
*    GoodSink: does not contain suspicious comment
*    BadSink : does not contain a suspicious comment
* Flow Variant: 02 Control flow: if(true) and if(false)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE546_Suspicious_Comment
{
class CWE546_Suspicious_Comment__FIXME_02 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (true)
        {
            /* FLAW: This is the suspicious comment */
            /* FIXME: There is a bug at this location...I'm not sure why! */
            IO.WriteLine("This a test of the emergency broadcast system");
        }
    }
#endif //omitbad

}
}
