/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE193_Off_by_One_Error__for_09.cs
Label Definition File: CWE193_Off_by_One_Error.label.xml
Template File: point-flaw-09.tmpl.cs
*/
/*
* @description
* CWE: 193 An array index is 1 off from the max array index
* Sinks: for
*    GoodSink: restrict max index value
*    BadSink : access array index outside array max
* Flow Variant: 09 Control flow: if(IO.STATIC_READONLY_TRUE) and if(IO.STATIC_READONLY_FALSE)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE193_Off_by_One_Error
{
class CWE193_Off_by_One_Error__for_09 : AbstractTestCase
{

#if (!OMITGOOD)
    /* Good1() changes IO.STATIC_READONLY_TRUE to IO.STATIC_READONLY_FALSE */
    private void Good1()
    {
        if (IO.STATIC_READONLY_FALSE)
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
        }
        else
        {
            int[] intArray = new int[10];
            /* FIX: Use < to ensure no out of bounds access */
            for (int i = 0; i < intArray.Length; i++)
            {
                IO.WriteLine("intArray[" + i + "] = " + (intArray[i] = i));
            }
        }
    }

    /* Good2() reverses the bodies in the if statement */
    private void Good2()
    {
        if (IO.STATIC_READONLY_TRUE)
        {
            int[] intArray = new int[10];
            /* FIX: Use < to ensure no out of bounds access */
            for (int i = 0; i < intArray.Length; i++)
            {
                IO.WriteLine("intArray[" + i + "] = " + (intArray[i] = i));
            }
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