/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__long_random_to_int_17.cs
Label Definition File: CWE197_Numeric_Truncation_Error__long.label.xml
Template File: sources-sink-17.tmpl.cs
*/
/*
* @description
* CWE: 197 Numeric Truncation Error
* BadSource: random Set data to a random value
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* BadSink: to_int Convert data to a int
* Flow Variant: 17 Control flow: for loops
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE197_Numeric_Truncation_Error
{

class CWE197_Numeric_Truncation_Error__long_random_to_int_17 : AbstractTestCase
{
#if (!OMITBAD)
    /* uses badsource and badsink */
    public override void Bad()
    {
        long data;
        /* FLAW: Set data to a random value */
        data = IO.GetRandomLong();
        for (int i = 0; i < 1; i++)
        {
            {
                /* POTENTIAL FLAW: Convert data to a int, possibly causing a truncation error */
                IO.WriteLine((int)data);
            }
        }
    }
#endif //omitbad

}
}
