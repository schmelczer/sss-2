/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__int_File_to_short_05.cs
Label Definition File: CWE197_Numeric_Truncation_Error__int.label.xml
Template File: sources-sink-05.tmpl.cs
*/
/*
* @description
* CWE: 197 Numeric Truncation Error
* BadSource: File Read data from file (named c:\data.txt)
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* BadSink: to_short Convert data to a short
* Flow Variant: 05 Control flow: if(privateTrue) and if(privateFalse)
*
* */

using TestCaseSupport;
using System;

using System.IO;

namespace testcases.CWE197_Numeric_Truncation_Error
{

class CWE197_Numeric_Truncation_Error__int_File_to_short_05 : AbstractTestCase
{

    /* The two variables below are not defined as "readonly", but are never
     * assigned any other value, so a tool should be able to identify that
     * reads of these will always return their initialized values.
     */
    private bool privateTrue = true;
    private bool privateFalse = false;
#if (!OMITBAD)
    /* uses badsource and badsink */
    public override void Bad()
    {
        int data;
        if (privateTrue)
        {
            data = int.MinValue; /* Initialize data */
            {
                try
                {
                    /* read string from file into data */
                    using (StreamReader sr = new StreamReader("data.txt"))
                    {
                        /* POTENTIAL FLAW: Read data from a file */
                        /* This will be reading the first "line" of the file, which
                         * could be very long if there are little or no newlines in the file */
                        string stringNumber = sr.ReadLine();
                        if (stringNumber != null) /* avoid NPD incidental warnings */
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
                }
                catch (IOException exceptIO)
                {
                    IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error with stream reading");
                }
            }
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