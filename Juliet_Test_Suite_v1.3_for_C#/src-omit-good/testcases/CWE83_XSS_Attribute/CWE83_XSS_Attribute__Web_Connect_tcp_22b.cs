/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE83_XSS_Attribute__Web_Connect_tcp_22b.cs
Label Definition File: CWE83_XSS_Attribute__Web.label.xml
Template File: sources-sink-22b.tmpl.cs
*/
/*
 * @description
 * CWE: 83 Cross Site Scripting (XSS) in attributes; Examples(replace QUOTE with an actual double quote): ?img_loc=http://www.google.comQUOTE%20onerror=QUOTEalert(1) and ?img_loc=http://www.google.comQUOTE%20onerror=QUOTEjavascript:alert(1)
 * BadSource: Connect_tcp Read data using an outbound tcp connection
 * GoodSource: A hardcoded string
 * Sinks: Write
 *    BadSink : XSS in img src attribute
 * Flow Variant: 22 Control flow: Flow controlled by value of a public static variable. Sink functions are in a separate file from sources.
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

using System.IO;
using System.Net.Sockets;

namespace testcases.CWE83_XSS_Attribute
{

class CWE83_XSS_Attribute__Web_Connect_tcp_22b
{
#if (!OMITBAD)
    public static string BadSource(HttpRequest req, HttpResponse resp)
    {
        string data;
        if (CWE83_XSS_Attribute__Web_Connect_tcp_22a.badPublicStatic)
        {
            data = ""; /* Initialize data */
            /* Read data using an outbound tcp connection */
            {
                try
                {
                    /* Read data using an outbound tcp connection */
                    using (TcpClient tcpConn = new TcpClient("host.example.org", 39544))
                    {
                        /* read input from socket */
                        using (StreamReader sr = new StreamReader(tcpConn.GetStream()))
                        {
                            /* POTENTIAL FLAW: Read data using an outbound tcp connection */
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
