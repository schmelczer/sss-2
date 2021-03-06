/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__UInt64_min_sub_66a.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-66a.tmpl.cs
*/
/*
 * @description
 * CWE: 191 Integer Underflow
 * BadSource: min Set data to the min value for ulong
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: sub
 *    GoodSink: Ensure there will not be an underflow before subtracting 1 from data
 *    BadSink : Subtract 1 from data, which can cause an Underflow
 * Flow Variant: 66 Data flow: data passed in an array from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__UInt64_min_sub_66a : AbstractTestCase
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
        ulong data;
        /* FIX: Use a hardcoded number that won't cause underflow, overflow, divide by zero, or loss-of-precision issues */
        data = 2;
        ulong[] dataArray = new ulong[5];
        dataArray[2] = data;
        CWE191_Integer_Underflow__UInt64_min_sub_66b.GoodG2BSink(dataArray  );
    }

    /* goodB2G() - use badsource and goodsink */
    private static void GoodB2G()
    {
        ulong data;
        /* POTENTIAL FLAW: Use the minimum size of the data type */
        data = ulong.MinValue;
        ulong[] dataArray = new ulong[5];
        dataArray[2] = data;
        CWE191_Integer_Underflow__UInt64_min_sub_66b.GoodB2GSink(dataArray  );
    }
#endif //omitgood
}
}
