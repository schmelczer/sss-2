/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE23_Relative_Path_Traversal__Params_Get_Web_51a.cs
Label Definition File: CWE23_Relative_Path_Traversal.label.xml
Template File: sources-sink-51a.tmpl.cs
*/
/*
 * @description
 * CWE: 23 Relative Path Traversal
 * BadSource: Params_Get_Web Read data from a querystring using Params.Get()
 * GoodSource: A hardcoded string
 * BadSink: readFile no validation
 * Flow Variant: 51 Data flow: data passed as an argument from one function to another in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;


namespace testcases.CWE23_Relative_Path_Traversal
{

class CWE23_Relative_Path_Traversal__Params_Get_Web_51a : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        /* POTENTIAL FLAW: Read data from a querystring using Params.Get */
        data = req.Params.Get("name");
        CWE23_Relative_Path_Traversal__Params_Get_Web_51b.BadSink(data , req, resp );
    }
#endif //omitbad

}
}
