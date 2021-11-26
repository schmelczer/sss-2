/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__Short_min_multiply_54a.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-54a.tmpl.cs
*/
/*
 * @description
 * CWE: 191 Integer Underflow
 * BadSource: min Set data to the min value for short
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: multiply
 *    GoodSink: Ensure there will not be an underflow before multiplying data by 2
 *    BadSink : If data is negative, multiply by 2, which can cause an underflow
 * Flow Variant: 54 Data flow: data passed as an argument from one method through three others to a fifth; all five functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__Short_min_multiply_54a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        short data;
        /* POTENTIAL FLAW: Use the minimum size of the data type */
        data = short.MinValue;
        CWE191_Integer_Underflow__Short_min_multiply_54b.BadSink(data );
    }
#endif //omitbad

}
}
