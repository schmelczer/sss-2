/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__UInt16_rand_sub_02.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-02.tmpl.cs
*/
/*
* @description
* CWE: 191 Integer Underflow
* BadSource: rand Set data to result of rand()
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: sub
*    GoodSink: Ensure there will not be an underflow before subtracting 1 from data
*    BadSink : Subtract 1 from data, which can cause an Underflow
* Flow Variant: 02 Control flow: if(true) and if(false)
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__UInt16_rand_sub_02 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        ushort data;
        if (true)
        {
            /* POTENTIAL FLAW: Use a random value */
            data = (ushort)(new Random().Next(ushort.MinValue, ushort.MaxValue));
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = 0;
        }
        if (true)
        {
            /* POTENTIAL FLAW: if data == ushort.MinValue, this will overflow */
            ushort result = (ushort)(data - 1);
            IO.WriteLine("result: " + result);
        }
    }
#endif //omitbad

}
}
