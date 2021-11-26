/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__UInt64_min_multiply_51a.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-51a.tmpl.cs
*/
/*
 * @description
 * CWE: 191 Integer Underflow
 * BadSource: min Set data to the min value for ulong
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: multiply
 *    GoodSink: Ensure there will not be an underflow before multiplying data by 2
 *    BadSink : If data is negative, multiply by 2, which can cause an underflow
 * Flow Variant: 51 Data flow: data passed as an argument from one function to another in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__UInt64_min_multiply_51a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        ulong data;
        /* POTENTIAL FLAW: Use the minimum size of the data type */
        data = ulong.MinValue;
        CWE191_Integer_Underflow__UInt64_min_multiply_51b.BadSink(data  );
    }
#endif //omitbad

}
}
