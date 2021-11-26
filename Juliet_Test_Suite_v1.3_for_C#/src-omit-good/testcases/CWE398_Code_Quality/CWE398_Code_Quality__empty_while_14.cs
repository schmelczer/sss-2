/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE398_Code_Quality__empty_while_14.cs
Label Definition File: CWE398_Code_Quality.label.xml
Template File: point-flaw-14.tmpl.cs
*/
/*
* @description
* CWE: 398 One of the 7 Pernicious Kingdoms - Code Quality
* Sinks: empty_while
*    GoodSink: While statement contains code
*    BadSink : An empty while statement has no effect
* Flow Variant: 14 Control flow: if(IO.staticFive==5) and if(IO.staticFive!=5)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE398_Code_Quality
{
class CWE398_Code_Quality__empty_while_14 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (IO.staticFive == 5)
        {
            int i = 0;
            /* FLAW: An empty while statement has no effect */
            while(i++ < 10)
            {
            }
            IO.WriteLine("Hello from Bad()");
        }
    }
#endif //omitbad

}
}
