/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE81_XSS_Error_Message__Web_Database_01.cs
Label Definition File: CWE81_XSS_Error_Message__Web.label.xml
Template File: sources-sink-01.tmpl.cs
*/
/*
* @description
* CWE: 81 Cross Site Scripting (XSS) in Error Message
* BadSource: Database Read data from a database
* GoodSource: A hardcoded string
* BadSink: ErrorStatusCode XSS in StatusCode
* Flow Variant: 01 Baseline
*
* */

using TestCaseSupport;
using System;

using System.Web;

using System.Data.SqlClient;

namespace testcases.CWE81_XSS_Error_Message
{

class CWE81_XSS_Error_Message__Web_Database_01 : AbstractTestCaseWeb
{

#if (!OMITGOOD)
    public override void Good(HttpRequest req, HttpResponse resp)
    {
        GoodG2B(req, resp);
    }

    /* goodG2B() - uses goodsource and badsink */
    private void GoodG2B(HttpRequest req, HttpResponse resp)
    {
        string data;
        /* FIX: Use a hardcoded string */
        data = "foo";
        if (data != null)
        {
            /* POTENTIAL FLAW: script code (e.g. id=<script>alert('xss')</script>) is sent to the client; */
            resp.StatusCode = 404;
            resp.StatusDescription = "<br>Bad() - Parameter name has value " + data;
        }
    }
#endif //omitgood
}
}