/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE81_XSS_Error_Message__Web_Connect_tcp_12.cs
Label Definition File: CWE81_XSS_Error_Message__Web.label.xml
Template File: sources-sink-12.tmpl.cs
*/
/*
* @description
* CWE: 81 Cross Site Scripting (XSS) in Error Message
* BadSource: Connect_tcp Read data using an outbound tcp connection
* GoodSource: A hardcoded string
* BadSink: ErrorStatusCode XSS in StatusCode
* Flow Variant: 12 Control flow: if(IO.StaticReturnsTrueOrFalse())
*
* */

using TestCaseSupport;
using System;

using System.Web;

using System.IO;
using System.Net.Sockets;

namespace testcases.CWE81_XSS_Error_Message
{

class CWE81_XSS_Error_Message__Web_Connect_tcp_12 : AbstractTestCaseWeb
{

#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink by changing the "if" so that
     * both branches use the GoodSource */
    private void GoodG2B(HttpRequest req, HttpResponse resp)
    {
        string data;
        if (IO.StaticReturnsTrueOrFalse())
        {
            /* FIX: Use a hardcoded string */
            data = "foo";
        }
        else
        {
            /* FIX: Use a hardcoded string */
            data = "foo";
        }
        if (data != null)
        {
            /* POTENTIAL FLAW: script code (e.g. id=<script>alert('xss')</script>) is sent to the client; */
            resp.StatusCode = 404;
            resp.StatusDescription = "<br>Bad() - Parameter name has value " + data;
        }
    }

    public override void Good(HttpRequest req, HttpResponse resp)
    {
        GoodG2B(req, resp);
    }
#endif //omitgood
}
}
