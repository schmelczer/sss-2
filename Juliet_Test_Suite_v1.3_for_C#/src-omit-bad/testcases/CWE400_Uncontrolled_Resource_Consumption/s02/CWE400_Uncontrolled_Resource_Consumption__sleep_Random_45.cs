/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE400_Uncontrolled_Resource_Consumption__sleep_Random_45.cs
Label Definition File: CWE400_Uncontrolled_Resource_Consumption__sleep.label.xml
Template File: sources-sinks-45.tmpl.cs
*/
/*
 * @description
 * CWE: 400 Uncontrolled Resource Consumption
 * BadSource: Random Set count to a random value
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks:
 *    GoodSink: Validate count before using it as a parameter in sleep function
 *    BadSink : Use count as the parameter for sleep withhout checking it's size first
 * Flow Variant: 45 Data flow: data passed as a private class member variable from one function to another in the same class
 *
 * */

using TestCaseSupport;
using System;

using System.Threading;

namespace testcases.CWE400_Uncontrolled_Resource_Consumption
{
class CWE400_Uncontrolled_Resource_Consumption__sleep_Random_45 : AbstractTestCase
{

    private int countBad;
    private int countGoodG2B;
    private int countGoodB2G;

#if (!OMITGOOD)
    public override void Good()
    {
        GoodG2B();
        GoodB2G();
    }

    private void GoodG2BSink()
    {
        int count = countGoodG2B;
        /* POTENTIAL FLAW: Use count as the input to Thread.Sleep() */
        Thread.Sleep(count);
    }

    /* goodG2B() - use goodsource and badsink */
    private void GoodG2B()
    {
        int count;
        /* FIX: Use a hardcoded number that won't cause underflow, overflow, divide by zero, or loss-of-precision issues */
        count = 2;
        countGoodG2B = count;
        GoodG2BSink();
    }

    private void GoodB2GSink()
    {
        int count = countGoodB2G;
        /* FIX: Validate count before using it in a call to Thread.Sleep() */
        if (count > 0 && count <= 2000)
        {
            Thread.Sleep(count);
        }
    }

    /* goodB2G() - use badsource and goodsink */
    private void GoodB2G()
    {
        int count;
        /* POTENTIAL FLAW: Set count to a random value */
        count = (new Random()).Next();
        countGoodB2G = count;
        GoodB2GSink();
    }
#endif //omitgood
}
}