/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE369_Divide_by_Zero__int_zero_modulo_17.cs
Label Definition File: CWE369_Divide_by_Zero__int.label.xml
Template File: sources-sinks-17.tmpl.cs
*/
/*
* @description
* CWE: 369 Divide by zero
* BadSource: zero Set data to a hardcoded value of zero
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: modulo
*    GoodSink: Check for zero before modulo
*    BadSink : Modulo by a value that may be zero
* Flow Variant: 17 Control flow: for loops
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE369_Divide_by_Zero
{
class CWE369_Divide_by_Zero__int_zero_modulo_17 : AbstractTestCase
{

#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink */
    private void GoodG2B()
    {
        int data;
        /* FIX: Use a hardcoded number that won't cause underflow, overflow, divide by zero, or loss-of-precision issues */
        data = 2;
        for (int j = 0; j < 1; j++)
        {
            /* POTENTIAL FLAW: Zero modulus will cause an issue.  An integer division will
            result in an exception.  */
            IO.WriteLine("100%" + data + " = " + (100 % data) + "\n");
        }
    }

    /* goodB2G() - use badsource and goodsink*/
    private void GoodB2G()
    {
        int data;
        data = 0; /* POTENTIAL FLAW: data is set to zero */
        for (int k = 0; k < 1; k++)
        {
            /* FIX: test for a zero modulus */
            if (data != 0)
            {
                IO.WriteLine("100%" + data + " = " + (100 % data) + "\n");
            }
            else
            {
                IO.WriteLine("This would result in a modulo by zero");
            }
        }
    }

    public override void Good()
    {
        GoodG2B();
        GoodB2G();
    }
#endif //omitgood
}
}
