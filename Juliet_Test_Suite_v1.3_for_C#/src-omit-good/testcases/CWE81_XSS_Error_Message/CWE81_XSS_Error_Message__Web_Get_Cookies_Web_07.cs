/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE81_XSS_Error_Message__Web_Get_Cookies_Web_07.cs
Label Definition File: CWE81_XSS_Error_Message__Web.label.xml
Template File: sources-sink-07.tmpl.cs
*/
/*
* @description
* CWE: 81 Cross Site Scripting (XSS) in Error Message
* BadSource: Get_Cookies_Web Read data from the first cookie using Cookies
* GoodSource: A hardcoded string
* BadSink: ErrorStatusCode XSS in StatusCode
* Flow Variant: 07 Control flow: if(privateFive==5) and if(privateFive!=5)
*
* */

using TestCaseSupport;
using System;

using System.Web;


namespace testcases.CWE81_XSS_Error_Message
{

class CWE81_XSS_Error_Message__Web_Get_Cookies_Web_07 : AbstractTestCaseWeb
{

    /* The variable below is not declared "readonly", but is never assigned
     * any other value so a tool should be able to identify that reads of
     * this will always give its initialized value.
     */
    private int privateFive = 5;
#if (!OMITBAD)
    /* uses badsource and badsink */
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        if (privateFive == 5)
        {
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
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
        }
        if (data != null)
        {
            /* POTENTIAL FLAW: script code (e.g. id=<script>alert('xss')</script>) is sent to the client; */
            resp.StatusCode = 404;
            resp.StatusDescription = "<br>Bad() - Parameter name has value " + data;
        }
    }
#endif //omitbad

}
}
