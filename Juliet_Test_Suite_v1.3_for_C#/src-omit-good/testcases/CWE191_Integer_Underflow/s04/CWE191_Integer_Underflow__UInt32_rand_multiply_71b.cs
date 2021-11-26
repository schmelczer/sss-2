/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__UInt32_rand_multiply_71b.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-71b.tmpl.cs
*/
/*
 * @description
 * CWE: 191 Integer Underflow
 * BadSource: rand Set data to result of rand()
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: multiply
 *    GoodSink: Ensure there will not be an underflow before multiplying data by 2
 *    BadSink : If data is negative, multiply by 2, which can cause an underflow
 * Flow Variant: 71 Data flow: data passed as an Object reference argument from one method to another in different classes in the same package
 *
 * */

using TestCaseSupport;

using System;

using System.Web;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__UInt32_rand_multiply_71b
{
#if (!OMITBAD)
    public static void BadSink(Object dataObject )
    {
        uint data = (uint)dataObject;
        if(data < 0) /* ensure we won't have an overflow */
        {
            /* POTENTIAL FLAW: if (data * 2) < uint.MinValue, this will underflow */
            uint result = (uint)(data * 2);
            IO.WriteLine("result: " + result);
        }
    }
#endif


}
}
