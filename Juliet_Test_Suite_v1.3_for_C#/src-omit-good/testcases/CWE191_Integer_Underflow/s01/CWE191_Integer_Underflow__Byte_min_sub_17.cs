/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__Byte_min_sub_17.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-17.tmpl.cs
*/
/*
* @description
* CWE: 191 Integer Underflow
* BadSource: min Set data to the min value for byte
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: sub
*    GoodSink: Ensure there will not be an underflow before subtracting 1 from data
*    BadSink : Subtract 1 from data, which can cause an Underflow
* Flow Variant: 17 Control flow: for loops
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__Byte_min_sub_17 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        byte data;
        /* We need to have one source outside of a for loop in order
         * to prevent the compiler from generating an error because
         * data is uninitialized
         */
        /* POTENTIAL FLAW: Use the minimum size of the data type */
        data = byte.MinValue;
        for (int j = 0; j < 1; j++)
        {
            /* POTENTIAL FLAW: if data == byte.MinValue, this will overflow */
            byte result = (byte)(data - 1);
            IO.WriteLine("result: " + result);
        }
    }
#endif //omitbad

}
}
