/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE23_Relative_Path_Traversal__Params_Get_Web_68a.cs
Label Definition File: CWE23_Relative_Path_Traversal.label.xml
Template File: sources-sink-68a.tmpl.cs
*/
/*
 * @description
 * CWE: 23 Relative Path Traversal
 * BadSource: Params_Get_Web Read data from a querystring using Params.Get()
 * GoodSource: A hardcoded string
 * BadSink: readFile no validation
 * Flow Variant: 68 Data flow: data passed as a member variable in the "a" class, which is used by a method in another class in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;


namespace testcases.CWE23_Relative_Path_Traversal
{

class CWE23_Relative_Path_Traversal__Params_Get_Web_68a : AbstractTestCaseWeb
{

    public static string data;
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        /* POTENTIAL FLAW: Read data from a querystring using Params.Get */
        data = req.Params.Get("name");
        CWE23_Relative_Path_Traversal__Params_Get_Web_68b.BadSink(req, resp);
    }
#endif //omitbad

}
}
