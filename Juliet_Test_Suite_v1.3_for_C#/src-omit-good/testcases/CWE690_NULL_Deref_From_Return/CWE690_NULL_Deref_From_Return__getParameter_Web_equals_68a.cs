/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE690_NULL_Deref_From_Return__getParameter_Web_equals_68a.cs
Label Definition File: CWE690_NULL_Deref_From_Return.label.xml
Template File: sources-sinks-68a.tmpl.cs
*/
/*
 * @description
 * CWE: 690 Unchecked return value is null, leading to a null pointer dereference.
 * BadSource: getParameter_Web Set data to return of getParameter_Web
 * GoodSource: Set data to fixed, non-null String
 * Sinks: equals
 *    GoodSink: Call equals() on string literal (that is not null)
 *    BadSink : Call equals() on possibly null object
 * Flow Variant: 68 Data flow: data passed as a member variable in the "a" class, which is used by a method in another class in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE690_NULL_Deref_From_Return
{
class CWE690_NULL_Deref_From_Return__getParameter_Web_equals_68a : AbstractTestCaseWeb
{

    public static string data;
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        /* POTENTIAL FLAW: data may be set to null */
        data = req.QueryString["CWE690"];
        CWE690_NULL_Deref_From_Return__getParameter_Web_equals_68b.BadSink(req, resp);
    }
#endif //omitbad

}
}
