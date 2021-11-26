/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__short_Environment_66a.cs
Label Definition File: CWE197_Numeric_Truncation_Error__short.label.xml
Template File: sources-sink-66a.tmpl.cs
*/
/*
 * @description
 * CWE: 197 Numeric Truncation Error
 * BadSource: Environment Read data from an environment variable
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: to_byte
 *    BadSink : Convert data to a byte
 * Flow Variant: 66 Data flow: data passed in an array from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE197_Numeric_Truncation_Error
{

class CWE197_Numeric_Truncation_Error__short_Environment_66a : AbstractTestCase
{
#if (!OMITBAD)
    public override  void Bad()
    {
        short data;
        data = short.MinValue; /* Initialize data */
        /* get environment variable ADD */
        /* FLAW: Read data from an environment variable */
        {
            string stringNumber = Environment.GetEnvironmentVariable("ADD");
            if (stringNumber != null) // avoid NPD incidental warnings
            {
                try
                {
                    data = short.Parse(stringNumber.Trim());
                }
                catch (FormatException exceptNumberFormat)
                {
                    IO.Logger.Log(NLog.LogLevel.Warn, exceptNumberFormat, "Number format exception parsing data from string");
                }
            }
        }
        short[] dataArray = new short[5];
        dataArray[2] = data;
        CWE197_Numeric_Truncation_Error__short_Environment_66b.BadSink(dataArray  );
    }
#endif //omitbad

}
}