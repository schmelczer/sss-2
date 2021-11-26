/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE539_Information_Exposure_Through_Persistent_Cookie__Web_04.cs
Label Definition File: CWE539_Information_Exposure_Through_Persistent_Cookie__Web.label.xml
Template File: point-flaw-04.tmpl.cs
*/
/*
* @description
* CWE: 539 Information Exposure Through Persistent Cookie
* Sinks:
*    GoodSink: Do not use a persistent cookie
*    BadSink : Use a persistent cookie
* Flow Variant: 04 Control flow: if(PRIVATE_CONST_TRUE) and if(PRIVATE_CONST_FALSE)
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE539_Information_Exposure_Through_Persistent_Cookie
{
class CWE539_Information_Exposure_Through_Persistent_Cookie__Web_04 : AbstractTestCaseWeb
{
    /* The two variables below are declared "const", so a tool should
     * be able to identify that reads of these will always return their
     * initialized values.
     */
    private const bool PRIVATE_CONST_TRUE = true;
    private const bool PRIVATE_CONST_FALSE = false;
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        if (PRIVATE_CONST_TRUE)
        {
            HttpCookie cookie = new HttpCookie("SecretMessage", "test");
            /* FLAW: Make the cookie persistent, by setting the expiration to 5 years */
            cookie.Expires = DateTime.Now.AddDays(1825.00);
        }
    }
#endif //omitbad

}
}
