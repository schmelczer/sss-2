/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE90_LDAP_Injection__NetClient_22b.cs
Label Definition File: CWE90_LDAP_Injection.label.xml
Template File: sources-sink-22b.tmpl.cs
*/
/*
 * @description
 * CWE: 90 LDAP Injection
 * BadSource: NetClient Read data from a web server with WebClient
 * GoodSource: A hardcoded string
 * Sinks:
 *    BadSink : data concatenated into LDAP search, which could result in LDAP Injection
 * Flow Variant: 22 Control flow: Flow controlled by value of a public static variable. Sink functions are in a separate file from sources.
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

using System.IO;
using System.Net;

namespace testcases.CWE90_LDAP_Injection
{

class CWE90_LDAP_Injection__NetClient_22b
{
#if (!OMITBAD)
    public static string BadSource()
    {
        string data;
        if (CWE90_LDAP_Injection__NetClient_22a.badPublicStatic)
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
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
        }
        return data;
    }
#endif


}
}
