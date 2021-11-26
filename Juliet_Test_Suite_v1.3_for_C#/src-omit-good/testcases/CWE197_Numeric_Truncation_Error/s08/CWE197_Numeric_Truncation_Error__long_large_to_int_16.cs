/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__long_large_to_int_16.cs
Label Definition File: CWE197_Numeric_Truncation_Error__long.label.xml
Template File: sources-sink-16.tmpl.cs
*/
/*
* @description
* CWE: 197 Numeric Truncation Error
* BadSource: large Set data to a number larger than int.MaxValue
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* BadSink: to_int Convert data to a int
* Flow Variant: 16 Control flow: while(true)
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE197_Numeric_Truncation_Error
{

class CWE197_Numeric_Truncation_Error__long_large_to_int_16 : AbstractTestCase
{
#if (!OMITBAD)
    /* uses badsource and badsink */
    public override void Bad()
    {
        long data;
        while (true)
        {
            /* FLAW: Use a number larger than int.MaxValue */
            data = int.MaxValue + 5L;
            break;
        }
        {
            /* POTENTIAL FLAW: Convert data to a int, possibly causing a truncation error */
            IO.WriteLine((int)data);
        }
    }
#endif //omitbad

}
}
