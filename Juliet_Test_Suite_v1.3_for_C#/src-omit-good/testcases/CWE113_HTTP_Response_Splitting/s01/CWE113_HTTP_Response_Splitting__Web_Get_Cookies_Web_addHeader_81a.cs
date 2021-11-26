/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE113_HTTP_Response_Splitting__Web_Get_Cookies_Web_addHeader_81a.cs
Label Definition File: CWE113_HTTP_Response_Splitting__Web.label.xml
Template File: sources-sinks-81a.tmpl.cs
*/
/*
 * @description
 * CWE: 113 HTTP Response Splitting
 * BadSource: Get_Cookies_Web Read data from the first cookie using Cookies
 * GoodSource: A hardcoded string
 * Sinks: addHeader
 *    GoodSink: URLEncode input
 *    BadSink : querystring to AddHeader()
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */

using TestCaseSupport;
using System;

using System.Web;
using System.Text;


namespace testcases.CWE113_HTTP_Response_Splitting
{
class CWE113_HTTP_Response_Splitting__Web_Get_Cookies_Web_addHeader_81a : AbstractTestCaseWeb
{
#if (!OMITBAD)
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
        CWE113_HTTP_Response_Splitting__Web_Get_Cookies_Web_addHeader_81_base baseObject = new CWE113_HTTP_Response_Splitting__Web_Get_Cookies_Web_addHeader_81_bad();
        baseObject.Action(data , req, resp);
    }
#endif //omitbad

}
}
