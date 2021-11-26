/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE523_Unprotected_Cred_Transport__Web_04.cs
Label Definition File: CWE523_Unprotected_Cred_Transport__Web.label.xml
Template File: point-flaw-04.tmpl.cs
*/
/*
* @description
* CWE: 523 Unprotected Transport of Credentials
* Sinks: non_ssl
*    GoodSink: Send across SSL connection
*    BadSink : Send across non-SSL connection
* Flow Variant: 04 Control flow: if(PRIVATE_CONST_TRUE) and if(PRIVATE_CONST_FALSE)
*
* */

using TestCaseSupport;
using System;

using System.Web;

using System.IO;

namespace testcases.CWE523_Unprotected_Cred_Transport
{
class CWE523_Unprotected_Cred_Transport__Web_04 : AbstractTestCaseWeb
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
            try
            {
                /* FLAW: transmitting login credentials across a non-SSL connection */
                resp.Write("<form action='http://hostname.com/j_security_check' method='post'>");
                resp.Write("<table>");
                resp.Write("<tr><td>Name:</td>");
                resp.Write("<td><input type='text' name='j_username'></td></tr>");
                resp.Write("<tr><td>Password:</td>");
                resp.Write("<td><input type='password' name='j_password' size='8'></td>");
                resp.Write("</tr>");
                resp.Write("</table><br />");
                resp.Write("<input type='submit' value='login'>");
                resp.Write("</form>");
            }
            catch (IOException exceptIO)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, "There was a problem writing", exceptIO);
            }
        }
    }
#endif //omitbad

}
}
