/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE398_Code_Quality__empty_if_09.cs
Label Definition File: CWE398_Code_Quality.label.xml
Template File: point-flaw-09.tmpl.cs
*/
/*
* @description
* CWE: 398 One of the 7 Pernicious Kingdoms - Code Quality
* Sinks: empty_if
*    GoodSink: If statement contains code
*    BadSink : An empty if statement has no effect
* Flow Variant: 09 Control flow: if(IO.STATIC_READONLY_TRUE) and if(IO.STATIC_READONLY_FALSE)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE398_Code_Quality
{
class CWE398_Code_Quality__empty_if_09 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (IO.STATIC_READONLY_TRUE)
        {
            int x;
            x = (new Random()).Next();
            /* FLAW: An empty if statement has no effect */
            if (x == 0)
            {
            }
            else
            {
                IO.WriteLine("Inside the else statement");
            }
            IO.WriteLine("Hello from Bad()");
        }
    }
#endif //omitbad

}
}
