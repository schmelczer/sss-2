/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__long_large_to_short_31.cs
Label Definition File: CWE197_Numeric_Truncation_Error__long.label.xml
Template File: sources-sink-31.tmpl.cs
*/
/*
 * @description
 * CWE: 197 Numeric Truncation Error
 * BadSource: large Set data to a number larger than int.MaxValue
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: to_short
 *    BadSink : Convert data to a short
 * Flow Variant: 31 Data flow: make a copy of data within the same method
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE197_Numeric_Truncation_Error
{

class CWE197_Numeric_Truncation_Error__long_large_to_short_31 : AbstractTestCase
{
#if (!OMITBAD)
    /* uses badsource and badsink */
    public override void Bad()
    {
        long dataCopy;
        {
            long data;
            /* FLAW: Use a number larger than int.MaxValue */
            data = int.MaxValue + 5L;
            dataCopy = data;
        }
        {
            long data = dataCopy;
            {
                /* POTENTIAL FLAW: Convert data to a short, possibly causing a truncation error */
                IO.WriteLine((short)data);
            }
        }
    }
#endif //omitbad

}
}
