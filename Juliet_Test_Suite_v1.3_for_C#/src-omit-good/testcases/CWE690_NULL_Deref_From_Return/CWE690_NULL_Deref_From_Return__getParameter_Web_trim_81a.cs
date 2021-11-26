/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE690_NULL_Deref_From_Return__getParameter_Web_trim_81a.cs
Label Definition File: CWE690_NULL_Deref_From_Return.label.xml
Template File: sources-sinks-81a.tmpl.cs
*/
/*
 * @description
 * CWE: 690 Unchecked return value is null, leading to a null pointer dereference.
 * BadSource: getParameter_Web Set data to return of getParameter_Web
 * GoodSource: Set data to fixed, non-null String
 * Sinks: trim
 *    GoodSink: Check data for null before calling trim()
 *    BadSink : Call trim() on possibly null object
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE690_NULL_Deref_From_Return
{
class CWE690_NULL_Deref_From_Return__getParameter_Web_trim_81a : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        /* POTENTIAL FLAW: data may be set to null */
        data = req.QueryString["CWE690"];
        CWE690_NULL_Deref_From_Return__getParameter_Web_trim_81_base baseObject = new CWE690_NULL_Deref_From_Return__getParameter_Web_trim_81_bad();
        baseObject.Action(data , req, resp);
    }
#endif //omitbad

}
}