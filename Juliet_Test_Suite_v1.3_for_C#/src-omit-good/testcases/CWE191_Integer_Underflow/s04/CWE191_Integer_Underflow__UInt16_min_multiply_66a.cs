/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__UInt16_min_multiply_66a.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-66a.tmpl.cs
*/
/*
 * @description
 * CWE: 191 Integer Underflow
 * BadSource: min Set data to the min value for ushort
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: multiply
 *    GoodSink: Ensure there will not be an underflow before multiplying data by 2
 *    BadSink : If data is negative, multiply by 2, which can cause an underflow
 * Flow Variant: 66 Data flow: data passed in an array from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__UInt16_min_multiply_66a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        ushort data;
        /* POTENTIAL FLAW: Use the minimum size of the data type */
        data = ushort.MinValue;
        ushort[] dataArray = new ushort[5];
        dataArray[2] = data;
        CWE191_Integer_Underflow__UInt16_min_multiply_66b.BadSink(dataArray  );
    }
#endif //omitbad

}
}
