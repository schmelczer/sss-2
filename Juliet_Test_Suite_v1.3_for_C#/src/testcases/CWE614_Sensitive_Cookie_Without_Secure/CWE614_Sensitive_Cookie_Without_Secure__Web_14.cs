/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE614_Sensitive_Cookie_Without_Secure__Web_14.cs
Label Definition File: CWE614_Sensitive_Cookie_Without_Secure__Web.label.xml
Template File: point-flaw-14.tmpl.cs
*/
/*
* @description
* CWE: 614 Sensitive Cookie Without Secure
* Sinks:
*    GoodSink: secure flag set
*    BadSink : secure flag not set
* Flow Variant: 14 Control flow: if(IO.staticFive==5) and if(IO.staticFive!=5)
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE614_Sensitive_Cookie_Without_Secure
{
class CWE614_Sensitive_Cookie_Without_Secure__Web_14 : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        if (IO.staticFive == 5)
        {
            HttpCookie cookie = new HttpCookie("SecretMessage", "test");
            if (req.IsSecureConnection)
            {
                /* FLAW: secure flag not set */
                resp.Cookies.Add(cookie);
            }
        }
    }
#endif //omitbad
#if (!OMITGOOD)
    /* Good1() changes IO.staticFive==5 to IO.staticFive!=5 */
    private void Good1(HttpRequest req, HttpResponse resp)
    {
        if (IO.staticFive != 5)
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
        }
        else
        {
            HttpCookie cookie = new HttpCookie("SecretMessage", "Drink your Ovaltine");
            if (req.IsSecureConnection)
            {
                /* FIX: adds "secure" flag/attribute to cookie */
                cookie.Secure = true;
                resp.Cookies.Add(cookie);
            }
        }
    }

    /* Good2() reverses the bodies in the if statement */
    private void Good2(HttpRequest req, HttpResponse resp)
    {
        if (IO.staticFive == 5)
        {
            HttpCookie cookie = new HttpCookie("SecretMessage", "Drink your Ovaltine");
            if (req.IsSecureConnection)
            {
                /* FIX: adds "secure" flag/attribute to cookie */
                cookie.Secure = true;
                resp.Cookies.Add(cookie);
            }
        }
    }

    public override void Good(HttpRequest req, HttpResponse resp)
    {
        Good1(req, resp);
        Good2(req, resp);
    }
#endif //omitgood
}
}
