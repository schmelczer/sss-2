/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE476_NULL_Pointer_Dereference__binary_if_15.cs
Label Definition File: CWE476_NULL_Pointer_Dereference.pointflaw.label.xml
Template File: point-flaw-15.tmpl.cs
*/
/*
* @description
* CWE: 476 NULL Pointer Dereference
* Sinks: binary_if
*    GoodSink: Do not check for null after the object has been dereferenced
*    BadSink : Check for null after an object has already been dereferenced
* Flow Variant: 15 Control flow: switch(7)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE476_NULL_Pointer_Dereference
{
class CWE476_NULL_Pointer_Dereference__binary_if_15 : AbstractTestCase
{

#if (!OMITGOOD)
    /* Good1() change the switch to switch(8) */
    private void Good1()
    {
        switch (8)
        {
        case 7:
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
            break;
        default:
        {
            string myString = null;
            /* FIX: Use && in the if statement so that if the left side of the expression fails then
             * the right side will not be evaluated */
            if ((myString != null) && (myString.Length > 0))
            {
                IO.WriteLine("The string length is greater than 0");
            }
        }
        break;
        }
    }

    /* Good2() reverses the blocks in the switch  */
    private void Good2()
    {
        switch (7)
        {
        case 7:
        {
            string myString = null;
            /* FIX: Use && in the if statement so that if the left side of the expression fails then
             * the right side will not be evaluated */
            if ((myString != null) && (myString.Length > 0))
            {
                IO.WriteLine("The string length is greater than 0");
            }
        }
        break;
        default:
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
            break;
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
