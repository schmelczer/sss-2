/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE606_Unchecked_Loop_Condition__NetClient_68a.cs
Label Definition File: CWE606_Unchecked_Loop_Condition.label.xml
Template File: sources-sinks-68a.tmpl.cs
*/
/*
 * @description
 * CWE: 606 Unchecked Input for Loop Condition
 * BadSource: NetClient Read data from a web server with WebClient
 * GoodSource: hardcoded int in string form
 * Sinks:
 *    GoodSink: validate loop variable
 *    BadSink : loop variable not validated
 * Flow Variant: 68 Data flow: data passed as a member variable in the "a" class, which is used by a method in another class in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.IO;
using System.Net;

namespace testcases.CWE606_Unchecked_Loop_Condition
{
class CWE606_Unchecked_Loop_Condition__NetClient_68a : AbstractTestCase
{

    public static string data;
#if (!OMITBAD)
    public override void Bad()
    {
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
        CWE606_Unchecked_Loop_Condition__NetClient_68b.BadSink();
    }
#endif //omitbad

}
}
