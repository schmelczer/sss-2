/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__Byte_min_multiply_45.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-45.tmpl.cs
*/
/*
 * @description
 * CWE: 191 Integer Underflow
 * BadSource: min Set data to the min value for byte
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: multiply
 *    GoodSink: Ensure there will not be an underflow before multiplying data by 2
 *    BadSink : If data is negative, multiply by 2, which can cause an underflow
 * Flow Variant: 45 Data flow: data passed as a private class member variable from one function to another in the same class
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__Byte_min_multiply_45 : AbstractTestCase
{

    private byte dataBad;
    private byte dataGoodG2B;
    private byte dataGoodB2G;
#if (!OMITBAD)
    private void BadSink()
    {
        byte data = dataBad;
        if(data < 0) /* ensure we won't have an overflow */
        {
            /* POTENTIAL FLAW: if (data * 2) < byte.MinValue, this will underflow */
            byte result = (byte)(data * 2);
            IO.WriteLine("result: " + result);
        }
    }

    public override void Bad()
    {
        byte data;
        /* POTENTIAL FLAW: Use the minimum size of the data type */
        data = byte.MinValue;
        dataBad = data;
        BadSink();
    }
#endif //omitbad

}
}
