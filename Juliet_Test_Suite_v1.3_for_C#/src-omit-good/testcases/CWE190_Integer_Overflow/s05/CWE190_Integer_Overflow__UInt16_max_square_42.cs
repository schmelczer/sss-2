/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__UInt16_max_square_42.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-42.tmpl.cs
*/
/*
 * @description
 * CWE: 190 Integer Overflow
 * BadSource: max Set data to the max value for ushort
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: square
 *    GoodSink: Ensure there will not be an overflow before squaring data
 *    BadSink : Square data, which can lead to overflow
 * Flow Variant: 42 Data flow: data returned from one method to another in the same class
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__UInt16_max_square_42 : AbstractTestCase
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
        /* POTENTIAL FLAW: if (data*data) > ushort.MaxValue, this will overflow */
        ushort result = (ushort)(data * data);
        IO.WriteLine("result: " + result);
    }
#endif //omitbad

}
}
