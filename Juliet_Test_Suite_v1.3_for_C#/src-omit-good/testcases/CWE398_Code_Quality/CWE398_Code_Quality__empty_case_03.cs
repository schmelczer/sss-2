/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE398_Code_Quality__empty_case_03.cs
Label Definition File: CWE398_Code_Quality.label.xml
Template File: point-flaw-03.tmpl.cs
*/
/*
* @description
* CWE: 398 One of the 7 Pernicious Kingdoms - Code Quality
* Sinks: empty_case
*    GoodSink: Case statement contains code
*    BadSink : An empty case statement has no effect
* Flow Variant: 03 Control flow: if(5==5) and if(5!=5)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE398_Code_Quality
{
class CWE398_Code_Quality__empty_case_03 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (5 == 5)
        {
            int x = (new Random()).Next();
            switch (x)
            {
                /* FLAW: An empty case statement has no effect */
            case 0:
                break;
            default:
                IO.WriteLine("Inside the default statement");
                break;
            }
            IO.WriteLine("Hello from Bad()");
        }
    }
#endif //omitbad

}
}