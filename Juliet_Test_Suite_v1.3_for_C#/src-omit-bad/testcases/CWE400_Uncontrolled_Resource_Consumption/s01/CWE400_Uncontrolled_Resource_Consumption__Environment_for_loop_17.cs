/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE400_Uncontrolled_Resource_Consumption__Environment_for_loop_17.cs
Label Definition File: CWE400_Uncontrolled_Resource_Consumption.label.xml
Template File: sources-sinks-17.tmpl.cs
*/
/*
* @description
* CWE: 400 Uncontrolled Resource Consumption
* BadSource: Environment Read count from an environment variable
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: for_loop
*    GoodSink: Validate count before using it as the loop variant in a for loop
*    BadSink : Use count as the loop variant in a for loop
* Flow Variant: 17 Control flow: for loops
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE400_Uncontrolled_Resource_Consumption
{
class CWE400_Uncontrolled_Resource_Consumption__Environment_for_loop_17 : AbstractTestCase
{

#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink */
    private void GoodG2B()
    {
        int count;
        /* FIX: Use a hardcoded number that won't cause underflow, overflow, divide by zero, or loss-of-precision issues */
        count = 2;
        for (int j = 0; j < 1; j++)
        {
            int i = 0;
            /* POTENTIAL FLAW: For loop using count as the loop variant and no validation */
            for (i = 0; i < count; i++)
            {
                IO.WriteLine("Hello");
            }
        }
    }

    /* goodB2G() - use badsource and goodsink*/
    private void GoodB2G()
    {
        int count;
        count = int.MinValue; /* Initialize count */
        /* get environment variable ADD */
        /* POTENTIAL FLAW: Read count from an environment variable */
        {
            string stringNumber = Environment.GetEnvironmentVariable("ADD");
            if (stringNumber != null) // avoid NPD incidental warnings
            {
                try
                {
                    count = int.Parse(stringNumber.Trim());
                }
                catch (FormatException exceptNumberFormat)
                {
                    IO.Logger.Log(NLog.LogLevel.Warn, exceptNumberFormat, "Number format exception parsing count from string");
                }
            }
        }
        for (int k = 0; k < 1; k++)
        {
            int i = 0;
            /* FIX: Validate count before using it as the for loop variant */
            if (count > 0 && count <= 20)
            {
                for (i = 0; i < count; i++)
                {
                    IO.WriteLine("Hello");
                }
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
