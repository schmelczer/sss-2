/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE698_Execution_After_Redirect__Web_06.cs
Label Definition File: CWE698_Execution_After_Redirect__Web.label.xml
Template File: point-flaw-06.tmpl.cs
*/
/*
* @description
* CWE: 698 Execution After Redirect (EAR)
* Sinks:
*    GoodSink: return after redirect
*    BadSink : perform actions after redirect
* Flow Variant: 06 Control flow: if(PRIVATE_CONST_FIVE==5) and if(PRIVATE_CONST_FIVE!=5)
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE698_Execution_After_Redirect
{
class CWE698_Execution_After_Redirect__Web_06 : AbstractTestCaseWeb
{
    /* The variable below is declared "const", so a tool should be able
     * to identify that reads of this will always give its initialized
     * value.
     */
    private const int PRIVATE_CONST_FIVE = 5;

#if (!OMITGOOD)
    /* Good1() changes PRIVATE_CONST_FIVE==5 to PRIVATE_CONST_FIVE!=5 */
    private void Good1(HttpRequest req, HttpResponse resp)
    {
        if (PRIVATE_CONST_FIVE != 5)
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
        }
        else
        {
            resp.Redirect("/test");
            /* FIX: no code after the redirect */
        }
    }

    /* Good2() reverses the bodies in the if statement */
    private void Good2(HttpRequest req, HttpResponse resp)
    {
        if (PRIVATE_CONST_FIVE == 5)
        {
            resp.Redirect("/test");
            /* FIX: no code after the redirect */
        }
    }

    public override void Good(HttpRequest req, HttpResponse resp)
    {
        Good1(req, resp);
        Good2(req, resp);
    }
#endif //omitgood
}
}
