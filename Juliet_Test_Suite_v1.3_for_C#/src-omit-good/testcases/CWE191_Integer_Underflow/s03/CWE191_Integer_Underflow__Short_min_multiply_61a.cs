/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__Short_min_multiply_61a.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-61a.tmpl.cs
*/
/*
 * @description
 * CWE: 191 Integer Underflow
 * BadSource: min Set data to the min value for short
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: multiply
 *    GoodSink: Ensure there will not be an underflow before multiplying data by 2
 *    BadSink : If data is negative, multiply by 2, which can cause an underflow
 * Flow Variant: 61 Data flow: data returned from one method to another in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__Short_min_multiply_61a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        short data = CWE191_Integer_Underflow__Short_min_multiply_61b.BadSource();
        if(data < 0) /* ensure we won't have an overflow */
        {
            /* POTENTIAL FLAW: if (data * 2) < short.MinValue, this will underflow */
            short result = (short)(data * 2);
            IO.WriteLine("result: " + result);
        }
    }
#endif //omitbad

}
}
