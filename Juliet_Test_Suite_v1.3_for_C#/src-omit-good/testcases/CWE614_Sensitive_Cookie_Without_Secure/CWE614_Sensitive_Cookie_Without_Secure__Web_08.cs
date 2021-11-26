/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE614_Sensitive_Cookie_Without_Secure__Web_08.cs
Label Definition File: CWE614_Sensitive_Cookie_Without_Secure__Web.label.xml
Template File: point-flaw-08.tmpl.cs
*/
/*
* @description
* CWE: 614 Sensitive Cookie Without Secure
* Sinks:
*    GoodSink: secure flag set
*    BadSink : secure flag not set
* Flow Variant: 08 Control flow: if(PrivateReturnsTrue()) and if(PrivateReturnsFalse())
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE614_Sensitive_Cookie_Without_Secure
{
class CWE614_Sensitive_Cookie_Without_Secure__Web_08 : AbstractTestCaseWeb
{
    /* The methods below always return the same value, so a tool
     * should be able to figure out that every call to these
     * methods will return true or return false.
     */
    private static bool PrivateReturnsTrue()
    {
        return true;
    }

    private static bool PrivateReturnsFalse()
    {
        return false;
    }
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        if (PrivateReturnsTrue())
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
