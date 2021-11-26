/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__int_large_to_short_03.cs
Label Definition File: CWE197_Numeric_Truncation_Error__int.label.xml
Template File: sources-sink-03.tmpl.cs
*/
/*
* @description
* CWE: 197 Numeric Truncation Error
* BadSource: large Set data to a number larger than short.MaxValue
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* BadSink: to_short Convert data to a short
* Flow Variant: 03 Control flow: if(5==5) and if(5!=5)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE197_Numeric_Truncation_Error
{

class CWE197_Numeric_Truncation_Error__int_large_to_short_03 : AbstractTestCase
{
#if (!OMITBAD)
    /* uses badsource and badsink */
    public override void Bad()
    {
        int data;
        if (5 == 5)
        {
            /* FLAW: Use a number larger than short.MaxValue */
            data = short.MaxValue + 5;
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = 0;
        }
        {
            /* POTENTIAL FLAW: Convert data to a short, possibly causing a truncation error */
            IO.WriteLine((short)data);
        }
    }
#endif //omitbad

}
}