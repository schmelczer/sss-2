/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE190_Integer_Overflow__int_Environment_add_21.cs
Label Definition File: CWE190_Integer_Overflow__int.label.xml
Template File: sources-sinks-21.tmpl.cs
*/
/*
 * @description
 * CWE: 190 Integer Overflow
 * BadSource: Environment Read data from an environment variable
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: add
 *    GoodSink: Ensure there will not be an overflow before adding 1 to data
 *    BadSink : Add 1 to data, which can cause an overflow
 * Flow Variant: 21 Control flow: Flow controlled by value of a private variable. All functions contained in one file.
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE190_Integer_Overflow
{
class CWE190_Integer_Overflow__int_Environment_add_21 : AbstractTestCase
{

    /* The variable below is used to drive control flow in the sink function */
    private bool badPrivate = false;
#if (!OMITBAD)
    public override void Bad()
    {
        int data;
        data = int.MinValue; /* Initialize data */
        /* get environment variable ADD */
        /* POTENTIAL FLAW: Read data from an environment variable */
        {
            string stringNumber = Environment.GetEnvironmentVariable("ADD");
            if (stringNumber != null) // avoid NPD incidental warnings
            {
                try
                {
                    data = int.Parse(stringNumber.Trim());
                }
                catch (FormatException exceptNumberFormat)
                {
                    IO.Logger.Log(NLog.LogLevel.Warn, exceptNumberFormat, "Number format exception parsing data from string");
                }
            }
        }
        badPrivate = true;
        BadSink(data );
    }

    private void BadSink(int data )
    {
        if (badPrivate)
        {
            /* POTENTIAL FLAW: if data == int.MaxValue, this will overflow */
            int result = (int)(data + 1);
            IO.WriteLine("result: " + result);
        }
    }
#endif //omitbad
    /* The variables below are used to drive control flow in the sink functions. */
    private bool goodB2G1Private = false;
    private bool goodB2G2Private = false;
    private bool goodG2BPrivate = false;

}
}