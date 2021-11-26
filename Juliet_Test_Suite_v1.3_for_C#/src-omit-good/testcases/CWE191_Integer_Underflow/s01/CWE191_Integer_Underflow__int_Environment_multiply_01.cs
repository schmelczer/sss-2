/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__int_Environment_multiply_01.cs
Label Definition File: CWE191_Integer_Underflow__int.label.xml
Template File: sources-sinks-01.tmpl.cs
*/
/*
* @description
* CWE: 191 Integer Underflow
* BadSource: Environment Read data from an environment variable
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: multiply
*    GoodSink: Ensure there will not be an underflow before multiplying data by 2
*    BadSink : If data is negative, multiply by 2, which can cause an underflow
* Flow Variant: 01 Baseline
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__int_Environment_multiply_01 : AbstractTestCase
{
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
        if(data < 0) /* ensure we won't have an overflow */
        {
            /* POTENTIAL FLAW: if (data * 2) < int.MinValue, this will underflow */
            int result = (int)(data * 2);
            IO.WriteLine("result: " + result);
        }
    }
#endif //omitbad

}
}
