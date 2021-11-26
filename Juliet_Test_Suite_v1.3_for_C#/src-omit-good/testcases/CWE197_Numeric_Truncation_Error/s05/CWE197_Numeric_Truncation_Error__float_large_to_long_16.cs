/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__float_large_to_long_16.cs
Label Definition File: CWE197_Numeric_Truncation_Error__float.label.xml
Template File: sources-sink-16.tmpl.cs
*/
/*
* @description
* CWE: 197 Numeric Truncation Error
* BadSource: large Set data to a number larger than long.MaxValue
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* BadSink: to_long Convert data to a long
* Flow Variant: 16 Control flow: while(true)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE197_Numeric_Truncation_Error
{

class CWE197_Numeric_Truncation_Error__float_large_to_long_16 : AbstractTestCase
{
#if (!OMITBAD)
    /* uses badsource and badsink */
    public override void Bad()
    {
        float data;
        while (true)
        {
            /* FLAW: Use a number larger than short.MaxValue */
            data = long.MaxValue + 5f;
            break;
        }
        {
            /* POTENTIAL FLAW: Convert data to a long, possibly causing a truncation error */
            IO.WriteLine((long)data);
        }
    }
#endif //omitbad

}
}
