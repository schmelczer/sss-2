/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE523_Unprotected_Cred_Transport__Web_13.cs
Label Definition File: CWE523_Unprotected_Cred_Transport__Web.label.xml
Template File: point-flaw-13.tmpl.cs
*/
/*
* @description
* CWE: 523 Unprotected Transport of Credentials
* Sinks: non_ssl
*    GoodSink: Send across SSL connection
*    BadSink : Send across non-SSL connection
* Flow Variant: 13 Control flow: if(IO.STATIC_READONLY_FIVE==5) and if(IO.STATIC_READONLY_FIVE!=5)
*
* */

using TestCaseSupport;
using System;

using System.IO;

using System.Web;

namespace testcases.CWE523_Unprotected_Cred_Transport
{
class CWE523_Unprotected_Cred_Transport__Web_13 : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        if (IO.STATIC_READONLY_FIVE == 5)
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
