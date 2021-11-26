/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__Byte_min_sub_42.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-42.tmpl.cs
*/
/*
 * @description
 * CWE: 191 Integer Underflow
 * BadSource: min Set data to the min value for byte
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: sub
 *    GoodSink: Ensure there will not be an underflow before subtracting 1 from data
 *    BadSink : Subtract 1 from data, which can cause an Underflow
 * Flow Variant: 42 Data flow: data returned from one method to another in the same class
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__Byte_min_sub_42 : AbstractTestCase
{
#if (!OMITBAD)
    private static byte BadSource()
    {
        byte data;
        /* POTENTIAL FLAW: Use the minimum size of the data type */
        data = byte.MinValue;
        return data;
    }

    public override void Bad()
    {
        byte data = BadSource();
        /* POTENTIAL FLAW: if data == byte.MinValue, this will overflow */
        byte result = (byte)(data - 1);
        IO.WriteLine("result: " + result);
    }
#endif //omitbad

}
}
