/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE523_Unprotected_Cred_Transport__Web_07.cs
Label Definition File: CWE523_Unprotected_Cred_Transport__Web.label.xml
Template File: point-flaw-07.tmpl.cs
*/
/*
* @description
* CWE: 523 Unprotected Transport of Credentials
* Sinks: non_ssl
*    GoodSink: Send across SSL connection
*    BadSink : Send across non-SSL connection
* Flow Variant: 07 Control flow: if(privateFive==5) and if(privateFive!=5)
*
* */

using TestCaseSupport;
using System;

using System.IO;

using System.Web;

namespace testcases.CWE523_Unprotected_Cred_Transport
{
class CWE523_Unprotected_Cred_Transport__Web_07 : AbstractTestCaseWeb
{
    /* The variable below is not declared "readonly", but is never assigned
     * any other value so a tool should be able to identify that reads of
     * this will always give its initialized value.
     */
    private int privateFive = 5;
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        if (privateFive == 5)
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
