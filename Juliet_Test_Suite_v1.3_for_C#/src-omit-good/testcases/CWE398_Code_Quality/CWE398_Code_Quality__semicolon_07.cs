/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE398_Code_Quality__semicolon_07.cs
Label Definition File: CWE398_Code_Quality.label.xml
Template File: point-flaw-07.tmpl.cs
*/
/*
* @description
* CWE: 398 One of the 7 Pernicious Kingdoms - Code Quality
* Sinks: semicolon
*    GoodSink: Removed statement that has no effect
*    BadSink : A statement that has no effect
* Flow Variant: 07 Control flow: if(privateFive==5) and if(privateFive!=5)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE398_Code_Quality
{
class CWE398_Code_Quality__semicolon_07 : AbstractTestCase
{
    /* The variable below is not declared "readonly", but is never assigned
     * any other value so a tool should be able to identify that reads of
     * this will always give its initialized value.
     */
    private int privateFive = 5;
#if (!OMITBAD)
    public override void Bad()
    {
        if (privateFive == 5)
        {
            ; /* FLAW: This semicolon is a statement that has no effect */
            IO.WriteLine("Hello from Bad()");
        }
    }
#endif //omitbad

}
}
