/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE83_XSS_Attribute__Web_NetClient_01.cs
Label Definition File: CWE83_XSS_Attribute__Web.label.xml
Template File: sources-sink-01.tmpl.cs
*/
/*
* @description
* CWE: 83 Cross Site Scripting (XSS) in attributes; Examples(replace QUOTE with an actual double quote): ?img_loc=http://www.google.comQUOTE%20onerror=QUOTEalert(1) and ?img_loc=http://www.google.comQUOTE%20onerror=QUOTEjavascript:alert(1)
* BadSource: NetClient Read data from a web server with WebClient
* GoodSource: A hardcoded string
* BadSink: Write XSS in img src attribute
* Flow Variant: 01 Baseline
*
* */

using TestCaseSupport;
using System;

using System.Web;

using System.IO;
using System.Net;

namespace testcases.CWE83_XSS_Attribute
{

class CWE83_XSS_Attribute__Web_NetClient_01 : AbstractTestCaseWeb
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
            /* POTENTIAL FLAW: Input is not verified/sanitized before use in an image tag */
            resp.Write("<br>Bad() - <img src=\"" + data +"\">");
        }
    }
#endif //omitgood
}
}
