/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE698_Execution_After_Redirect__Web_14.cs
Label Definition File: CWE698_Execution_After_Redirect__Web.label.xml
Template File: point-flaw-14.tmpl.cs
*/
/*
* @description
* CWE: 698 Execution After Redirect (EAR)
* Sinks:
*    GoodSink: return after redirect
*    BadSink : perform actions after redirect
* Flow Variant: 14 Control flow: if(IO.staticFive==5) and if(IO.staticFive!=5)
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE698_Execution_After_Redirect
{
class CWE698_Execution_After_Redirect__Web_14 : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        if (IO.staticFive == 5)
        {
            resp.Redirect("/test");
            /* FLAW: code after the redirect is undefined */
            IO.WriteLine("doing some more things here after the redirect");
        }
    }
#endif //omitbad

}
}
