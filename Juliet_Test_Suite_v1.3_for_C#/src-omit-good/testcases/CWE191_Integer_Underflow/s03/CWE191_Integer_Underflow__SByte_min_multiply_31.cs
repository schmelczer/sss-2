/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__SByte_min_multiply_31.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-31.tmpl.cs
*/
/*
 * @description
 * CWE: 191 Integer Underflow
 * BadSource: min Set data to the min value for sbyte
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: multiply
 *    GoodSink: Ensure there will not be an underflow before multiplying data by 2
 *    BadSink : If data is negative, multiply by 2, which can cause an underflow
 * Flow Variant: 31 Data flow: make a copy of data within the same method
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__SByte_min_multiply_31 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        sbyte dataCopy;
        {
            sbyte data;
            /* POTENTIAL FLAW: Use the minimum size of the data type */
            data = sbyte.MinValue;
            dataCopy = data;
        }
        {
            sbyte data = dataCopy;
            if(data < 0) /* ensure we won't have an overflow */
            {
                /* POTENTIAL FLAW: if (data * 2) < sbyte.MinValue, this will underflow */
                sbyte result = (sbyte)(data * 2);
                IO.WriteLine("result: " + result);
            }
        }
    }
#endif //omitbad

}
}
