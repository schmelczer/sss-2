/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE482_Comparing_Instead_of_Assigning__basic_13.cs
Label Definition File: CWE482_Comparing_Instead_of_Assigning__basic.label.xml
Template File: point-flaw-13.tmpl.cs
*/
/*
* @description
* CWE: 482 Comparing Instead of Assigning
* Sinks:
*    GoodSink: Assigning
*    BadSink : Comparing instead of assigning
* Flow Variant: 13 Control flow: if(IO.STATIC_READONLY_FIVE==5) and if(IO.STATIC_READONLY_FIVE!=5)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE482_Comparing_Instead_of_Assigning
{
class CWE482_Comparing_Instead_of_Assigning__basic_13 : AbstractTestCase
{

#if (!OMITGOOD)
    /* Good1() changes IO.STATIC_READONLY_FIVE==5 to IO.STATIC_READONLY_FIVE!=5 */
    private void Good1()
    {
        if (IO.STATIC_READONLY_FIVE != 5)
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
        }
        else
        {
            int zeroOrOne = (new Random()).Next(2);
            bool isZero = false;
            if ((isZero = (zeroOrOne == 0)) == true) /* FIX: correct assignment */
            {
                IO.WriteLine("zeroOrOne is 0");
            }
            IO.WriteLine("isZero is: " + isZero);
        }
    }

    /* Good2() reverses the bodies in the if statement */
    private void Good2()
    {
        if (IO.STATIC_READONLY_FIVE == 5)
        {
            int zeroOrOne = (new Random()).Next(2);
            bool isZero = false;
            if ((isZero = (zeroOrOne == 0)) == true) /* FIX: correct assignment */
            {
                IO.WriteLine("zeroOrOne is 0");
            }
            IO.WriteLine("isZero is: " + isZero);
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
