/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE23_Relative_Path_Traversal__Params_Get_Web_54a.cs
Label Definition File: CWE23_Relative_Path_Traversal.label.xml
Template File: sources-sink-54a.tmpl.cs
*/
/*
 * @description
 * CWE: 23 Relative Path Traversal
 * BadSource: Params_Get_Web Read data from a querystring using Params.Get()
 * GoodSource: A hardcoded string
 * Sinks: readFile
 *    BadSink : no validation
 * Flow Variant: 54 Data flow: data passed as an argument from one method through three others to a fifth; all five functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;


namespace testcases.CWE23_Relative_Path_Traversal
{

class CWE23_Relative_Path_Traversal__Params_Get_Web_54a : AbstractTestCaseWeb
{

#if (!OMITGOOD)
    public override void Good(HttpRequest req, HttpResponse resp)
    {
        GoodG2B(req, resp);
    }

    /* goodG2B() - use goodsource and badsink */
    private void GoodG2B(HttpRequest req, HttpResponse resp)
    {
        string data;
        /* FIX: Use a hardcoded string */
        data = "foo";
        CWE23_Relative_Path_Traversal__Params_Get_Web_54b.GoodG2BSink(data , req, resp);
    }
#endif //omitgood
}
}
