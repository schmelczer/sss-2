/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE549_Missing_Password_Masking__Web_03.cs
Label Definition File: CWE549_Missing_Password_Masking__Web.label.xml
Template File: point-flaw-03.tmpl.cs
*/
/*
* @description
* CWE: 549 Passwords should be masked during entry to prevent others from stealing them
* Sinks:
*    GoodSink: password field masked
*    BadSink : password field unmasked
* Flow Variant: 03 Control flow: if(5==5) and if(5!=5)
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE549_Missing_Password_Masking
{
class CWE549_Missing_Password_Masking__Web_03 : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        if (5 == 5)
        {
            resp.Write("<form id=\"form\" name=\"form\" method=\"post\" action=\"password-test-web\">");
            resp.Write("Username: <input name=\"username\" type=\"text\" tabindex=\"10\" /><br><br>");
            /* FLAW: password field should be masked (type="text") */
            resp.Write("Password: <input name=\"password\" type=\"text\" tabindex=\"10\" />");
            resp.Write("<input type=\"submit\" name=\"submit\" value=\"Login-bad\" /></form>");
        }
    }
#endif //omitbad

}
}