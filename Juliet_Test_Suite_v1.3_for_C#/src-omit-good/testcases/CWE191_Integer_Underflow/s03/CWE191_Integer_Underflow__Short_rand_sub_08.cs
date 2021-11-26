/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__Short_rand_sub_08.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-08.tmpl.cs
*/
/*
* @description
* CWE: 191 Integer Underflow
* BadSource: rand Set data to result of rand()
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: sub
*    GoodSink: Ensure there will not be an underflow before subtracting 1 from data
*    BadSink : Subtract 1 from data, which can cause an Underflow
* Flow Variant: 08 Control flow: if(PrivateReturnsTrue()) and if(PrivateReturnsFalse())
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__Short_rand_sub_08 : AbstractTestCase
{

    /* The methods below always return the same value, so a tool
     * should be able to figure out that every call to these
     * methods will return true or return false. */
    private static bool PrivateReturnsTrue()
    {
        return true;
    }

    private static bool PrivateReturnsFalse()
    {
        return false;
    }
#if (!OMITBAD)
    public override void Bad()
    {
        short data;
        if (PrivateReturnsTrue())
        {
            /* POTENTIAL FLAW: Use a random value */
            data = (short)(new Random().Next(short.MinValue, short.MaxValue));
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = 0;
        }
        if (PrivateReturnsTrue())
        {
            /* POTENTIAL FLAW: if data == short.MinValue, this will overflow */
            short result = (short)(data - 1);
            IO.WriteLine("result: " + result);
        }
    }
#endif //omitbad

}
}
