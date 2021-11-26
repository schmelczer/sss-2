/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE398_Code_Quality__semicolon_15.cs
Label Definition File: CWE398_Code_Quality.label.xml
Template File: point-flaw-15.tmpl.cs
*/
/*
* @description
* CWE: 398 One of the 7 Pernicious Kingdoms - Code Quality
* Sinks: semicolon
*    GoodSink: Removed statement that has no effect
*    BadSink : A statement that has no effect
* Flow Variant: 15 Control flow: switch(7)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE398_Code_Quality
{
class CWE398_Code_Quality__semicolon_15 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        switch (7)
        {
        case 7:
            ; /* FLAW: This semicolon is a statement that has no effect */
            IO.WriteLine("Hello from Bad()");
            break;
        default:
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
            break;
        }
    }
#endif //omitbad

}
}
