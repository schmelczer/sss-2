/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE117_Improper_Output_Neutralization_for_Logs__NetClient_66a.cs
Label Definition File: CWE117_Improper_Output_Neutralization_for_Logs.label.xml
Template File: sources-sinks-66a.tmpl.cs
*/
/*
 * @description
 * CWE: 117 Improper Output Neutralization for Logs
 * BadSource: NetClient Read data from a web server with WebClient
 * GoodSource: A hardcoded string
 * Sinks: readFile
 *    GoodSink: Logging output is neutralized
 *    BadSink : Logging output is not neutralized
 * Flow Variant: 66 Data flow: data passed in an array from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

using System.IO;
using System.Net;

namespace testcases.CWE117_Improper_Output_Neutralization_for_Logs
{
class CWE117_Improper_Output_Neutralization_for_Logs__NetClient_66a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        string data;
        data = ""; /* Initialize data */
        /* read input from WebClient */
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    using (StreamReader sr = new StreamReader(client.OpenRead("http://www.example.org/")))
                    {
                        /* POTENTIAL FLAW: Read data from a web server with WebClient */
                        /* This will be reading the first "line" of the response body,
                        * which could be very long if there are no newlines in the HTML */
                        data = sr.ReadLine();
                    }
                }
            }
            catch (IOException exceptIO)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error with stream reading");
            }
        }
        string[] dataArray = new string[5];
        dataArray[2] = data;
        CWE117_Improper_Output_Neutralization_for_Logs__NetClient_66b.BadSink(dataArray  );
    }
#endif //omitbad

}
}
