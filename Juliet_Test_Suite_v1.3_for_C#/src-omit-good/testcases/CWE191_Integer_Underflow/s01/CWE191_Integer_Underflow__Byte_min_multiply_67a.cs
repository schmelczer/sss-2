/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__Byte_min_multiply_67a.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-67a.tmpl.cs
*/
/*
 * @description
 * CWE: 191 Integer Underflow
 * BadSource: min Set data to the min value for byte
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: multiply
 *    GoodSink: Ensure there will not be an underflow before multiplying data by 2
 *    BadSink : If data is negative, multiply by 2, which can cause an underflow
 * Flow Variant: 67 Data flow: data passed in a class from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__Byte_min_multiply_67a : AbstractTestCase
{

    public class Container
    {
        public byte containerOne;
    }
#if (!OMITBAD)
    public override void Bad()
    {
        byte data;
        /* POTENTIAL FLAW: Use the minimum size of the data type */
        data = byte.MinValue;
        Container dataContainer = new Container();
        dataContainer.containerOne = data;
        CWE191_Integer_Underflow__Byte_min_multiply_67b.BadSink(dataContainer  );
    }
#endif //omitbad

}
}
