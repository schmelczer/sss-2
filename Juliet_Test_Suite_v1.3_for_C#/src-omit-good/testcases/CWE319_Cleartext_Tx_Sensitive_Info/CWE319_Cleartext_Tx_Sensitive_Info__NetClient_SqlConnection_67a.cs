/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE319_Cleartext_Tx_Sensitive_Info__NetClient_SqlConnection_67a.cs
Label Definition File: CWE319_Cleartext_Tx_Sensitive_Info.label.xml
Template File: sources-sinks-67a.tmpl.cs
*/
/*
 * @description
 * CWE: 319 Cleartext Transmission of Sensitive Information
 * BadSource: NetClient Read password from a web server with WebClient
 * GoodSource: Set password to a hardcoded value (one that was not sent over the network)
 * Sinks: SqlConnection
 *    GoodSink: Decrypt the password from the source before using it in database connection
 *    BadSink : Use password directly from source in database connection
 * Flow Variant: 67 Data flow: data passed in a class from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.IO;
using System.Net;

namespace testcases.CWE319_Cleartext_Tx_Sensitive_Info
{
class CWE319_Cleartext_Tx_Sensitive_Info__NetClient_SqlConnection_67a : AbstractTestCase
{

    public class Container
    {
        public string containerOne;
    }
#if (!OMITBAD)
    public override void Bad()
    {
        string password;
        password = ""; /* init password */
        /* read input from WebClient */
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    using (StreamReader sr = new StreamReader(client.OpenRead("http://www.example.org/")))
                    {
                        /* POTENTIAL FLAW: Read password from a web server with WebClient */
                        /* This will be reading the first "line" of the response body,
                         * which could be very long if there are no newlines in the HTML */
                        password = sr.ReadLine();
                    }
                }
            }
            catch (IOException exceptIO)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, "Error with stream reading", exceptIO);
            }
        }
        Container passwordContainer = new Container();
        passwordContainer.containerOne = password;
        CWE319_Cleartext_Tx_Sensitive_Info__NetClient_SqlConnection_67b.BadSink(passwordContainer  );
    }
#endif //omitbad

}
}
