/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE546_Suspicious_Comment__BUG_03.cs
Label Definition File: CWE546_Suspicious_Comment.label.xml
Template File: point-flaw-03.tmpl.cs
*/
/*
* @description
* CWE: 546 Suspicious Comment
* Sinks: BUG
*    GoodSink: does not contain suspicious comment
*    BadSink : contains suspicious comment
* Flow Variant: 03 Control flow: if(5==5) and if(5!=5)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE546_Suspicious_Comment
{
class CWE546_Suspicious_Comment__BUG_03 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (5 == 5)
        {
            /* FLAW: This is the suspicious comment */
            /* BUG: There is a bug at this location...I'm not sure why! */
            IO.WriteLine("This a test of the emergency broadcast system");
        }
    }
#endif //omitbad

}
}
