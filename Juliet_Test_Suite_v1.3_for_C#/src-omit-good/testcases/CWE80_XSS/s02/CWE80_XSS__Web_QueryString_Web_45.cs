/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE80_XSS__Web_QueryString_Web_45.cs
Label Definition File: CWE80_XSS__Web.label.xml
Template File: sources-sink-45.tmpl.cs
*/
/*
 * @description
 * CWE: 80 Cross Site Scripting (XSS)
 * BadSource: QueryString_Web Parse id param out of the URL query string (without using getParameter())
 * GoodSource: A hardcoded string
 * Sinks: Web
 *    BadSink : Display of data in web page without any encoding or validation
 * Flow Variant: 45 Data flow: data passed as a private class member variable from one function to another in the same class
 *
 * */

using TestCaseSupport;
using System;

using System.Web;


namespace testcases.CWE80_XSS
{

class CWE80_XSS__Web_QueryString_Web_45 : AbstractTestCaseWeb
{

    private string dataBad;
    private string dataGoodG2B;
#if (!OMITBAD)
    private void BadSink(HttpRequest req, HttpResponse resp)
    {
        string data = dataBad;
        if (data != null)
        {
            /* POTENTIAL FLAW: Display of data in web page without any encoding or validation */
            resp.Write("<br>Bad(): data = " + data);
        }
    }

    /* uses badsource and badsink */
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        data = ""; /* initialize data in case id is not in query string */
        /* POTENTIAL FLAW: Parse id param out of the URL querystring (without using getParameter()) */
        {
            if (req.QueryString["id"] != null)
            {
                data = req.QueryString["id"];
            }
        }
        dataBad = data;
        BadSink(req, resp);
    }
#endif //omitbad

}
}
