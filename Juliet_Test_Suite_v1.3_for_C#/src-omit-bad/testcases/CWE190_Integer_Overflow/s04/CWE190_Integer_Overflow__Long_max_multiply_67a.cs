/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__Long_max_multiply_67a.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-67a.tmpl.cs
*/
/*
 * @description
 * CWE: 190 Integer Overflow
 * BadSource: max Set data to the max value for long
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: multiply
 *    GoodSink: Ensure there will not be an overflow before multiplying data by 2
 *    BadSink : If data is positive, multiply by 2, which can cause an overflow
 * Flow Variant: 67 Data flow: data passed in a class from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__Long_max_multiply_67a : AbstractTestCase
{

    public class Container
    {
        public long containerOne;
    }

#if (!OMITGOOD)
    public override void Good()
    {
        GoodG2B();
        GoodB2G();
    }

    /* goodG2B() - use goodsource and badsink */
    private static void GoodG2B()
    {
        long data;
        /* FIX: Use a hardcoded number that won't cause underflow, overflow, divide by zero, or loss-of-precision issues */
        data = 2;
        Container dataContainer = new Container();
        dataContainer.containerOne = data;
        CWE190_Integer_Overflow__Long_max_multiply_67b.GoodG2BSink(dataContainer  );
    }

    /* goodB2G() - use badsource and goodsink */
    private static void GoodB2G()
    {
        long data;
        /* POTENTIAL FLAW: Use the maximum size of the data type */
        data = long.MaxValue;
        Container dataContainer = new Container();
        dataContainer.containerOne = data;
        CWE190_Integer_Overflow__Long_max_multiply_67b.GoodB2GSink(dataContainer  );
    }
#endif //omitgood
}
}
