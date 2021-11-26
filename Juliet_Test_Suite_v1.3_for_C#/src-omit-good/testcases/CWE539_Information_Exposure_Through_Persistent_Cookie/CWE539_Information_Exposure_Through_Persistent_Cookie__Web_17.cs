/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE539_Information_Exposure_Through_Persistent_Cookie__Web_17.cs
Label Definition File: CWE539_Information_Exposure_Through_Persistent_Cookie__Web.label.xml
Template File: point-flaw-17.tmpl.cs
*/
/*
* @description
* CWE: 539 Information Exposure Through Persistent Cookie
* Sinks:
*    GoodSink: Do not use a persistent cookie
*    BadSink : Use a persistent cookie
* Flow Variant: 17 Control flow: for loops
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE539_Information_Exposure_Through_Persistent_Cookie
{
class CWE539_Information_Exposure_Through_Persistent_Cookie__Web_17 : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        for(int j = 0; j < 1; j++)
        {
            HttpCookie cookie = new HttpCookie("SecretMessage", "test");
            /* FLAW: Make the cookie persistent, by setting the expiration to 5 years */
            cookie.Expires = DateTime.Now.AddDays(1825.00);
        }
    }
#endif //omitbad

}
}
