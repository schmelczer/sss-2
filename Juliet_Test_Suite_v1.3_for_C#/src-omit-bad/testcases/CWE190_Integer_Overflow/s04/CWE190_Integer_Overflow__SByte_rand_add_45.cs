/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__SByte_rand_add_45.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-45.tmpl.cs
*/
/*
 * @description
 * CWE: 190 Integer Overflow
 * BadSource: rand Set data to result of rand()
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: add
 *    GoodSink: Ensure there will not be an overflow before adding 1 to data
 *    BadSink : Add 1 to data, which can cause an overflow
 * Flow Variant: 45 Data flow: data passed as a private class member variable from one function to another in the same class
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__SByte_rand_add_45 : AbstractTestCase
{

    private sbyte dataBad;
    private sbyte dataGoodG2B;
    private sbyte dataGoodB2G;

#if (!OMITGOOD)
    public override void Good()
    {
        GoodG2B();
        GoodB2G();
    }

    private void GoodG2BSink()
    {
        sbyte data = dataGoodG2B;
        /* POTENTIAL FLAW: if data == sbyte.MaxValue, this will overflow */
        sbyte result = (sbyte)(data + 1);
        IO.WriteLine("result: " + result);
    }

    /* goodG2B() - use goodsource and badsink */
    private void GoodG2B()
    {
        sbyte data;
        /* FIX: Use a hardcoded number that won't cause underflow, overflow, divide by zero, or loss-of-precision issues */
        data = 2;
        dataGoodG2B = data;
        GoodG2BSink();
    }

    private void GoodB2GSink()
    {
        sbyte data = dataGoodB2G;
        /* FIX: Add a check to prevent an overflow from occurring */
        if (data < sbyte.MaxValue)
        {
            sbyte result = (sbyte)(data + 1);
            IO.WriteLine("result: " + result);
        }
        else
        {
            IO.WriteLine("data value is too large to perform addition.");
        }
    }

    /* goodB2G() - use badsource and goodsink */
    private void GoodB2G()
    {
        sbyte data;
        /* POTENTIAL FLAW: Use a random value */
        data = (sbyte)(new Random().Next(sbyte.MinValue, sbyte.MaxValue));
        dataGoodB2G = data;
        GoodB2GSink();
    }
#endif //omitgood
}
}
