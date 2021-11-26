/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__UInt64_max_square_41.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-41.tmpl.cs
*/
/*
 * @description
 * CWE: 190 Integer Overflow
 * BadSource: max Set data to the max value for ulong
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: square
 *    GoodSink: Ensure there will not be an overflow before squaring data
 *    BadSink : Square data, which can lead to overflow
 * Flow Variant: 41 Data flow: data passed as an argument from one method to another in the same class
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__UInt64_max_square_41 : AbstractTestCase
{
#if (!OMITBAD)
    private static void BadSink(ulong data )
    {
        /* POTENTIAL FLAW: if (data*data) > ulong.MaxValue, this will overflow */
        ulong result = (ulong)(data * data);
        IO.WriteLine("result: " + result);
    }

    public override void Bad()
    {
        ulong data;
        /* POTENTIAL FLAW: Use the maximum size of the data type */
        data = ulong.MaxValue;
        BadSink(data  );
    }
#endif //omitbad

}
}
