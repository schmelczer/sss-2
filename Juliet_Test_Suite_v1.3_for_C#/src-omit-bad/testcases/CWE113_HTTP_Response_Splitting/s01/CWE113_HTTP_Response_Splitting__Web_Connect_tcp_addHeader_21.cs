/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE113_HTTP_Response_Splitting__Web_Connect_tcp_addHeader_21.cs
Label Definition File: CWE113_HTTP_Response_Splitting__Web.label.xml
Template File: sources-sinks-21.tmpl.cs
*/
/*
 * @description
 * CWE: 113 HTTP Response Splitting
 * BadSource: Connect_tcp Read data using an outbound tcp connection
 * GoodSource: A hardcoded string
 * Sinks: addHeader
 *    GoodSink: URLEncode input
 *    BadSink : querystring to AddHeader()
 * Flow Variant: 21 Control flow: Flow controlled by value of a private variable. All functions contained in one file.
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
class CWE113_HTTP_Response_Splitting__Web_Connect_tcp_addHeader_21 : AbstractTestCaseWeb
{

    /* The variable below is used to drive control flow in the sink function */
    private bool badPrivate = false;

    /* The variables below are used to drive control flow in the sink functions. */
    private bool goodB2G1Private = false;
    private bool goodB2G2Private = false;
    private bool goodG2BPrivate = false;
#if (!OMITGOOD)
    public override void Good(HttpRequest req, HttpResponse resp)
    {
        GoodB2G1(req, resp);
        GoodB2G2(req, resp);
        GoodG2B(req, resp);
    }

    /* goodB2G1() - use BadSource and GoodSink by setting the variable to false instead of true */
    private void GoodB2G1(HttpRequest req, HttpResponse resp)
    {
        string data;
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
        goodB2G1Private = false;
        GoodB2G1Sink(data , req, resp);
    }

    private void GoodB2G1Sink(string data , HttpRequest req, HttpResponse resp)
    {
        if (goodB2G1Private)
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
        }
        else
        {
            /* FIX: use URLEncoder.encode to hex-encode non-alphanumerics */
            if (data != null)
            {
                data = HttpUtility.UrlEncode("", Encoding.UTF8);
                resp.AddHeader("Location", "/author.jsp?lang=" + data);
            }
        }
    }

    /* goodB2G2() - use BadSource and GoodSink by reversing the blocks in the if in the sink function */
    private void GoodB2G2(HttpRequest req, HttpResponse resp)
    {
        string data;
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
        goodB2G2Private = true;
        GoodB2G2Sink(data , req, resp);
    }

    private void GoodB2G2Sink(string data , HttpRequest req, HttpResponse resp)
    {
        if (goodB2G2Private)
        {
            /* FIX: use URLEncoder.encode to hex-encode non-alphanumerics */
            if (data != null)
            {
                data = HttpUtility.UrlEncode("", Encoding.UTF8);
                resp.AddHeader("Location", "/author.jsp?lang=" + data);
            }
        }
    }

    /* goodG2B() - use GoodSource and BadSink */
    private void GoodG2B(HttpRequest req, HttpResponse resp)
    {
        string data;
        /* FIX: Use a hardcoded string */
        data = "foo";
        goodG2BPrivate = true;
        GoodG2BSink(data , req, resp);
    }

    private void GoodG2BSink(string data , HttpRequest req, HttpResponse resp)
    {
        if (goodG2BPrivate)
        {
            /* POTENTIAL FLAW: Input from file not verified */
            if (data != null)
            {
                resp.AddHeader("Location", "/author.jsp?lang=" + data);
            }
        }
    }
#endif //omitgood
}
}
