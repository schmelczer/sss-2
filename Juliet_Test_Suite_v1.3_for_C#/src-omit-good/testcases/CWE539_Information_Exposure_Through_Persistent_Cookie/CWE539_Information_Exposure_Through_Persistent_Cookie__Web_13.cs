/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE539_Information_Exposure_Through_Persistent_Cookie__Web_13.cs
Label Definition File: CWE539_Information_Exposure_Through_Persistent_Cookie__Web.label.xml
Template File: point-flaw-13.tmpl.cs
*/
/*
* @description
* CWE: 539 Information Exposure Through Persistent Cookie
* Sinks:
*    GoodSink: Do not use a persistent cookie
*    BadSink : Use a persistent cookie
* Flow Variant: 13 Control flow: if(IO.STATIC_READONLY_FIVE==5) and if(IO.STATIC_READONLY_FIVE!=5)
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE539_Information_Exposure_Through_Persistent_Cookie
{
class CWE539_Information_Exposure_Through_Persistent_Cookie__Web_13 : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        if (IO.STATIC_READONLY_FIVE == 5)
        {
            HttpCookie cookie = new HttpCookie("SecretMessage", "test");
            /* FLAW: Make the cookie persistent, by setting the expiration to 5 years */
            cookie.Expires = DateTime.Now.AddDays(1825.00);
        }
    }
#endif //omitbad

}
}
