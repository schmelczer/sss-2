/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__long_random_to_byte_01.cs
Label Definition File: CWE197_Numeric_Truncation_Error__long.label.xml
Template File: sources-sink-01.tmpl.cs
*/
/*
* @description
* CWE: 197 Numeric Truncation Error
* BadSource: random Set data to a random value
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* BadSink: to_byte Convert data to a byte
* Flow Variant: 01 Baseline
*
* */

using TestCaseSupport;
using System;

namespace testcases.CWE197_Numeric_Truncation_Error
{

class CWE197_Numeric_Truncation_Error__long_random_to_byte_01 : AbstractTestCase
{
#if (!OMITBAD)
    /* uses badsource and badsink */
    public override void Bad()
    {
        long data;
        /* FLAW: Set data to a random value */
        data = IO.GetRandomLong();
        {
            /* POTENTIAL FLAW: Convert data to a byte, possibly causing a truncation error */
            IO.WriteLine((byte)data);
        }
    }
#endif //omitbad

}
}
