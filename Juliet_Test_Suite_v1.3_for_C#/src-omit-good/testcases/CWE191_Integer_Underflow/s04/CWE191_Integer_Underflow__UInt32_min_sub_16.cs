/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__UInt32_min_sub_16.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-16.tmpl.cs
*/
/*
* @description
* CWE: 191 Integer Underflow
* BadSource: min Set data to the min value for uint
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: sub
*    GoodSink: Ensure there will not be an underflow before subtracting 1 from data
*    BadSink : Subtract 1 from data, which can cause an Underflow
* Flow Variant: 16 Control flow: while(true)
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__UInt32_min_sub_16 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        uint data;
        while (true)
        {
            /* POTENTIAL FLAW: Use the minimum size of the data type */
            data = uint.MinValue;
            break;
        }
        while (true)
        {
            /* POTENTIAL FLAW: if data == uint.MinValue, this will overflow */
            uint result = (uint)(data - 1);
            IO.WriteLine("result: " + result);
            break;
        }
    }
#endif //omitbad

}
}
