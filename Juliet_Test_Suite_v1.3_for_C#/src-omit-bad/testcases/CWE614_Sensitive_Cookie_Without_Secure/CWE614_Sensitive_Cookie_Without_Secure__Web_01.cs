/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE614_Sensitive_Cookie_Without_Secure__Web_01.cs
Label Definition File: CWE614_Sensitive_Cookie_Without_Secure__Web.label.xml
Template File: point-flaw-01.tmpl.cs
*/
/*
* @description
* CWE: 614 Sensitive Cookie Without Secure
* Sinks:
*    GoodSink: secure flag set
*    BadSink : secure flag not set
* Flow Variant: 01 Baseline
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE614_Sensitive_Cookie_Without_Secure
{
class CWE614_Sensitive_Cookie_Without_Secure__Web_01 : AbstractTestCaseWeb
{

#if (!OMITGOOD)
    public override void Good(HttpRequest req, HttpResponse resp)
    {
        Good1(req, resp);
    }

    private void Good1(HttpRequest req, HttpResponse resp)
    {
        HttpCookie cookie = new HttpCookie("SecretMessage", "Drink your Ovaltine");
        if (req.IsSecureConnection)
        {
            /* FIX: adds "secure" flag/attribute to cookie */
            cookie.Secure = true;
            resp.Cookies.Add(cookie);
        }
    }
#endif //omitgood
}
}
