/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__UInt32_max_square_31.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-31.tmpl.cs
*/
/*
 * @description
 * CWE: 190 Integer Overflow
 * BadSource: max Set data to the max value for uint
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: square
 *    GoodSink: Ensure there will not be an overflow before squaring data
 *    BadSink : Square data, which can lead to overflow
 * Flow Variant: 31 Data flow: make a copy of data within the same method
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__UInt32_max_square_31 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        uint dataCopy;
        {
            uint data;
            /* POTENTIAL FLAW: Use the maximum size of the data type */
            data = uint.MaxValue;
            dataCopy = data;
        }
        {
            uint data = dataCopy;
            /* POTENTIAL FLAW: if (data*data) > uint.MaxValue, this will overflow */
            uint result = (uint)(data * data);
            IO.WriteLine("result: " + result);
        }
    }
#endif //omitbad

}
}
