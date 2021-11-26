/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE427_Uncontrolled_Search_Path_Element__QueryString_Web_45.cs
Label Definition File: CWE427_Uncontrolled_Search_Path_Element.label.xml
Template File: sources-sink-45.tmpl.cs
*/
/*
 * @description
 * CWE: 427 Uncontrolled Search Path Element
 * BadSource: QueryString_Web Parse id param out of the URL query string (without using getParameter())
 * GoodSource: Use a hardcoded path
 * Sinks: Environment
 *    BadSink :
 * Flow Variant: 45 Data flow: data passed as a private class member variable from one function to another in the same class
 *
 * */

using TestCaseSupport;
using System;

using System.Web;
using System.Runtime.InteropServices;


namespace testcases.CWE427_Uncontrolled_Search_Path_Element
{

class CWE427_Uncontrolled_Search_Path_Element__QueryString_Web_45 : AbstractTestCaseWeb
{

    private string dataBad;
    private string dataGoodG2B;
#if (!OMITBAD)
    private void BadSink(HttpRequest req, HttpResponse resp)
    {
        string data = dataBad;
        /* POTENTIAL FLAW: Set a new environment variable with a path that is possibly insecure */
        Environment.SetEnvironmentVariable("PATH", data);
    }

    /* uses badsource and badsink */
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        data = ""; /* initialize data in case id is not in query string */
        /* POTENTIAL FLAW: Parse id param out of the URL querystring (without using getParameter()) */
        {
            if (req.QueryString["id"] != null)
            {
                data = req.QueryString["id"];
            }
        }
        dataBad = data;
        BadSink(req, resp);
    }
#endif //omitbad

}
}
