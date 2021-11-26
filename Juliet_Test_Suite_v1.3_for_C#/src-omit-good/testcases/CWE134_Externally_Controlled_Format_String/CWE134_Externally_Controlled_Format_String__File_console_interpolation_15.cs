/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE134_Externally_Controlled_Format_String__File_console_interpolation_15.cs
Label Definition File: CWE134_Externally_Controlled_Format_String.label.xml
Template File: sources-sinks-15.tmpl.cs
*/
/*
* @description
* CWE: 134 Externally Controlled Format String
* BadSource: File Read data from file (named data.txt)
* GoodSource: A hardcoded string
* Sinks: console_interpolation
*    GoodSink: console write with interpolation
*    BadSink : console write formatted without validation
* Flow Variant: 15 Control flow: switch(6) and switch(7)
*
* */

using TestCaseSupport;
using System;

using System.IO;

namespace testcases.CWE134_Externally_Controlled_Format_String
{
class CWE134_Externally_Controlled_Format_String__File_console_interpolation_15 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        string data;
        switch (6)
        {
        case 6:
            data = ""; /* Initialize data */
            {
                try
                {
                    /* read string from file into data */
                    using (StreamReader sr = new StreamReader("data.txt"))
                    {
                        /* POTENTIAL FLAW: Read data from a file */
                        /* This will be reading the first "line" of the file, which
                         * could be very long if there are little or no newlines in the file */
                        data = sr.ReadLine();
                    }
                }
                catch (IOException exceptIO)
                {
                    IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error with stream reading");
                }
            }
            break;
        default:
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
            break;
        }
        switch (7)
        {
        case 7:
            if (data != null)
            {
                /* POTENTIAL FLAW: uncontrolled string formatting */
                Console.Write(string.Format(data));
            }
            break;
        default:
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
            break;
        }
    }
#endif //omitbad

}
}
