/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__UInt64_max_add_67b.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-67b.tmpl.cs
*/
/*
 * @description
 * CWE: 190 Integer Overflow
 * BadSource: max Set data to the max value for ulong
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: add
 *    GoodSink: Ensure there will not be an overflow before adding 1 to data
 *    BadSink : Add 1 to data, which can cause an overflow
 * Flow Variant: 67 Data flow: data passed in a class from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__UInt64_max_add_67b
{


#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink */
    public static void GoodG2BSink(CWE190_Integer_Overflow__UInt64_max_add_67a.Container dataContainer )
    {
        ulong data = dataContainer.containerOne;
        /* POTENTIAL FLAW: if data == ulong.MaxValue, this will overflow */
        ulong result = (ulong)(data + 1);
        IO.WriteLine("result: " + result);
    }

    /* goodB2G() - use badsource and goodsink */
    public static void GoodB2GSink(CWE190_Integer_Overflow__UInt64_max_add_67a.Container dataContainer )
    {
        ulong data = dataContainer.containerOne;
        /* FIX: Add a check to prevent an overflow from occurring */
        if (data < ulong.MaxValue)
        {
            ulong result = (ulong)(data + 1);
            IO.WriteLine("result: " + result);
        }
        else
        {
            IO.WriteLine("data value is too large to perform addition.");
        }
    }
#endif
}
}
