/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE80_XSS__Web_Get_Cookies_Web_15.cs
Label Definition File: CWE80_XSS__Web.label.xml
Template File: sources-sink-15.tmpl.cs
*/
/*
* @description
* CWE: 80 Cross Site Scripting (XSS)
* BadSource: Get_Cookies_Web Read data from the first cookie using Cookies
* GoodSource: A hardcoded string
* BadSink: Web Display of data in web page without any encoding or validation
* Flow Variant: 15 Control flow: switch(6)
*
* */

using TestCaseSupport;
using System;

using System.Web;


namespace testcases.CWE80_XSS
{

class CWE80_XSS__Web_Get_Cookies_Web_15 : AbstractTestCaseWeb
{
#if (!OMITBAD)
    /* uses badsource and badsink */
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data = null;
        switch (6)
        {
        case 6:
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
            break;
        default:
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
            break;
        }
        if (data != null)
        {
            /* POTENTIAL FLAW: Display of data in web page without any encoding or validation */
            resp.Write("<br>Bad(): data = " + data);
        }
    }
#endif //omitbad

}
}
