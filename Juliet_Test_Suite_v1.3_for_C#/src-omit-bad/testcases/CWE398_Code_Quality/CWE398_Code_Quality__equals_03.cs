/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE398_Code_Quality__equals_03.cs
Label Definition File: CWE398_Code_Quality.label.xml
Template File: point-flaw-03.tmpl.cs
*/
/*
* @description
* CWE: 398 One of the 7 Pernicious Kingdoms - Code Quality
* Sinks: equals
*    GoodSink: Set a variable equal to another variable
*    BadSink : Setting a variable equal to itself has no effect
* Flow Variant: 03 Control flow: if(5==5) and if(5!=5)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE398_Code_Quality
{
class CWE398_Code_Quality__equals_03 : AbstractTestCase
{

#if (!OMITGOOD)
    /* Good1() changes 5==5 to 5!=5 */
    private void Good1()
    {
        if (5 != 5)
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
        }
        else
        {
            int intOne = 1, intFive = 5;
            IO.WriteLine(intOne);
            /* FIX: Assign intFive to intOne */
            intOne = intFive;
            IO.WriteLine(intOne);
        }
    }

    /* Good2() reverses the bodies in the if statement */
    private void Good2()
    {
        if (5 == 5)
        {
            int intOne = 1, intFive = 5;
            IO.WriteLine(intOne);
            /* FIX: Assign intFive to intOne */
            intOne = intFive;
            IO.WriteLine(intOne);
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
