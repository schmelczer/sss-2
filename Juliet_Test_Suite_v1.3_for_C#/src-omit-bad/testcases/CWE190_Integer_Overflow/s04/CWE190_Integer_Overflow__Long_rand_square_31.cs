/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__Long_rand_square_31.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-31.tmpl.cs
*/
/*
 * @description
 * CWE: 190 Integer Overflow
 * BadSource: rand Set data to result of rand()
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: square
 *    GoodSink: Ensure there will not be an overflow before squaring data
 *    BadSink : Square data, which can lead to overflow
 * Flow Variant: 31 Data flow: make a copy of data within the same method
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__Long_rand_square_31 : AbstractTestCase
{

#if (!OMITGOOD)
    public override void Good()
    {
        GoodG2B();
        GoodB2G();
    }

    /* goodG2B() - use goodsource and badsink */
    private void GoodG2B()
    {
        long dataCopy;
        {
            long data;
            /* FIX: Use a hardcoded number that won't cause underflow, overflow, divide by zero, or loss-of-precision issues */
            data = 2;
            dataCopy = data;
        }
        {
            long data = dataCopy;
            /* POTENTIAL FLAW: if (data*data) > long.MaxValue, this will overflow */
            long result = (long)(data * data);
            IO.WriteLine("result: " + result);
        }
    }

    /* goodB2G() - use badsource and goodsink */
    private void GoodB2G()
    {
        long dataCopy;
        {
            long data;
            /* POTENTIAL FLAW: Use a random value */
            data = IO.GetRandomLong();
            dataCopy = data;
        }
        {
            long data = dataCopy;
            /* FIX: Add a check to prevent an overflow from occurring */
            if (Math.Abs((long)data) <= (long)Math.Sqrt(long.MaxValue))
            {
                long result = (long)(data * data);
                IO.WriteLine("result: " + result);
            }
            else
            {
                IO.WriteLine("data value is too large to perform squaring.");
            }
        }
    }
#endif //omitgood
}
}