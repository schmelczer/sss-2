/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE83_XSS_Attribute__Web_QueryString_Web_11.cs
Label Definition File: CWE83_XSS_Attribute__Web.label.xml
Template File: sources-sink-11.tmpl.cs
*/
/*
* @description
* CWE: 83 Cross Site Scripting (XSS) in attributes; Examples(replace QUOTE with an actual double quote): ?img_loc=http://www.google.comQUOTE%20onerror=QUOTEalert(1) and ?img_loc=http://www.google.comQUOTE%20onerror=QUOTEjavascript:alert(1)
* BadSource: QueryString_Web Parse id param out of the URL query string (without using getParameter())
* GoodSource: A hardcoded string
* BadSink: Write XSS in img src attribute
* Flow Variant: 11 Control flow: if(IO.StaticReturnsTrue()) and if(IO.StaticReturnsFalse())
*
* */

using TestCaseSupport;
using System;

using System.Web;


namespace testcases.CWE83_XSS_Attribute
{

class CWE83_XSS_Attribute__Web_QueryString_Web_11 : AbstractTestCaseWeb
{

#if (!OMITGOOD)
    /* goodG2B1() - use goodsource and badsink by changing IO.StaticReturnsTrue() to IO.StaticReturnsFalse() */
    private void GoodG2B1(HttpRequest req, HttpResponse resp)
    {
        string data;
        if (IO.StaticReturnsFalse())
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
        }
        else
        {
            /* FIX: Use a hardcoded string */
            data = "foo";
        }
        if (data != null)
        {
            /* POTENTIAL FLAW: Input is not verified/sanitized before use in an image tag */
            resp.Write("<br>Bad() - <img src=\"" + data +"\">");
        }
    }

    /* GoodG2B2() - use goodsource and badsink by reversing statements in if */
    private void GoodG2B2(HttpRequest req, HttpResponse resp)
    {
        string data;
        if (IO.StaticReturnsTrue())
        {
            /* FIX: Use a hardcoded string */
            data = "foo";
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
        }
        if (data != null)
        {
            /* POTENTIAL FLAW: Input is not verified/sanitized before use in an image tag */
            resp.Write("<br>Bad() - <img src=\"" + data +"\">");
        }
    }

    public override void Good(HttpRequest req, HttpResponse resp)
    {
        GoodG2B1(req, resp);
        GoodG2B2(req, resp);
    }
#endif //omitgood
}
}