/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__Long_min_sub_45.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-45.tmpl.cs
*/
/*
 * @description
 * CWE: 191 Integer Underflow
 * BadSource: min Set data to the min value for long
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: sub
 *    GoodSink: Ensure there will not be an underflow before subtracting 1 from data
 *    BadSink : Subtract 1 from data, which can cause an Underflow
 * Flow Variant: 45 Data flow: data passed as a private class member variable from one function to another in the same class
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__Long_min_sub_45 : AbstractTestCase
{

    private long dataBad;
    private long dataGoodG2B;
    private long dataGoodB2G;
#if (!OMITBAD)
    private void BadSink()
    {
        long data = dataBad;
        /* POTENTIAL FLAW: if data == long.MinValue, this will overflow */
        long result = (long)(data - 1);
        IO.WriteLine("result: " + result);
    }

    public override void Bad()
    {
        long data;
        /* POTENTIAL FLAW: Use the minimum size of the data type */
        data = long.MinValue;
        dataBad = data;
        BadSink();
    }
#endif //omitbad

}
}
