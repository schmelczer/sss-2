/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE113_HTTP_Response_Splitting__Web_Listen_tcp_addCookie_01.cs
Label Definition File: CWE113_HTTP_Response_Splitting__Web.label.xml
Template File: sources-sinks-01.tmpl.cs
*/
/*
* @description
* CWE: 113 HTTP Response Splitting
* BadSource: Listen_tcp Read data using a listening tcp connection
* GoodSource: A hardcoded string
* Sinks: addCookie
*    GoodSink: URLEncode input
*    BadSink : querystring to AppendCookie()
* Flow Variant: 01 Baseline
*
* */

using TestCaseSupport;
using System;

using System.Web;
using System.Text;

using System.IO;
using System.Net.Sockets;
using System.Net;

namespace testcases.CWE113_HTTP_Response_Splitting
{
class CWE113_HTTP_Response_Splitting__Web_Listen_tcp_addCookie_01 : AbstractTestCaseWeb
{

#if (!OMITGOOD)
    public override void Good(HttpRequest req, HttpResponse resp)
    {
        GoodG2B(req, resp);
        GoodB2G(req, resp);
    }

    /* goodG2B() - use goodsource and badsink */
    private void GoodG2B(HttpRequest req, HttpResponse resp)
    {
        string data;
        /* FIX: Use a hardcoded string */
        data = "foo";
        if (data != null)
        {
            HttpCookie cookieSink = new HttpCookie("lang", data);
            /* POTENTIAL FLAW: Input not verified before inclusion in the cookie */
            resp.AppendCookie(cookieSink);
        }
    }

    /* goodB2G() - use badsource and goodsink */
    private void GoodB2G(HttpRequest req, HttpResponse resp)
    {
        string data;
        data = ""; /* Initialize data */
        /* Read data using a listening tcp connection */
        {
            TcpListener listener = null;
            try
            {
                listener = new TcpListener(IPAddress.Parse("10.10.1.10"), 39543);
                listener.Start();
                using (TcpClient tcpConn = listener.AcceptTcpClient())
                {
                    /* read input from socket */
                    using (StreamReader sr = new StreamReader(tcpConn.GetStream()))
                    {
                        /* POTENTIAL FLAW: Read data using a listening tcp connection */
                        data = sr.ReadLine();
                    }
                }
            }
            catch (IOException exceptIO)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error with stream reading");
            }
            finally
            {
                if (listener != null)
                {
                    try
                    {
                        listener.Stop();
                    }
                    catch(SocketException se)
                    {
                        IO.Logger.Log(NLog.LogLevel.Warn, se, "Error closing TcpListener");
                    }
                }
            }
        }
        if (data != null)
        {
            HttpCookie cookieSink = new HttpCookie("lang", HttpUtility.UrlEncode(data, Encoding.UTF8));
            /* FIX: use URLEncoder.encode to hex-encode non-alphanumerics */
            resp.AppendCookie(cookieSink);
        }
    }
#endif //omitgood
}
}
