/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE113_HTTP_Response_Splitting__Web_Params_Get_Web_addHeader_12.cs
Label Definition File: CWE113_HTTP_Response_Splitting__Web.label.xml
Template File: sources-sinks-12.tmpl.cs
*/
/*
* @description
* CWE: 113 HTTP Response Splitting
* BadSource: Params_Get_Web Read data from a querystring using Params.Get()
* GoodSource: A hardcoded string
* Sinks: addHeader
*    GoodSink: URLEncode input
*    BadSink : querystring to AddHeader()
* Flow Variant: 12 Control flow: if(IO.StaticReturnsTrueOrFalse())
*
* */

using TestCaseSupport;
using System;

using System.Web;
using System.Text;


namespace testcases.CWE113_HTTP_Response_Splitting
{
class CWE113_HTTP_Response_Splitting__Web_Params_Get_Web_addHeader_12 : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        if(IO.StaticReturnsTrueOrFalse())
        {
            /* POTENTIAL FLAW: Read data from a querystring using Params.Get */
            data = req.Params.Get("name");
        }
        else
        {
            /* FIX: Use a hardcoded string */
            data = "foo";
        }
        if(IO.StaticReturnsTrueOrFalse())
        {
            /* POTENTIAL FLAW: Input from file not verified */
            if (data != null)
            {
                resp.AddHeader("Location", "/author.jsp?lang=" + data);
            }
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
#endif //omitbad

}
}
