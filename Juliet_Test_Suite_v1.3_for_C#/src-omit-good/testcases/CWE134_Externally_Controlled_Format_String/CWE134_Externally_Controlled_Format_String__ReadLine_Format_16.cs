/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE134_Externally_Controlled_Format_String__ReadLine_Format_16.cs
Label Definition File: CWE134_Externally_Controlled_Format_String.label.xml
Template File: sources-sinks-16.tmpl.cs
*/
/*
* @description
* CWE: 134 Externally Controlled Format String
* BadSource: ReadLine Read data from the console using ReadLine()
* GoodSource: A hardcoded string
* Sinks: Format
*    GoodSink: console write formatted using string.Format
*    BadSink : console write formatted without validation
* Flow Variant: 16 Control flow: while(true)
*
* */

using TestCaseSupport;
using System;

using System.IO;

namespace testcases.CWE134_Externally_Controlled_Format_String
{
class CWE134_Externally_Controlled_Format_String__ReadLine_Format_16 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        string data;
        while (true)
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
            break;
        }
        while (true)
        {
            if (data != null)
            {
                /* POTENTIAL FLAW: uncontrolled string formatting */
                Console.Write(string.Format(data));
            }
            break;
        }
    }
#endif //omitbad

}
}
