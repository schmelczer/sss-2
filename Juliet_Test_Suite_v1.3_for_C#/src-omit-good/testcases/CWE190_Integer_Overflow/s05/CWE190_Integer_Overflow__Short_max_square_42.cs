/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__Short_max_square_42.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-42.tmpl.cs
*/
/*
 * @description
 * CWE: 190 Integer Overflow
 * BadSource: max Set data to the max value for short
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
class CWE190_Integer_Overflow__Short_max_square_42 : AbstractTestCase
{
#if (!OMITBAD)
    private static short BadSource()
    {
        short data;
        /* POTENTIAL FLAW: Use the maximum size of the data type */
        data = short.MaxValue;
        return data;
    }

    public override void Bad()
    {
        short data = BadSource();
        /* POTENTIAL FLAW: if (data*data) > short.MaxValue, this will overflow */
        short result = (short)(data * data);
        IO.WriteLine("result: " + result);
    }
#endif //omitbad

}
}
