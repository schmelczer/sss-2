/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__int_Random_to_short_02.cs
Label Definition File: CWE197_Numeric_Truncation_Error__int.label.xml
Template File: sources-sink-02.tmpl.cs
*/
/*
* @description
* CWE: 197 Numeric Truncation Error
* BadSource: Random Set data to a random value
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* BadSink: to_short Convert data to a short
* Flow Variant: 02 Control flow: if(true) and if(false)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE197_Numeric_Truncation_Error
{

class CWE197_Numeric_Truncation_Error__int_Random_to_short_02 : AbstractTestCase
{
#if (!OMITBAD)
    /* uses badsource and badsink */
    public override void Bad()
    {
        int data;
        if (true)
        {
            /* POTENTIAL FLAW: Set data to a random value */
            data = (new Random()).Next();
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
