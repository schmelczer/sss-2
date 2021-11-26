/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE427_Uncontrolled_Search_Path_Element__QueryString_Web_21.cs
Label Definition File: CWE427_Uncontrolled_Search_Path_Element.label.xml
Template File: sources-sink-21.tmpl.cs
*/
/*
 * @description
 * CWE: 427 Uncontrolled Search Path Element
 * BadSource: QueryString_Web Parse id param out of the URL query string (without using getParameter())
 * GoodSource: Use a hardcoded path
 * Sinks: Environment
 *    BadSink :
 * Flow Variant: 21 Control flow: Flow controlled by value of a private variable. All functions contained in one file.
 *
 * */

using TestCaseSupport;
using System;

using System.Web;
using System.Runtime.InteropServices;


namespace testcases.CWE427_Uncontrolled_Search_Path_Element
{

class CWE427_Uncontrolled_Search_Path_Element__QueryString_Web_21 : AbstractTestCaseWeb
{

    /* The variable below is used to drive control flow in the source function */
    private bool badPrivate = false;
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        badPrivate = true;
        data = Bad_source(req, resp);
        /* POTENTIAL FLAW: Set a new environment variable with a path that is possibly insecure */
        Environment.SetEnvironmentVariable("PATH", data);
    }

    private string Bad_source(HttpRequest req, HttpResponse resp)
    {
        string data;
        if (badPrivate)
        {
            data = ""; /* initialize data in case id is not in query string */
            /* POTENTIAL FLAW: Parse id param out of the URL querystring (without using getParameter()) */
            {
                if (req.QueryString["id"] != null)
                {
                    data = req.QueryString["id"];
                }
            }
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
