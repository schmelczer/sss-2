/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE113_HTTP_Response_Splitting__Web_Connect_tcp_addCookie_10.cs
Label Definition File: CWE113_HTTP_Response_Splitting__Web.label.xml
Template File: sources-sinks-10.tmpl.cs
*/
/*
* @description
* CWE: 113 HTTP Response Splitting
* BadSource: Connect_tcp Read data using an outbound tcp connection
* GoodSource: A hardcoded string
* Sinks: addCookie
*    GoodSink: URLEncode input
*    BadSink : querystring to AppendCookie()
* Flow Variant: 10 Control flow: if(IO.staticTrue) and if(IO.staticFalse)
*
* */

using TestCaseSupport;
using System;

using System.Web;
using System.Text;

using System.IO;
using System.Net.Sockets;

namespace testcases.CWE113_HTTP_Response_Splitting
{
class CWE113_HTTP_Response_Splitting__Web_Connect_tcp_addCookie_10 : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        if (IO.staticTrue)
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
        if (IO.staticTrue)
        {
            if (data != null)
            {
                HttpCookie cookieSink = new HttpCookie("lang", data);
                /* POTENTIAL FLAW: Input not verified before inclusion in the cookie */
                resp.AppendCookie(cookieSink);
            }
        }
    }
#endif //omitbad

}
}
