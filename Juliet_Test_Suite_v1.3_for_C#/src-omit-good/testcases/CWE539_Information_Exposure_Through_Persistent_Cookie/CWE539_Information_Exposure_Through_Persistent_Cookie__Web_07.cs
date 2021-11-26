/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE539_Information_Exposure_Through_Persistent_Cookie__Web_07.cs
Label Definition File: CWE539_Information_Exposure_Through_Persistent_Cookie__Web.label.xml
Template File: point-flaw-07.tmpl.cs
*/
/*
* @description
* CWE: 539 Information Exposure Through Persistent Cookie
* Sinks:
*    GoodSink: Do not use a persistent cookie
*    BadSink : Use a persistent cookie
* Flow Variant: 07 Control flow: if(privateFive==5) and if(privateFive!=5)
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE539_Information_Exposure_Through_Persistent_Cookie
{
class CWE539_Information_Exposure_Through_Persistent_Cookie__Web_07 : AbstractTestCaseWeb
{
    /* The variable below is not declared "readonly", but is never assigned
     * any other value so a tool should be able to identify that reads of
     * this will always give its initialized value.
     */
    private int privateFive = 5;
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        if (privateFive == 5)
        {
            HttpCookie cookie = new HttpCookie("SecretMessage", "test");
            /* FLAW: Make the cookie persistent, by setting the expiration to 5 years */
            cookie.Expires = DateTime.Now.AddDays(1825.00);
        }
    }
#endif //omitbad

}
}
