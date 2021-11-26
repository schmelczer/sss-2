/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__UInt16_max_multiply_42.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-42.tmpl.cs
*/
/*
 * @description
 * CWE: 190 Integer Overflow
 * BadSource: max Set data to the max value for ushort
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: multiply
 *    GoodSink: Ensure there will not be an overflow before multiplying data by 2
 *    BadSink : If data is positive, multiply by 2, which can cause an overflow
 * Flow Variant: 42 Data flow: data returned from one method to another in the same class
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__UInt16_max_multiply_42 : AbstractTestCase
{
#if (!OMITBAD)
    private static ushort BadSource()
    {
        ushort data;
        /* POTENTIAL FLAW: Use the maximum size of the data type */
        data = ushort.MaxValue;
        return data;
    }

    public override void Bad()
    {
        ushort data = BadSource();
        if(data > 0) /* ensure we won't have an underflow */
        {
            /* POTENTIAL FLAW: if (data*2) > ushort.MaxValue, this will overflow */
            ushort result = (ushort)(data * 2);
            IO.WriteLine("result: " + result);
        }
    }
#endif //omitbad

}
}
