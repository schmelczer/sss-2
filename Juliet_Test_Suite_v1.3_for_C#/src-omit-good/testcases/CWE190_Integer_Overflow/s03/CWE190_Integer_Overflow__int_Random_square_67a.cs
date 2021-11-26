/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__int_Random_square_67a.cs
Label Definition File: CWE190_Integer_Overflow__int.label.xml
Template File: sources-sinks-67a.tmpl.cs
*/
/*
 * @description
 * CWE: 190 Integer Overflow
 * BadSource: Random Set data to a random value
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
class CWE190_Integer_Overflow__int_Random_square_67a : AbstractTestCase
{

    public class Container
    {
        public int containerOne;
    }
#if (!OMITBAD)
    public override void Bad()
    {
        int data;
        /* POTENTIAL FLAW: Set data to a random value */
        data = (new Random()).Next();
        Container dataContainer = new Container();
        dataContainer.containerOne = data;
        CWE190_Integer_Overflow__int_Random_square_67b.BadSink(dataContainer  );
    }
#endif //omitbad

}
}
