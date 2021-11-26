/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__float_random_to_int_51a.cs
Label Definition File: CWE197_Numeric_Truncation_Error__float.label.xml
Template File: sources-sink-51a.tmpl.cs
*/
/*
 * @description
 * CWE: 197 Numeric Truncation Error
 * BadSource: random Set data to a random value
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * BadSink: to_int Convert data to a int
 * Flow Variant: 51 Data flow: data passed as an argument from one function to another in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE197_Numeric_Truncation_Error
{

class CWE197_Numeric_Truncation_Error__float_random_to_int_51a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        float data;
        /* FLAW: Set data to a random value */
        data = (float)(float.MaxValue * 2.0 * (new Random().NextDouble()-0.5));
        CWE197_Numeric_Truncation_Error__float_random_to_int_51b.BadSink(data  );
    }
#endif //omitbad
#if (!OMITGOOD)
    public override void Good()
    {
        GoodG2B();
    }

    /* goodG2B() - use goodsource and badsink */
    private void GoodG2B()
    {
        float data;
        /* FIX: Use a hardcoded number that won't cause underflow, overflow, divide by zero, or loss-of-precision issues */
        data = 2;
        CWE197_Numeric_Truncation_Error__float_random_to_int_51b.GoodG2BSink(data  );
    }
#endif //omitgood
}
}
