/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__Byte_max_add_21.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-21.tmpl.cs
*/
/*
 * @description
 * CWE: 190 Integer Overflow
 * BadSource: max Set data to the max value for byte
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: add
 *    GoodSink: Ensure there will not be an overflow before adding 1 to data
 *    BadSink : Add 1 to data, which can cause an overflow
 * Flow Variant: 21 Control flow: Flow controlled by value of a private variable. All functions contained in one file.
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__Byte_max_add_21 : AbstractTestCase
{

    /* The variable below is used to drive control flow in the sink function */
    private bool badPrivate = false;

    /* The variables below are used to drive control flow in the sink functions. */
    private bool goodB2G1Private = false;
    private bool goodB2G2Private = false;
    private bool goodG2BPrivate = false;
#if (!OMITGOOD)
    public override void Good()
    {
        GoodB2G1();
        GoodB2G2();
        GoodG2B();
    }

    /* goodB2G1() - use BadSource and GoodSink by setting the variable to false instead of true */
    private void GoodB2G1()
    {
        byte data;
        /* POTENTIAL FLAW: Use the maximum size of the data type */
        data = byte.MaxValue;
        goodB2G1Private = false;
        GoodB2G1Sink(data );
    }

    private void GoodB2G1Sink(byte data )
    {
        if (goodB2G1Private)
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
        }
        else
        {
            /* FIX: Add a check to prevent an overflow from occurring */
            if (data < byte.MaxValue)
            {
                byte result = (byte)(data + 1);
                IO.WriteLine("result: " + result);
            }
            else
            {
                IO.WriteLine("data value is too large to perform addition.");
            }
        }
    }

    /* goodB2G2() - use BadSource and GoodSink by reversing the blocks in the if in the sink function */
    private void GoodB2G2()
    {
        byte data;
        /* POTENTIAL FLAW: Use the maximum size of the data type */
        data = byte.MaxValue;
        goodB2G2Private = true;
        GoodB2G2Sink(data );
    }

    private void GoodB2G2Sink(byte data )
    {
        if (goodB2G2Private)
        {
            /* FIX: Add a check to prevent an overflow from occurring */
            if (data < byte.MaxValue)
            {
                byte result = (byte)(data + 1);
                IO.WriteLine("result: " + result);
            }
            else
            {
                IO.WriteLine("data value is too large to perform addition.");
            }
        }
    }

    /* goodG2B() - use GoodSource and BadSink */
    private void GoodG2B()
    {
        byte data;
        /* FIX: Use a hardcoded number that won't cause underflow, overflow, divide by zero, or loss-of-precision issues */
        data = 2;
        goodG2BPrivate = true;
        GoodG2BSink(data );
    }

    private void GoodG2BSink(byte data )
    {
        if (goodG2BPrivate)
        {
            /* POTENTIAL FLAW: if data == byte.MaxValue, this will overflow */
            byte result = (byte)(data + 1);
            IO.WriteLine("result: " + result);
        }
    }
#endif //omitgood
}
}
