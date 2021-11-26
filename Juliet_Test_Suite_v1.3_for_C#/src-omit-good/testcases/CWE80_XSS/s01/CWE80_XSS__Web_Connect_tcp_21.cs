/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE80_XSS__Web_Connect_tcp_21.cs
Label Definition File: CWE80_XSS__Web.label.xml
Template File: sources-sink-21.tmpl.cs
*/
/*
 * @description
 * CWE: 80 Cross Site Scripting (XSS)
 * BadSource: Connect_tcp Read data using an outbound tcp connection
 * GoodSource: A hardcoded string
 * Sinks: Web
 *    BadSink : Display of data in web page without any encoding or validation
 * Flow Variant: 21 Control flow: Flow controlled by value of a private variable. All functions contained in one file.
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

using System.IO;
using System.Net.Sockets;

namespace testcases.CWE80_XSS
{

class CWE80_XSS__Web_Connect_tcp_21 : AbstractTestCaseWeb
{

    /* The variable below is used to drive control flow in the source function */
    private bool badPrivate = false;
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        badPrivate = true;
        data = Bad_source(req, resp);
        if (data != null)
        {
            /* POTENTIAL FLAW: Display of data in web page without any encoding or validation */
            resp.Write("<br>Bad(): data = " + data);
        }
    }

    private string Bad_source(HttpRequest req, HttpResponse resp)
    {
        string data;
        if (badPrivate)
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
#endif //omitbad
    /* The variables below are used to drive control flow in the source functions. */
    private bool goodG2B1_private = false;
    private bool GoodG2B2_private = false;

}
}
