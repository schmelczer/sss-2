/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__long_random_to_short_03.cs
Label Definition File: CWE197_Numeric_Truncation_Error__long.label.xml
Template File: sources-sink-03.tmpl.cs
*/
/*
* @description
* CWE: 197 Numeric Truncation Error
* BadSource: random Set data to a random value
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* BadSink: to_short Convert data to a short
* Flow Variant: 03 Control flow: if(5==5) and if(5!=5)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE197_Numeric_Truncation_Error
{

class CWE197_Numeric_Truncation_Error__long_random_to_short_03 : AbstractTestCase
{
#if (!OMITBAD)
    /* uses badsource and badsink */
    public override void Bad()
    {
        long data;
        if (5 == 5)
        {
            /* FLAW: Set data to a random value */
            data = IO.GetRandomLong();
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = 0L;
        }
        {
            /* POTENTIAL FLAW: Convert data to a short, possibly causing a truncation error */
            IO.WriteLine((short)data);
        }
    }
#endif //omitbad

}
}
