/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE398_Code_Quality__empty_for_07.cs
Label Definition File: CWE398_Code_Quality.label.xml
Template File: point-flaw-07.tmpl.cs
*/
/*
* @description
* CWE: 398 One of the 7 Pernicious Kingdoms - Code Quality
* Sinks: empty_for
*    GoodSink: For statement contains code
*    BadSink : An empty for statement has no effect
* Flow Variant: 07 Control flow: if(privateFive==5) and if(privateFive!=5)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE398_Code_Quality
{
class CWE398_Code_Quality__empty_for_07 : AbstractTestCase
{
    /* The variable below is not declared "readonly", but is never assigned
     * any other value so a tool should be able to identify that reads of
     * this will always give its initialized value.
     */
    private int privateFive = 5;

#if (!OMITGOOD)
    /* Good1() changes privateFive==5 to privateFive!=5 */
    private void Good1()
    {
        if (privateFive != 5)
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
        }
        else
        {
            /* FIX: Do not include an empty for statement */
            for (int i = 0; i < 10; i++)
            {
                IO.WriteLine("Inside the for statement");
            }
            IO.WriteLine("Hello from Good()");
        }
    }

    /* Good2() reverses the bodies in the if statement */
    private void Good2()
    {
        if (privateFive == 5)
        {
            /* FIX: Do not include an empty for statement */
            for (int i = 0; i < 10; i++)
            {
                IO.WriteLine("Inside the for statement");
            }
            IO.WriteLine("Hello from Good()");
        }
    }

    public override void Good()
    {
        Good1();
        Good2();
    }
#endif //omitgood
}
}
