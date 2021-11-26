/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__float_large_to_short_17.cs
Label Definition File: CWE197_Numeric_Truncation_Error__float.label.xml
Template File: sources-sink-17.tmpl.cs
*/
/*
* @description
* CWE: 197 Numeric Truncation Error
* BadSource: large Set data to a number larger than long.MaxValue
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* BadSink: to_short Convert data to a short
* Flow Variant: 17 Control flow: for loops
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE197_Numeric_Truncation_Error
{

class CWE197_Numeric_Truncation_Error__float_large_to_short_17 : AbstractTestCase
{
#if (!OMITBAD)
    /* uses badsource and badsink */
    public override void Bad()
    {
        float data;
        /* FLAW: Use a number larger than short.MaxValue */
        data = long.MaxValue + 5f;
        for (int i = 0; i < 1; i++)
        {
            {
                /* POTENTIAL FLAW: Convert data to a short, possibly causing a truncation error */
                IO.WriteLine((short)data);
            }
        }
    }
#endif //omitbad

}
}
