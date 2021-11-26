/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE398_Code_Quality__empty_while_16.cs
Label Definition File: CWE398_Code_Quality.label.xml
Template File: point-flaw-16.tmpl.cs
*/
/*
* @description
* CWE: 398 One of the 7 Pernicious Kingdoms - Code Quality
* Sinks: empty_while
*    GoodSink: While statement contains code
*    BadSink : An empty while statement has no effect
* Flow Variant: 16 Control flow: while(true)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE398_Code_Quality
{
class CWE398_Code_Quality__empty_while_16 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        while(true)
        {
            int i = 0;
            /* FLAW: An empty while statement has no effect */
            while(i++ < 10)
            {
            }
            IO.WriteLine("Hello from Bad()");
            break;
        }
    }
#endif //omitbad

}
}
