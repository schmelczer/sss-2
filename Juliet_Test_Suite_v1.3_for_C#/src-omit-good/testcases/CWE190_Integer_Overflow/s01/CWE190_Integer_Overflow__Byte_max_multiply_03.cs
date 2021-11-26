/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__Byte_max_multiply_03.cs
Label Definition File: CWE190_Integer_Overflow.label.xml
Template File: sources-sinks-03.tmpl.cs
*/
/*
* @description
* CWE: 190 Integer Overflow
* BadSource: max Set data to the max value for byte
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: multiply
*    GoodSink: Ensure there will not be an overflow before multiplying data by 2
*    BadSink : If data is positive, multiply by 2, which can cause an overflow
* Flow Variant: 03 Control flow: if(5==5) and if(5!=5)
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__Byte_max_multiply_03 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        byte data;
        if (5==5)
        {
            /* POTENTIAL FLAW: Use the maximum size of the data type */
            data = byte.MaxValue;
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = 0;
        }
        if (5==5)
        {
            if(data > 0) /* ensure we won't have an underflow */
            {
                /* POTENTIAL FLAW: if (data*2) > byte.MaxValue, this will overflow */
                byte result = (byte)(data * 2);
                IO.WriteLine("result: " + result);
            }
        }
    }
#endif //omitbad

}
}
