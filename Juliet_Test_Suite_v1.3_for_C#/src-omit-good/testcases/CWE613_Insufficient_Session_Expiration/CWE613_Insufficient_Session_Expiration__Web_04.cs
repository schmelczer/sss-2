/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE613_Insufficient_Session_Expiration__Web_04.cs
Label Definition File: CWE613_Insufficient_Session_Expiration__Web.label.xml
Template File: point-flaw-04.tmpl.cs
*/
/*
* @description
* CWE: 613 Insufficient Session Expiration
* Sinks:
*    GoodSink: force session to expire
*    BadSink : set session to never expire
* Flow Variant: 04 Control flow: if(PRIVATE_CONST_TRUE) and if(PRIVATE_CONST_FALSE)
*
* */

using TestCaseSupport;
using System;

using System.Web;
using System.Web.SessionState;

namespace testcases.CWE613_Insufficient_Session_Expiration
{
class CWE613_Insufficient_Session_Expiration__Web_04 : AbstractTestCaseWeb
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
            HttpContext ctx = HttpContext.Current;
            HttpSessionState session = ctx.Session;
            /* FLAW: A negative time indicates the session should never expire */
            session.Timeout = -1;
            resp.Write("Bad(): Session still valid");
        }
    }
#endif //omitbad

}
}
