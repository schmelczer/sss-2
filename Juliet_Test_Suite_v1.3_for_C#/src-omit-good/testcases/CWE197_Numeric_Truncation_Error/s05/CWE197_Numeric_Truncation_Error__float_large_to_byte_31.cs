/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__float_large_to_byte_31.cs
Label Definition File: CWE197_Numeric_Truncation_Error__float.label.xml
Template File: sources-sink-31.tmpl.cs
*/
/*
 * @description
 * CWE: 197 Numeric Truncation Error
 * BadSource: large Set data to a number larger than long.MaxValue
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: to_byte
 *    BadSink : Convert data to a byte
 * Flow Variant: 31 Data flow: make a copy of data within the same method
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE197_Numeric_Truncation_Error
{

class CWE197_Numeric_Truncation_Error__float_large_to_byte_31 : AbstractTestCase
{
#if (!OMITBAD)
    /* uses badsource and badsink */
    public override void Bad()
    {
        float dataCopy;
        {
            float data;
            /* FLAW: Use a number larger than short.MaxValue */
            data = long.MaxValue + 5f;
            dataCopy = data;
        }
        {
            float data = dataCopy;
            {
                /* POTENTIAL FLAW: Convert data to a byte, possibly causing a truncation error */
                IO.WriteLine((byte)data);
            }
        }
    }
#endif //omitbad

}
}
