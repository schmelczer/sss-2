/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE614_Sensitive_Cookie_Without_Secure__Web_13.cs
Label Definition File: CWE614_Sensitive_Cookie_Without_Secure__Web.label.xml
Template File: point-flaw-13.tmpl.cs
*/
/*
* @description
* CWE: 614 Sensitive Cookie Without Secure
* Sinks:
*    GoodSink: secure flag set
*    BadSink : secure flag not set
* Flow Variant: 13 Control flow: if(IO.STATIC_READONLY_FIVE==5) and if(IO.STATIC_READONLY_FIVE!=5)
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE614_Sensitive_Cookie_Without_Secure
{
class CWE614_Sensitive_Cookie_Without_Secure__Web_13 : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        if (IO.STATIC_READONLY_FIVE == 5)
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

}
}
