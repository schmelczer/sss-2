/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__long_console_ReadLine_to_byte_31.cs
Label Definition File: CWE197_Numeric_Truncation_Error__long.label.xml
Template File: sources-sink-31.tmpl.cs
*/
/*
 * @description
 * CWE: 197 Numeric Truncation Error
 * BadSource: console_ReadLine Read data from the console using ReadLine
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: to_byte
 *    BadSink : Convert data to a byte
 * Flow Variant: 31 Data flow: make a copy of data within the same method
 *
 * */

using TestCaseSupport;
using System;

using System.IO;

namespace testcases.CWE197_Numeric_Truncation_Error
{

class CWE197_Numeric_Truncation_Error__long_console_ReadLine_to_byte_31 : AbstractTestCase
{
#if (!OMITBAD)
    /* uses badsource and badsink */
    public override void Bad()
    {
        long dataCopy;
        {
            long data;
            data = long.MinValue; /* Initialize data */
            {
                /* read user input from console with ReadLine */
                try
                {
                    /* FLAW: Read data from the console using ReadLine */
                    string stringNumber = Console.ReadLine();
                    if (stringNumber != null) // avoid NPD incidental warnings
                    {
                        try
                        {
                            data = long.Parse(stringNumber.Trim());
                        }
                        catch(FormatException exceptNumberFormat)
                        {
                            IO.Logger.Log(NLog.LogLevel.Warn, exceptNumberFormat, "Number format exception parsing data from string");
                        }
                    }
                }
                catch (IOException exceptIO)
                {
                    IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error with stream reading");
                }
            }
            dataCopy = data;
        }
        {
            long data = dataCopy;
            {
                /* POTENTIAL FLAW: Convert data to a byte, possibly causing a truncation error */
                IO.WriteLine((byte)data);
            }
        }
    }
#endif //omitbad

}
}
