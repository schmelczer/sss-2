/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE80_XSS__CWE182_Web_Params_Get_Web_68a.cs
Label Definition File: CWE80_XSS__CWE182_Web.label.xml
Template File: sources-sink-68a.tmpl.cs
*/
/*
 * @description
 * CWE: 80 Cross Site Scripting (XSS)
 * BadSource: Params_Get_Web Read data from a querystring using Params.Get()
 * GoodSource: A hardcoded string
 * BadSink: Web Display of data in web page after using replaceAll() to remove script tags, which will still allow XSS (CWE 182: Collapse of Data into Unsafe Value)
 * Flow Variant: 68 Data flow: data passed as a member variable in the "a" class, which is used by a method in another class in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;


namespace testcases.CWE80_XSS
{

class CWE80_XSS__CWE182_Web_Params_Get_Web_68a : AbstractTestCaseWeb
{

    public static string data;

#if (!OMITGOOD)
    public override void Good(HttpRequest req, HttpResponse resp)
    {
        GoodG2B(req, resp);
    }

    /* goodG2B() - use goodsource and badsink */
    private static void GoodG2B(HttpRequest req, HttpResponse resp)
    {
        /* FIX: Use a hardcoded string */
        data = "foo";
        CWE80_XSS__CWE182_Web_Params_Get_Web_68b.GoodG2BSink(req, resp);
    }
#endif //omitgood
}
}
