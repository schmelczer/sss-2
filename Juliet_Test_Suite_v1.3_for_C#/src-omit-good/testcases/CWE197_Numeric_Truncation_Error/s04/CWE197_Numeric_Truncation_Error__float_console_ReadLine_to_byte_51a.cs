/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__float_console_ReadLine_to_byte_51a.cs
Label Definition File: CWE197_Numeric_Truncation_Error__float.label.xml
Template File: sources-sink-51a.tmpl.cs
*/
/*
 * @description
 * CWE: 197 Numeric Truncation Error
 * BadSource: console_ReadLine Read data from the console using ReadLine
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * BadSink: to_byte Convert data to a byte
 * Flow Variant: 51 Data flow: data passed as an argument from one function to another in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.IO;

namespace testcases.CWE197_Numeric_Truncation_Error
{

class CWE197_Numeric_Truncation_Error__float_console_ReadLine_to_byte_51a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        float data;
        data = float.MinValue; /* Initialize data */
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
                        data = float.Parse(stringNumber.Trim());
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
        CWE197_Numeric_Truncation_Error__float_console_ReadLine_to_byte_51b.BadSink(data  );
    }
#endif //omitbad

}
}
