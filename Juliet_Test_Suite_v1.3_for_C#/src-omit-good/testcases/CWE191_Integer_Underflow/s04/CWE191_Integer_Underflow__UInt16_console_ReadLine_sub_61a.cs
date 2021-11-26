/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__UInt16_console_ReadLine_sub_61a.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-61a.tmpl.cs
*/
/*
 * @description
 * CWE: 191 Integer Underflow
 * BadSource: console_ReadLine Read data from the console using ReadLine
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: sub
 *    GoodSink: Ensure there will not be an underflow before subtracting 1 from data
 *    BadSink : Subtract 1 from data, which can cause an Underflow
 * Flow Variant: 61 Data flow: data returned from one method to another in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__UInt16_console_ReadLine_sub_61a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        ushort data = CWE191_Integer_Underflow__UInt16_console_ReadLine_sub_61b.BadSource();
        /* POTENTIAL FLAW: if data == ushort.MinValue, this will overflow */
        ushort result = (ushort)(data - 1);
        IO.WriteLine("result: " + result);
    }
#endif //omitbad

}
}
