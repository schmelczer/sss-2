/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__UInt64_min_sub_03.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-03.tmpl.cs
*/
/*
* @description
* CWE: 191 Integer Underflow
* BadSource: min Set data to the min value for ulong
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: sub
*    GoodSink: Ensure there will not be an underflow before subtracting 1 from data
*    BadSink : Subtract 1 from data, which can cause an Underflow
* Flow Variant: 03 Control flow: if(5==5) and if(5!=5)
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__UInt64_min_sub_03 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        ulong data;
        if (5==5)
        {
            /* POTENTIAL FLAW: Use the minimum size of the data type */
            data = ulong.MinValue;
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = 0ul;
        }
        if (5==5)
        {
            /* POTENTIAL FLAW: if data == ulong.MinValue, this will overflow */
            ulong result = (ulong)(data - 1);
            IO.WriteLine("result: " + result);
        }
    }
#endif //omitbad

}
}
