/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__UInt16_rand_sub_72b.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-72b.tmpl.cs
*/
/*
 * @description
 * CWE: 191 Integer Underflow
 * BadSource: rand Set data to result of rand()
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: sub
 *    GoodSink: Ensure there will not be an underflow before subtracting 1 from data
 *    BadSink : Subtract 1 from data, which can cause an Underflow
 * Flow Variant: 72 Data flow: data passed in a Hashtable from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;
using System.Collections;

using System.Web;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__UInt16_rand_sub_72b
{
#if (!OMITBAD)
    public static void BadSink(Hashtable dataHashtable )
    {
        ushort data = (ushort) dataHashtable[2];
        /* POTENTIAL FLAW: if data == ushort.MinValue, this will overflow */
        ushort result = (ushort)(data - 1);
        IO.WriteLine("result: " + result);
    }
#endif


}
}
