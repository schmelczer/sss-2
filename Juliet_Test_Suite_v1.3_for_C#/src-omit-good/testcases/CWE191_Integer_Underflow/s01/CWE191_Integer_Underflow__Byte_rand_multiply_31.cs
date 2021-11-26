/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__Byte_rand_multiply_31.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-31.tmpl.cs
*/
/*
 * @description
 * CWE: 191 Integer Underflow
 * BadSource: rand Set data to result of rand()
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: multiply
 *    GoodSink: Ensure there will not be an underflow before multiplying data by 2
 *    BadSink : If data is negative, multiply by 2, which can cause an underflow
 * Flow Variant: 31 Data flow: make a copy of data within the same method
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__Byte_rand_multiply_31 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        byte dataCopy;
        {
            byte data;
            /* POTENTIAL FLAW: Use a random value */
            data = (byte)(new Random().Next(byte.MinValue, byte.MaxValue));
            dataCopy = data;
        }
        {
            byte data = dataCopy;
            if(data < 0) /* ensure we won't have an overflow */
            {
                /* POTENTIAL FLAW: if (data * 2) < byte.MinValue, this will underflow */
                byte result = (byte)(data * 2);
                IO.WriteLine("result: " + result);
            }
        }
    }
#endif //omitbad

}
}
