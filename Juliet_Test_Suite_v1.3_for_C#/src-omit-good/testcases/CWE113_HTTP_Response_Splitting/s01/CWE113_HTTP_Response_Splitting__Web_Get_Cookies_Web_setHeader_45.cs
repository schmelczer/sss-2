/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE113_HTTP_Response_Splitting__Web_Get_Cookies_Web_setHeader_45.cs
Label Definition File: CWE113_HTTP_Response_Splitting__Web.label.xml
Template File: sources-sinks-45.tmpl.cs
*/
/*
 * @description
 * CWE: 113 HTTP Response Splitting
 * BadSource: Get_Cookies_Web Read data from the first cookie using Cookies
 * GoodSource: A hardcoded string
 * Sinks: setHeader
 *    GoodSink: URLEncode input
 *    BadSink : querystring to AddHeader()
 * Flow Variant: 45 Data flow: data passed as a private class member variable from one function to another in the same class
 *
 * */

using TestCaseSupport;
using System;

using System.Web;
using System.Text;


namespace testcases.CWE113_HTTP_Response_Splitting
{
class CWE113_HTTP_Response_Splitting__Web_Get_Cookies_Web_setHeader_45 : AbstractTestCaseWeb
{

    private string dataBad;
    private string dataGoodG2B;
    private string dataGoodB2G;
#if (!OMITBAD)
    private void BadSink(HttpRequest req, HttpResponse resp)
    {
        string data = dataBad;
        if (data != null)
        {
            /* POTENTIAL FLAW: Input not verified before inclusion in header */
            resp.AddHeader("Location", "/author.jsp?lang=" + data);
        }
    }

    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        data = ""; /* initialize data in case there are no cookies */
        /* Read data from cookies */
        {
            HttpCookieCollection cookieSources = req.Cookies;
            if (cookieSources != null)
            {
                /* POTENTIAL FLAW: Read data from the first cookie value */
                data = cookieSources[0].Value;
            }
        }
        dataBad = data;
        BadSink(req, resp);
    }
#endif //omitbad

}
}
