/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__SByte_max_square_67a.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-67a.tmpl.cs
*/
/*
 * @description
 * CWE: 190 Integer Overflow
 * BadSource: max Set data to the max value for sbyte
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: square
 *    GoodSink: Ensure there will not be an overflow before squaring data
 *    BadSink : Square data, which can lead to overflow
 * Flow Variant: 67 Data flow: data passed in a class from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__SByte_max_square_67a : AbstractTestCase
{

    public class Container
    {
        public sbyte containerOne;
    }
#if (!OMITBAD)
    public override void Bad()
    {
        sbyte data;
        /* POTENTIAL FLAW: Use the maximum size of the data type */
        data = sbyte.MaxValue;
        Container dataContainer = new Container();
        dataContainer.containerOne = data;
        CWE190_Integer_Overflow__SByte_max_square_67b.BadSink(dataContainer  );
    }
#endif //omitbad

}
}
