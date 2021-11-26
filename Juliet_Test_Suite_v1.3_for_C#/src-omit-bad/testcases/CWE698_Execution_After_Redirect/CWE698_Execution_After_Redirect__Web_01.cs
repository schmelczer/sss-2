/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE698_Execution_After_Redirect__Web_01.cs
Label Definition File: CWE698_Execution_After_Redirect__Web.label.xml
Template File: point-flaw-01.tmpl.cs
*/
/*
* @description
* CWE: 698 Execution After Redirect (EAR)
* Sinks:
*    GoodSink: return after redirect
*    BadSink : perform actions after redirect
* Flow Variant: 01 Baseline
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE698_Execution_After_Redirect
{
class CWE698_Execution_After_Redirect__Web_01 : AbstractTestCaseWeb
{

#if (!OMITGOOD)
    public override void Good(HttpRequest req, HttpResponse resp)
    {
        Good1(req, resp);
    }

    private void Good1(HttpRequest req, HttpResponse resp)
    {
        resp.Redirect("/test");
        /* FIX: no code after the redirect */
    }
#endif //omitgood
}
}
