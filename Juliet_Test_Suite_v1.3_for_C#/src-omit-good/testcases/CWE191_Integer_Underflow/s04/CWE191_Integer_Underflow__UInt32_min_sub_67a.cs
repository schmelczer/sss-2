/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__UInt32_min_sub_67a.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-67a.tmpl.cs
*/
/*
 * @description
 * CWE: 191 Integer Underflow
 * BadSource: min Set data to the min value for uint
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: sub
 *    GoodSink: Ensure there will not be an underflow before subtracting 1 from data
 *    BadSink : Subtract 1 from data, which can cause an Underflow
 * Flow Variant: 67 Data flow: data passed in a class from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__UInt32_min_sub_67a : AbstractTestCase
{

    public class Container
    {
        public uint containerOne;
    }
#if (!OMITBAD)
    public override void Bad()
    {
        uint data;
        /* POTENTIAL FLAW: Use the minimum size of the data type */
        data = uint.MinValue;
        Container dataContainer = new Container();
        dataContainer.containerOne = data;
        CWE191_Integer_Underflow__UInt32_min_sub_67b.BadSink(dataContainer  );
    }
#endif //omitbad

}
}
