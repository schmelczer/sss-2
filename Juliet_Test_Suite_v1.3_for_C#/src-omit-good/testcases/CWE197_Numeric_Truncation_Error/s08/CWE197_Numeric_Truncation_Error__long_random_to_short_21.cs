/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__long_random_to_short_21.cs
Label Definition File: CWE197_Numeric_Truncation_Error__long.label.xml
Template File: sources-sink-21.tmpl.cs
*/
/*
 * @description
 * CWE: 197 Numeric Truncation Error
 * BadSource: random Set data to a random value
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: to_short
 *    BadSink : Convert data to a short
 * Flow Variant: 21 Control flow: Flow controlled by value of a private variable. All functions contained in one file.
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE197_Numeric_Truncation_Error
{

class CWE197_Numeric_Truncation_Error__long_random_to_short_21 : AbstractTestCase
{

    /* The variable below is used to drive control flow in the source function */
    private bool badPrivate = false;
#if (!OMITBAD)
    public override void Bad()
    {
        long data;
        badPrivate = true;
        data = Bad_source();
        {
            /* POTENTIAL FLAW: Convert data to a short, possibly causing a truncation error */
            IO.WriteLine((short)data);
        }
    }

    private long Bad_source()
    {
        long data;
        if (badPrivate)
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
        return data;
    }
#endif //omitbad
    /* The variables below are used to drive control flow in the source functions. */
    private bool goodG2B1_private = false;
    private bool GoodG2B2_private = false;

}
}
