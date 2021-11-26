/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE598_Information_Exposure_QueryString__Web_10.cs
Label Definition File: CWE598_Information_Exposure_QueryString__Web.label.xml
Template File: point-flaw-10.tmpl.cs
*/
/*
* @description
* CWE: 598 Information Exposure Through Query Strings in GET Request
* Sinks:
*    GoodSink: post password field
*    BadSink : get password field
* Flow Variant: 10 Control flow: if(IO.staticTrue) and if(IO.staticFalse)
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE598_Information_Exposure_QueryString
{
class CWE598_Information_Exposure_QueryString__Web_10 : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        if (IO.staticTrue)
        {
            resp.Write("<form id=\"form\" name=\"form\" method=\"get\" action=\"password-test-web\">"); /* FLAW: method should be post instead of get */
            resp.Write("Username: <input name=\"username\" type=\"text\" tabindex=\"10\" /><br><br>");
            resp.Write("Password: <input name=\"password\" type=\"password\" tabindex=\"10\" />");
            resp.Write("<input type=\"submit\" name=\"submit\" value=\"Login-bad\" /></form>");
        }
    }
#endif //omitbad

}
}
