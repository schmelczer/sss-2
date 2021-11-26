/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE23_Relative_Path_Traversal__QueryString_Web_81a.cs
Label Definition File: CWE23_Relative_Path_Traversal.label.xml
Template File: sources-sink-81a.tmpl.cs
*/
/*
 * @description
 * CWE: 23 Relative Path Traversal
 * BadSource: QueryString_Web Parse id param out of the URL query string (without using getParameter())
 * GoodSource: A hardcoded string
 * Sinks: readFile
 *    BadSink : no validation
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */

using TestCaseSupport;
using System;

using System.Web;


namespace testcases.CWE23_Relative_Path_Traversal
{

class CWE23_Relative_Path_Traversal__QueryString_Web_81a : AbstractTestCaseWeb
{
#if (!OMITBAD)
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
        CWE23_Relative_Path_Traversal__QueryString_Web_81_base baseObject = new CWE23_Relative_Path_Traversal__QueryString_Web_81_bad();
        baseObject.Action(data , req, resp);
    }
#endif //omitbad

}
}
