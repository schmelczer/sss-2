/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE613_Insufficient_Session_Expiration__Web_11.cs
Label Definition File: CWE613_Insufficient_Session_Expiration__Web.label.xml
Template File: point-flaw-11.tmpl.cs
*/
/*
* @description
* CWE: 613 Insufficient Session Expiration
* Sinks:
*    GoodSink: force session to expire
*    BadSink : set session to never expire
* Flow Variant: 11 Control flow: if(IO.StaticReturnsTrue()) and if(IO.StaticReturnsFalse())
*
* */

using TestCaseSupport;
using System;

using System.Web;
using System.Web.SessionState;

namespace testcases.CWE613_Insufficient_Session_Expiration
{
class CWE613_Insufficient_Session_Expiration__Web_11 : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        if (IO.StaticReturnsTrue())
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
