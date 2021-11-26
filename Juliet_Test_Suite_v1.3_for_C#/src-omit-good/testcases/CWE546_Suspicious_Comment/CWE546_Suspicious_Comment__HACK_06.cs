/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE546_Suspicious_Comment__HACK_06.cs
Label Definition File: CWE546_Suspicious_Comment.label.xml
Template File: point-flaw-06.tmpl.cs
*/
/*
* @description
* CWE: 546 Suspicious Comment
* Sinks: HACK
*    GoodSink: does not contain suspicious comment
*    BadSink : contains suspicious comment
* Flow Variant: 06 Control flow: if(PRIVATE_CONST_FIVE==5) and if(PRIVATE_CONST_FIVE!=5)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE546_Suspicious_Comment
{
class CWE546_Suspicious_Comment__HACK_06 : AbstractTestCase
{
    /* The variable below is declared "const", so a tool should be able
     * to identify that reads of this will always give its initialized
     * value.
     */
    private const int PRIVATE_CONST_FIVE = 5;
#if (!OMITBAD)
    public override void Bad()
    {
        if (PRIVATE_CONST_FIVE == 5)
        {
            /* FLAW: This is the suspicious comment */
            /* HACK: There is a bug at this location...I'm not sure why! */
            IO.WriteLine("This a test of the emergency broadcast system");
        }
    }
#endif //omitbad

}
}
