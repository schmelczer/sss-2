/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE615_Info_Exposure_by_Comment__Web_06.cs
Label Definition File: CWE615_Info_Exposure_by_Comment__Web.label.xml
Template File: point-flaw-06.tmpl.cs
*/
/*
* @description
* CWE: 615 Information Exposure by Comment
* Sinks:
*    GoodSink: no disclosure of username and password
*    BadSink : disclose username and password
* Flow Variant: 06 Control flow: if(PRIVATE_CONST_FIVE==5) and if(PRIVATE_CONST_FIVE!=5)
*
* */

using TestCaseSupport;
using System;

using System.Web;
using System.IO;

namespace testcases.CWE615_Info_Exposure_by_Comment
{
class CWE615_Info_Exposure_by_Comment__Web_06 : AbstractTestCaseWeb
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
            /* FIX: no info exposure in client-side code comments */
            resp.Write("<form action=\"/test\" method=post>" +
                       "<input type=text name=dbusername>" +
                       "<input type=test name=dbpassword>" +
                       "<input type=submit value=Submit>" +
                       "</form>");
        }
    }

    /* Good2() reverses the bodies in the if statement */
    private void Good2(HttpRequest req, HttpResponse resp)
    {
        if (PRIVATE_CONST_FIVE == 5)
        {
            /* FIX: no info exposure in client-side code comments */
            resp.Write("<form action=\"/test\" method=post>" +
                       "<input type=text name=dbusername>" +
                       "<input type=test name=dbpassword>" +
                       "<input type=submit value=Submit>" +
                       "</form>");
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
