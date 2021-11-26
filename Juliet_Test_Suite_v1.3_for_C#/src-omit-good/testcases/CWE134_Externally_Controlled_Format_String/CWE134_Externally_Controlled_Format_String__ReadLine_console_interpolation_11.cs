/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE134_Externally_Controlled_Format_String__ReadLine_console_interpolation_11.cs
Label Definition File: CWE134_Externally_Controlled_Format_String.label.xml
Template File: sources-sinks-11.tmpl.cs
*/
/*
* @description
* CWE: 134 Externally Controlled Format String
* BadSource: ReadLine Read data from the console using ReadLine()
* GoodSource: A hardcoded string
* Sinks: console_interpolation
*    GoodSink: console write with interpolation
*    BadSink : console write formatted without validation
* Flow Variant: 11 Control flow: if(IO.StaticReturnsTrue()) and if(IO.StaticReturnsFalse())
*
* */

using TestCaseSupport;
using System;

using System.IO;

namespace testcases.CWE134_Externally_Controlled_Format_String
{
class CWE134_Externally_Controlled_Format_String__ReadLine_console_interpolation_11 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        string data;
        if (IO.StaticReturnsTrue())
        {
            data = ""; /* Initialize data */
            {
                /* read user input from console with ReadLine */
                try
                {
                    /* POTENTIAL FLAW: Read data from the console using ReadLine */
                    data = Console.ReadLine();
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
            data = null;
        }
        if(IO.StaticReturnsTrue())
        {
            if (data != null)
            {
                /* POTENTIAL FLAW: uncontrolled string formatting */
                Console.Write(string.Format(data));
            }
        }
    }
#endif //omitbad

}
}
