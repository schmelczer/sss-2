/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__double_random_to_float_01.cs
Label Definition File: CWE197_Numeric_Truncation_Error__double.label.xml
Template File: sources-sink-01.tmpl.cs
*/
/*
* @description
* CWE: 197 Numeric Truncation Error
* BadSource: random Set data to a random value
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* BadSink: to_float Convert data to a float
* Flow Variant: 01 Baseline
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE197_Numeric_Truncation_Error
{

class CWE197_Numeric_Truncation_Error__double_random_to_float_01 : AbstractTestCase
{
#if (!OMITBAD)
    /* uses badsource and badsink */
    public override void Bad()
    {
        double data;
        /* FLAW: Set data to a random value */
        data = IO.GetRandomDouble();
        {
            /* POTENTIAL FLAW: Convert data to a float, possibly causing a truncation error */
            IO.WriteLine((float)data);
        }
    }
#endif //omitbad

}
}