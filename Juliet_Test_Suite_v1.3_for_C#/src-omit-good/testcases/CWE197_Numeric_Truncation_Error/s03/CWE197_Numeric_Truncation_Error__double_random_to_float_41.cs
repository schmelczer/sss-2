/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__double_random_to_float_41.cs
Label Definition File: CWE197_Numeric_Truncation_Error__double.label.xml
Template File: sources-sink-41.tmpl.cs
*/
/*
 * @description
 * CWE: 197 Numeric Truncation Error
 * BadSource: random Set data to a random value
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * BadSink: to_float Convert data to a float
 * Flow Variant: 41 Data flow: data passed as an argument from one method to another in the same class
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE197_Numeric_Truncation_Error
{

class CWE197_Numeric_Truncation_Error__double_random_to_float_41 : AbstractTestCase
{
#if (!OMITBAD)
    private static void BadSink(double data )
    {
        {
            /* POTENTIAL FLAW: Convert data to a float, possibly causing a truncation error */
            IO.WriteLine((float)data);
        }
    }

    public override void Bad()
    {
        double data;
        /* FLAW: Set data to a random value */
        data = IO.GetRandomDouble();
        BadSink(data  );
    }
#endif //omitbad

}
}
