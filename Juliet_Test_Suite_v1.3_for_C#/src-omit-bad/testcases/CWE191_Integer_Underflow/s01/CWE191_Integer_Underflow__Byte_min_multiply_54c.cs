/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__Byte_min_multiply_54c.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-54c.tmpl.cs
*/
/*
 * @description
 * CWE: 191 Integer Underflow
 * BadSource: min Set data to the min value for byte
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: multiply
 *    GoodSink: Ensure there will not be an underflow before multiplying data by 2
 *    BadSink : If data is negative, multiply by 2, which can cause an underflow
 * Flow Variant: 54 Data flow: data passed as an argument from one method through three others to a fifth; all five functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__Byte_min_multiply_54c
{


#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink */
    public static void GoodG2BSink(byte data )
    {
        CWE191_Integer_Underflow__Byte_min_multiply_54d.GoodG2BSink(data );
    }

    /* goodB2G() - use badsource and goodsink */
    public static void GoodB2GSink(byte data )
    {
        CWE191_Integer_Underflow__Byte_min_multiply_54d.GoodB2GSink(data );
    }
#endif
}
}
