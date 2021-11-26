/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE81_XSS_Error_Message__Web_Params_Get_Web_21.cs
Label Definition File: CWE81_XSS_Error_Message__Web.label.xml
Template File: sources-sink-21.tmpl.cs
*/
/*
 * @description
 * CWE: 81 Cross Site Scripting (XSS) in Error Message
 * BadSource: Params_Get_Web Read data from a querystring using Params.Get()
 * GoodSource: A hardcoded string
 * Sinks: ErrorStatusCode
 *    BadSink : XSS in StatusCode
 * Flow Variant: 21 Control flow: Flow controlled by value of a private variable. All functions contained in one file.
 *
 * */

using TestCaseSupport;
using System;

using System.Web;


namespace testcases.CWE81_XSS_Error_Message
{

class CWE81_XSS_Error_Message__Web_Params_Get_Web_21 : AbstractTestCaseWeb
{

    /* The variable below is used to drive control flow in the source function */
    private bool badPrivate = false;
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        badPrivate = true;
        data = Bad_source(req, resp);
        if (data != null)
        {
            /* POTENTIAL FLAW: script code (e.g. id=<script>alert('xss')</script>) is sent to the client; */
            resp.StatusCode = 404;
            resp.StatusDescription = "<br>Bad() - Parameter name has value " + data;
        }
    }

    private string Bad_source(HttpRequest req, HttpResponse resp)
    {
        string data;
        if (badPrivate)
        {
            /* POTENTIAL FLAW: Read data from a querystring using Params.Get */
            data = req.Params.Get("name");
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
        }
        return data;
    }
#endif //omitbad
    /* The variables below are used to drive control flow in the source functions. */
    private bool goodG2B1_private = false;
    private bool GoodG2B2_private = false;

}
}
