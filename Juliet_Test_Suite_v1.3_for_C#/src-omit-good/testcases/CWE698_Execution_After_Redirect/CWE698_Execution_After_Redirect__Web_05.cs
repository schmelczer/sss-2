/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE698_Execution_After_Redirect__Web_05.cs
Label Definition File: CWE698_Execution_After_Redirect__Web.label.xml
Template File: point-flaw-05.tmpl.cs
*/
/*
* @description
* CWE: 698 Execution After Redirect (EAR)
* Sinks:
*    GoodSink: return after redirect
*    BadSink : perform actions after redirect
* Flow Variant: 05 Control flow: if(privateTrue) and if(privateFalse)
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE698_Execution_After_Redirect
{
class CWE698_Execution_After_Redirect__Web_05 : AbstractTestCaseWeb
{
    /* The two variables below are not defined as "readonly", but are never
     * assigned any other value, so a tool should be able to identify that
     * reads of these will always return their initialized values.
     */
    private bool privateTrue = true;
    private bool privateFalse = false;
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        if (privateTrue)
        {
            resp.Redirect("/test");
            /* FLAW: code after the redirect is undefined */
            IO.WriteLine("doing some more things here after the redirect");
        }
    }
#endif //omitbad

}
}
