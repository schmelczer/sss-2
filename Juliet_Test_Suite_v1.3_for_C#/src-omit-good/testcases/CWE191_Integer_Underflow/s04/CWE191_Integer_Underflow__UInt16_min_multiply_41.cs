/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__UInt16_min_multiply_41.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-41.tmpl.cs
*/
/*
 * @description
 * CWE: 191 Integer Underflow
 * BadSource: min Set data to the min value for ushort
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: multiply
 *    GoodSink: Ensure there will not be an underflow before multiplying data by 2
 *    BadSink : If data is negative, multiply by 2, which can cause an underflow
 * Flow Variant: 41 Data flow: data passed as an argument from one method to another in the same class
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__UInt16_min_multiply_41 : AbstractTestCase
{
#if (!OMITBAD)
    private static void BadSink(ushort data )
    {
        if(data < 0) /* ensure we won't have an overflow */
        {
            /* POTENTIAL FLAW: if (data * 2) < ushort.MinValue, this will underflow */
            ushort result = (ushort)(data * 2);
            IO.WriteLine("result: " + result);
        }
    }

    public override void Bad()
    {
        ushort data;
        /* POTENTIAL FLAW: Use the minimum size of the data type */
        data = ushort.MinValue;
        BadSink(data  );
    }
#endif //omitbad

}
}