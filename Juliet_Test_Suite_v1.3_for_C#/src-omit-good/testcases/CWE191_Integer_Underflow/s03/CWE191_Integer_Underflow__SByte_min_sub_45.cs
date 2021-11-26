/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__SByte_min_sub_45.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-45.tmpl.cs
*/
/*
 * @description
 * CWE: 191 Integer Underflow
 * BadSource: min Set data to the min value for sbyte
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
class CWE191_Integer_Underflow__SByte_min_sub_45 : AbstractTestCase
{

    private sbyte dataBad;
    private sbyte dataGoodG2B;
    private sbyte dataGoodB2G;
#if (!OMITBAD)
    private void BadSink()
    {
        sbyte data = dataBad;
        /* POTENTIAL FLAW: if data == sbyte.MinValue, this will overflow */
        sbyte result = (sbyte)(data - 1);
        IO.WriteLine("result: " + result);
    }

    public override void Bad()
    {
        sbyte data;
        /* POTENTIAL FLAW: Use the minimum size of the data type */
        data = sbyte.MinValue;
        dataBad = data;
        BadSink();
    }
#endif //omitbad

}
}
