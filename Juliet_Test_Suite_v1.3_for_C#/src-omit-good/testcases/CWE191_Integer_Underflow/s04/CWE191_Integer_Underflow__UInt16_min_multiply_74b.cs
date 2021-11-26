/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__UInt16_min_multiply_74b.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-74b.tmpl.cs
*/
/*
 * @description
 * CWE: 191 Integer Underflow
 * BadSource: min Set data to the min value for ushort
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: multiply
 *    GoodSink: Ensure there will not be an underflow before multiplying data by 2
 *    BadSink : If data is negative, multiply by 2, which can cause an underflow
 * Flow Variant: 74 Data flow: data passed in a Dictionary from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;
using System.Collections.Generic;

using System.Web;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__UInt16_min_multiply_74b
{
#if (!OMITBAD)
    public static void BadSink(Dictionary<int,ushort> dataDictionary )
    {
        ushort data = dataDictionary[2];
        if(data < 0) /* ensure we won't have an overflow */
        {
            /* POTENTIAL FLAW: if (data * 2) < ushort.MinValue, this will underflow */
            ushort result = (ushort)(data * 2);
            IO.WriteLine("result: " + result);
        }
    }
#endif


}
}
