/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE601_Open_Redirect__Web_Connect_tcp_81a.cs
Label Definition File: CWE601_Open_Redirect__Web.label.xml
Template File: sources-sink-81a.tmpl.cs
*/
/*
 * @description
 * CWE: 601 Open Redirect
 * BadSource: Connect_tcp Read data using an outbound tcp connection
 * GoodSource: A hardcoded string
 * Sinks:
 *    BadSink : place redirect string directly into redirect api call
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

using System.IO;
using System.Net.Sockets;

namespace testcases.CWE601_Open_Redirect
{

class CWE601_Open_Redirect__Web_Connect_tcp_81a : AbstractTestCaseWeb
{

#if (!OMITGOOD)
    public override void Good(HttpRequest req, HttpResponse resp)
    {
        GoodG2B(req, resp);
    }

    /* goodG2B() - use goodsource and badsink */
    private void GoodG2B(HttpRequest req, HttpResponse resp)
    {
        string data;
        /* FIX: Use a hardcoded string */
        data = "foo";
        CWE601_Open_Redirect__Web_Connect_tcp_81_base baseObject = new CWE601_Open_Redirect__Web_Connect_tcp_81_goodG2B();
        baseObject.Action(data , req, resp);
    }
#endif //omitgood
}
}
