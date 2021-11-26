/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__Byte_max_add_45.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-45.tmpl.cs
*/
/*
 * @description
 * CWE: 190 Integer Overflow
 * BadSource: max Set data to the max value for byte
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: add
 *    GoodSink: Ensure there will not be an overflow before adding 1 to data
 *    BadSink : Add 1 to data, which can cause an overflow
 * Flow Variant: 45 Data flow: data passed as a private class member variable from one function to another in the same class
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__Byte_max_add_45 : AbstractTestCase
{

    private byte dataBad;
    private byte dataGoodG2B;
    private byte dataGoodB2G;
#if (!OMITBAD)
    private void BadSink()
    {
        byte data = dataBad;
        /* POTENTIAL FLAW: if data == byte.MaxValue, this will overflow */
        byte result = (byte)(data + 1);
        IO.WriteLine("result: " + result);
    }

    public override void Bad()
    {
        byte data;
        /* POTENTIAL FLAW: Use the maximum size of the data type */
        data = byte.MaxValue;
        dataBad = data;
        BadSink();
    }
#endif //omitbad

}
}
