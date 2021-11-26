/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__UInt32_max_multiply_52a.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-52a.tmpl.cs
*/
/*
 * @description
 * CWE: 190 Integer Overflow
 * BadSource: max Set data to the max value for uint
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: multiply
 *    GoodSink: Ensure there will not be an overflow before multiplying data by 2
 *    BadSink : If data is positive, multiply by 2, which can cause an overflow
 * Flow Variant: 52 Data flow: data passed as an argument from one method to another to another in three different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__UInt32_max_multiply_52a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        uint data;
        /* POTENTIAL FLAW: Use the maximum size of the data type */
        data = uint.MaxValue;
        CWE190_Integer_Overflow__UInt32_max_multiply_52b.BadSink(data );
    }
#endif //omitbad

}
}
