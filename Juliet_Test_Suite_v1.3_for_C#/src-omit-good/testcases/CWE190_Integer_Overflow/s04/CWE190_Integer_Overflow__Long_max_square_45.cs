/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__Long_max_square_45.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-45.tmpl.cs
*/
/*
 * @description
 * CWE: 190 Integer Overflow
 * BadSource: max Set data to the max value for long
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: square
 *    GoodSink: Ensure there will not be an overflow before squaring data
 *    BadSink : Square data, which can lead to overflow
 * Flow Variant: 45 Data flow: data passed as a private class member variable from one function to another in the same class
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__Long_max_square_45 : AbstractTestCase
{

    private long dataBad;
    private long dataGoodG2B;
    private long dataGoodB2G;
#if (!OMITBAD)
    private void BadSink()
    {
        long data = dataBad;
        /* POTENTIAL FLAW: if (data*data) > long.MaxValue, this will overflow */
        long result = (long)(data * data);
        IO.WriteLine("result: " + result);
    }

    public override void Bad()
    {
        long data;
        /* POTENTIAL FLAW: Use the maximum size of the data type */
        data = long.MaxValue;
        dataBad = data;
        BadSink();
    }
#endif //omitbad

}
}
