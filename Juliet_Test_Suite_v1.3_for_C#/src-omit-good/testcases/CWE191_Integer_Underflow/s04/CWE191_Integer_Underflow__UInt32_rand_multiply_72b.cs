/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__UInt32_rand_multiply_72b.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-72b.tmpl.cs
*/
/*
 * @description
 * CWE: 191 Integer Underflow
 * BadSource: rand Set data to result of rand()
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: multiply
 *    GoodSink: Ensure there will not be an underflow before multiplying data by 2
 *    BadSink : If data is negative, multiply by 2, which can cause an underflow
 * Flow Variant: 72 Data flow: data passed in a Hashtable from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;
using System.Collections;

using System.Web;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__UInt32_rand_multiply_72b
{
#if (!OMITBAD)
    public static void BadSink(Hashtable dataHashtable )
    {
        uint data = (uint) dataHashtable[2];
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
