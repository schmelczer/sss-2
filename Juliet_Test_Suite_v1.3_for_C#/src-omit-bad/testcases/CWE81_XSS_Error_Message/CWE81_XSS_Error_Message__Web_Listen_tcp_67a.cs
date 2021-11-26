/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE81_XSS_Error_Message__Web_Listen_tcp_67a.cs
Label Definition File: CWE81_XSS_Error_Message__Web.label.xml
Template File: sources-sink-67a.tmpl.cs
*/
/*
 * @description
 * CWE: 81 Cross Site Scripting (XSS) in Error Message
 * BadSource: Listen_tcp Read data using a listening tcp connection
 * GoodSource: A hardcoded string
 * Sinks: ErrorStatusCode
 *    BadSink : XSS in StatusCode
 * Flow Variant: 67 Data flow: data passed in a class from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

using System.IO;
using System.Net.Sockets;
using System.Net;

namespace testcases.CWE81_XSS_Error_Message
{

class CWE81_XSS_Error_Message__Web_Listen_tcp_67a : AbstractTestCaseWeb
{

    public class Container
    {
        public string containerOne;
    }

#if (!OMITGOOD)
    public override void Good(HttpRequest req, HttpResponse resp)
    {
        GoodG2B(req, resp);
    }

    /* goodG2B() - use goodsource and badsink */
    private static void GoodG2B(HttpRequest req, HttpResponse resp)
    {
        string data;
        /* FIX: Use a hardcoded string */
        data = "foo";
        Container dataContainer = new Container();
        dataContainer.containerOne = data;
        CWE81_XSS_Error_Message__Web_Listen_tcp_67b.GoodG2BSink(dataContainer , req, resp );
    }
#endif //omitgood
}
}
