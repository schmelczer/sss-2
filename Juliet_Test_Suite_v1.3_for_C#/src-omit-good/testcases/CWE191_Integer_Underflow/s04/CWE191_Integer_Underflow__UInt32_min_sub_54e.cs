/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__UInt32_min_sub_54e.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-54e.tmpl.cs
*/
/*
 * @description
 * CWE: 191 Integer Underflow
 * BadSource: min Set data to the min value for uint
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: sub
 *    GoodSink: Ensure there will not be an underflow before subtracting 1 from data
 *    BadSink : Subtract 1 from data, which can cause an Underflow
 * Flow Variant: 54 Data flow: data passed as an argument from one method through three others to a fifth; all five functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__UInt32_min_sub_54e
{
#if (!OMITBAD)
    public static void BadSink(uint data )
    {
        /* POTENTIAL FLAW: if data == uint.MinValue, this will overflow */
        uint result = (uint)(data - 1);
        IO.WriteLine("result: " + result);
    }
#endif


}
}
