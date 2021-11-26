/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__double_random_to_float_51a.cs
Label Definition File: CWE197_Numeric_Truncation_Error__double.label.xml
Template File: sources-sink-51a.tmpl.cs
*/
/*
 * @description
 * CWE: 197 Numeric Truncation Error
 * BadSource: random Set data to a random value
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * BadSink: to_float Convert data to a float
 * Flow Variant: 51 Data flow: data passed as an argument from one function to another in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE197_Numeric_Truncation_Error
{

class CWE197_Numeric_Truncation_Error__double_random_to_float_51a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        double data;
        /* FLAW: Set data to a random value */
        data = IO.GetRandomDouble();
        CWE197_Numeric_Truncation_Error__double_random_to_float_51b.BadSink(data  );
    }
#endif //omitbad

}
}
