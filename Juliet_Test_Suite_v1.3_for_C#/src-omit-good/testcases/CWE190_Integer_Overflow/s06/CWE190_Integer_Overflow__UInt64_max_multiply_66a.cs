/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__UInt64_max_multiply_66a.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-66a.tmpl.cs
*/
/*
 * @description
 * CWE: 190 Integer Overflow
 * BadSource: max Set data to the max value for ulong
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: multiply
 *    GoodSink: Ensure there will not be an overflow before multiplying data by 2
 *    BadSink : If data is positive, multiply by 2, which can cause an overflow
 * Flow Variant: 66 Data flow: data passed in an array from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__UInt64_max_multiply_66a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        ulong data;
        /* POTENTIAL FLAW: Use the maximum size of the data type */
        data = ulong.MaxValue;
        ulong[] dataArray = new ulong[5];
        dataArray[2] = data;
        CWE190_Integer_Overflow__UInt64_max_multiply_66b.BadSink(dataArray  );
    }
#endif //omitbad

}
}
