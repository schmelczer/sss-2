/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE113_HTTP_Response_Splitting__Web_Params_Get_Web_addHeader_22a.cs
Label Definition File: CWE113_HTTP_Response_Splitting__Web.label.xml
Template File: sources-sinks-22a.tmpl.cs
*/
/*
 * @description
 * CWE: 113 HTTP Response Splitting
 * BadSource: Params_Get_Web Read data from a querystring using Params.Get()
 * GoodSource: A hardcoded string
 * Sinks: addHeader
 *    GoodSink: URLEncode input
 *    BadSink : querystring to AddHeader()
 * Flow Variant: 22 Control flow: Flow controlled by value of a public static variable. Sink functions are in a separate file from sources.
 *
 * */

using TestCaseSupport;
using System;

using System.Web;
using System.Text;


namespace testcases.CWE113_HTTP_Response_Splitting
{
class CWE113_HTTP_Response_Splitting__Web_Params_Get_Web_addHeader_22a : AbstractTestCaseWeb
{

    /* The public static variable below is used to drive control flow in the sink function. */
    public static bool badPublicStatic = false;

    /* The public static variables below are used to drive control flow in the sink functions. */
    public static bool goodB2G1PublicStatic = false;
    public static bool goodB2G2PublicStatic = false;
    public static bool goodG2BPublicStatic = false;
#if (!OMITGOOD)
    public override void Good(HttpRequest req, HttpResponse resp)
    {
        GoodB2G1(req, resp);
        GoodB2G2(req, resp);
        GoodG2B(req, resp);
    }

    /* goodB2G1() - use badsource and goodsink by setting the static variable to false instead of true */
    private void GoodB2G1(HttpRequest req, HttpResponse resp)
    {
        string data = null;
        /* POTENTIAL FLAW: Read data from a querystring using Params.Get */
        data = req.Params.Get("name");
        goodB2G1PublicStatic = false;
        CWE113_HTTP_Response_Splitting__Web_Params_Get_Web_addHeader_22b.GoodB2G1Sink(data , req, resp);
    }

    /* goodB2G2() - use badsource and goodsink by reversing the blocks in the if in the sink function */
    private void GoodB2G2(HttpRequest req, HttpResponse resp)
    {
        string data = null;
        /* POTENTIAL FLAW: Read data from a querystring using Params.Get */
        data = req.Params.Get("name");
        goodB2G2PublicStatic = true;
        CWE113_HTTP_Response_Splitting__Web_Params_Get_Web_addHeader_22b.GoodB2G2Sink(data , req, resp);
    }

    /* goodG2B() - use goodsource and badsink */
    private void GoodG2B(HttpRequest req, HttpResponse resp)
    {
        string data = null;
        /* FIX: Use a hardcoded string */
        data = "foo";
        goodG2BPublicStatic = true;
        CWE113_HTTP_Response_Splitting__Web_Params_Get_Web_addHeader_22b.GoodG2BSink(data , req, resp);
    }
#endif //omitgood
}
}
