/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE398_Code_Quality__semicolon_03.cs
Label Definition File: CWE398_Code_Quality.label.xml
Template File: point-flaw-03.tmpl.cs
*/
/*
* @description
* CWE: 398 One of the 7 Pernicious Kingdoms - Code Quality
* Sinks: semicolon
*    GoodSink: Removed statement that has no effect
*    BadSink : A statement that has no effect
* Flow Variant: 03 Control flow: if(5==5) and if(5!=5)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE398_Code_Quality
{
class CWE398_Code_Quality__semicolon_03 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (5 == 5)
        {
            ; /* FLAW: This semicolon is a statement that has no effect */
            IO.WriteLine("Hello from Bad()");
        }
    }
#endif //omitbad

}
}
