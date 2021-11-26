/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__SByte_max_add_16.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-16.tmpl.cs
*/
/*
* @description
* CWE: 190 Integer Overflow
* BadSource: max Set data to the max value for sbyte
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: add
*    GoodSink: Ensure there will not be an overflow before adding 1 to data
*    BadSink : Add 1 to data, which can cause an overflow
* Flow Variant: 16 Control flow: while(true)
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__SByte_max_add_16 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        sbyte data;
        while (true)
        {
            /* POTENTIAL FLAW: Use the maximum size of the data type */
            data = sbyte.MaxValue;
            break;
        }
        while (true)
        {
            /* POTENTIAL FLAW: if data == sbyte.MaxValue, this will overflow */
            sbyte result = (sbyte)(data + 1);
            IO.WriteLine("result: " + result);
            break;
        }
    }
#endif //omitbad

}
}