/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE614_Sensitive_Cookie_Without_Secure__Web_02.cs
Label Definition File: CWE614_Sensitive_Cookie_Without_Secure__Web.label.xml
Template File: point-flaw-02.tmpl.cs
*/
/*
* @description
* CWE: 614 Sensitive Cookie Without Secure
* Sinks:
*    GoodSink: secure flag set
*    BadSink : secure flag not set
* Flow Variant: 02 Control flow: if(true) and if(false)
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE614_Sensitive_Cookie_Without_Secure
{
class CWE614_Sensitive_Cookie_Without_Secure__Web_02 : AbstractTestCaseWeb
{

#if (!OMITGOOD)
    /* Good1() changes true to false */
    private void Good1(HttpRequest req, HttpResponse resp)
    {
        if (false)
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
        if (true)
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
