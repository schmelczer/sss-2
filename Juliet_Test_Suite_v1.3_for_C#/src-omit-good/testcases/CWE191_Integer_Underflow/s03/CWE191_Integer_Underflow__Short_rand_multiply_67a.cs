/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__Short_rand_multiply_67a.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-67a.tmpl.cs
*/
/*
 * @description
 * CWE: 191 Integer Underflow
 * BadSource: rand Set data to result of rand()
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
class CWE191_Integer_Underflow__Short_rand_multiply_67a : AbstractTestCase
{

    public class Container
    {
        public short containerOne;
    }
#if (!OMITBAD)
    public override void Bad()
    {
        short data;
        /* POTENTIAL FLAW: Use a random value */
        data = (short)(new Random().Next(short.MinValue, short.MaxValue));
        Container dataContainer = new Container();
        dataContainer.containerOne = data;
        CWE191_Integer_Underflow__Short_rand_multiply_67b.BadSink(dataContainer  );
    }
#endif //omitbad

}
}
