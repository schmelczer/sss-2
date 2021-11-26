/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE398_Code_Quality__empty_else_11.cs
Label Definition File: CWE398_Code_Quality.label.xml
Template File: point-flaw-11.tmpl.cs
*/
/*
* @description
* CWE: 398 One of the 7 Pernicious Kingdoms - Code Quality
* Sinks: empty_else
*    GoodSink: Else statement contains code
*    BadSink : An empty else statement has no effect
* Flow Variant: 11 Control flow: if(IO.StaticReturnsTrue()) and if(IO.StaticReturnsFalse())
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE398_Code_Quality
{
class CWE398_Code_Quality__empty_else_11 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (IO.StaticReturnsTrue())
        {
            int x;
            x = (new Random()).Next();
            if (x == 0)
            {
                IO.WriteLine("Inside the else statement");
            }
            /* FLAW: An empty else statement has no effect */
            else
            {
            }
            IO.WriteLine("Hello from Bad()");
        }
    }
#endif //omitbad

}
}
