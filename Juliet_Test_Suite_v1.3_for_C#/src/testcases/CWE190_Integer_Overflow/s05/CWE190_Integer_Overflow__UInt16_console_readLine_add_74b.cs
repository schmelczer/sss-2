/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__UInt16_console_readLine_add_74b.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-74b.tmpl.cs
*/
/*
 * @description
 * CWE: 190 Integer Overflow
 * BadSource: console_readLine Read data from the console using readLine
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: add
 *    GoodSink: Ensure there will not be an overflow before adding 1 to data
 *    BadSink : Add 1 to data, which can cause an overflow
 * Flow Variant: 74 Data flow: data passed in a Dictionary from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;
using System.Collections.Generic;

using System.Web;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__UInt16_console_readLine_add_74b
{
#if (!OMITBAD)
    public static void BadSink(Dictionary<int,ushort> dataDictionary )
    {
        ushort data = dataDictionary[2];
        /* POTENTIAL FLAW: if data == ushort.MaxValue, this will overflow */
        ushort result = (ushort)(data + 1);
        IO.WriteLine("result: " + result);
    }
#endif

#if (!OMITGOOD)
    /* goodG2B() - use GoodSource and BadSink */
    public static  void GoodG2BSink(Dictionary<int,ushort> dataDictionary )
    {
        ushort data = dataDictionary[2];
        /* POTENTIAL FLAW: if data == ushort.MaxValue, this will overflow */
        ushort result = (ushort)(data + 1);
        IO.WriteLine("result: " + result);
    }

    /* goodB2G() - use BadSource and GoodSink */
    public static void GoodB2GSink(Dictionary<int,ushort> dataDictionary )
    {
        ushort data = dataDictionary[2];
        /* FIX: Add a check to prevent an overflow from occurring */
        if (data < ushort.MaxValue)
        {
            ushort result = (ushort)(data + 1);
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
