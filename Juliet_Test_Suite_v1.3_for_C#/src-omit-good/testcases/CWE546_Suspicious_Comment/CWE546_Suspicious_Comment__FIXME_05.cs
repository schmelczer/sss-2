/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE546_Suspicious_Comment__FIXME_05.cs
Label Definition File: CWE546_Suspicious_Comment.label.xml
Template File: point-flaw-05.tmpl.cs
*/
/*
* @description
* CWE: 546 Suspicious Comment
* Sinks: FIXME
*    GoodSink: does not contain suspicious comment
*    BadSink : does not contain a suspicious comment
* Flow Variant: 05 Control flow: if(privateTrue) and if(privateFalse)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE546_Suspicious_Comment
{
class CWE546_Suspicious_Comment__FIXME_05 : AbstractTestCase
{
    /* The two variables below are not defined as "readonly", but are never
     * assigned any other value, so a tool should be able to identify that
     * reads of these will always return their initialized values.
     */
    private bool privateTrue = true;
    private bool privateFalse = false;
#if (!OMITBAD)
    public override void Bad()
    {
        if (privateTrue)
        {
            /* FLAW: This is the suspicious comment */
            /* FIXME: There is a bug at this location...I'm not sure why! */
            IO.WriteLine("This a test of the emergency broadcast system");
        }
    }
#endif //omitbad

}
}
