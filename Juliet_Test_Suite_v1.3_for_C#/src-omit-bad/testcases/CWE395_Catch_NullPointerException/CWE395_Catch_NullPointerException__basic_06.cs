/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE395_Catch_NullPointerException__basic_06.cs
Label Definition File: CWE395_Catch_NullPointerException__basic.label.xml
Template File: point-flaw-06.tmpl.cs
*/
/*
* @description
* CWE: 395 Use of NullPointerException Catch to Detect NULL Pointer Dereference
* Sinks:
*    GoodSink: Check for null before taking action
*    BadSink : Catch NullReferenceException to detect null
* Flow Variant: 06 Control flow: if(PRIVATE_CONST_FIVE==5) and if(PRIVATE_CONST_FIVE!=5)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE395_Catch_NullPointerException
{
class CWE395_Catch_NullPointerException__basic_06 : AbstractTestCase
{
    /* The variable below is declared "const", so a tool should be able
     * to identify that reads of this will always give its initialized
     * value.
     */
    private const int PRIVATE_CONST_FIVE = 5;

#if (!OMITGOOD)
    /* Good1() changes PRIVATE_CONST_FIVE==5 to PRIVATE_CONST_FIVE!=5 */
    private void Good1()
    {
        if (PRIVATE_CONST_FIVE != 5)
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
        }
        else
        {
            String catchingNull = null;
            if (new Random().Next(2) == 1)
            {
                catchingNull = "CWE395";
            }
            if (catchingNull != null) /* FIX: Check for null before calling equals() */
            {
                if (catchingNull.Equals("CWE395"))
                {
                    IO.WriteLine("catchingNull is CWE395");
                }
            }
            else
            {
                IO.WriteLine("catchingNull is null");
            }
        }
    }

    /* Good2() reverses the bodies in the if statement */
    private void Good2()
    {
        if (PRIVATE_CONST_FIVE == 5)
        {
            String catchingNull = null;
            if (new Random().Next(2) == 1)
            {
                catchingNull = "CWE395";
            }
            if (catchingNull != null) /* FIX: Check for null before calling equals() */
            {
                if (catchingNull.Equals("CWE395"))
                {
                    IO.WriteLine("catchingNull is CWE395");
                }
            }
            else
            {
                IO.WriteLine("catchingNull is null");
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
