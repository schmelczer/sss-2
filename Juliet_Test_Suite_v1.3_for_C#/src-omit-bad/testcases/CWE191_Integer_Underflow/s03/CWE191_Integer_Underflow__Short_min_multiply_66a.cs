/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__Short_min_multiply_66a.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-66a.tmpl.cs
*/
/*
 * @description
 * CWE: 191 Integer Underflow
 * BadSource: min Set data to the min value for short
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: multiply
 *    GoodSink: Ensure there will not be an underflow before multiplying data by 2
 *    BadSink : If data is negative, multiply by 2, which can cause an underflow
 * Flow Variant: 66 Data flow: data passed in an array from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__Short_min_multiply_66a : AbstractTestCase
{

#if (!OMITGOOD)
    public override void Good()
    {
        GoodG2B();
        GoodB2G();
    }

    /* goodG2B() - use goodsource and badsink */
    private static void GoodG2B()
    {
        short data;
        /* FIX: Use a hardcoded number that won't cause underflow, overflow, divide by zero, or loss-of-precision issues */
        data = 2;
        short[] dataArray = new short[5];
        dataArray[2] = data;
        CWE191_Integer_Underflow__Short_min_multiply_66b.GoodG2BSink(dataArray  );
    }

    /* goodB2G() - use badsource and goodsink */
    private static void GoodB2G()
    {
        short data;
        /* POTENTIAL FLAW: Use the minimum size of the data type */
        data = short.MinValue;
        short[] dataArray = new short[5];
        dataArray[2] = data;
        CWE191_Integer_Underflow__Short_min_multiply_66b.GoodB2GSink(dataArray  );
    }
#endif //omitgood
}
}
