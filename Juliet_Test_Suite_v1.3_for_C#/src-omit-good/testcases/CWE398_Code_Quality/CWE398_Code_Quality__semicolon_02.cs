/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE398_Code_Quality__semicolon_02.cs
Label Definition File: CWE398_Code_Quality.label.xml
Template File: point-flaw-02.tmpl.cs
*/
/*
* @description
* CWE: 398 One of the 7 Pernicious Kingdoms - Code Quality
* Sinks: semicolon
*    GoodSink: Removed statement that has no effect
*    BadSink : A statement that has no effect
* Flow Variant: 02 Control flow: if(true) and if(false)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE398_Code_Quality
{
class CWE398_Code_Quality__semicolon_02 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (true)
        {
            ; /* FLAW: This semicolon is a statement that has no effect */
            IO.WriteLine("Hello from Bad()");
        }
    }
#endif //omitbad

}
}
