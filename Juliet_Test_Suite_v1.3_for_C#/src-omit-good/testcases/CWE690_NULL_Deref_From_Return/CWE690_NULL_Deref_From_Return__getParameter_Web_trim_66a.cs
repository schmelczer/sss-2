/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE690_NULL_Deref_From_Return__getParameter_Web_trim_66a.cs
Label Definition File: CWE690_NULL_Deref_From_Return.label.xml
Template File: sources-sinks-66a.tmpl.cs
*/
/*
 * @description
 * CWE: 690 Unchecked return value is null, leading to a null pointer dereference.
 * BadSource: getParameter_Web Set data to return of getParameter_Web
 * GoodSource: Set data to fixed, non-null String
 * Sinks: trim
 *    GoodSink: Check data for null before calling trim()
 *    BadSink : Call trim() on possibly null object
 * Flow Variant: 66 Data flow: data passed in an array from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE690_NULL_Deref_From_Return
{
class CWE690_NULL_Deref_From_Return__getParameter_Web_trim_66a : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        /* POTENTIAL FLAW: data may be set to null */
        data = req.QueryString["CWE690"];
        string[] dataArray = new string[5];
        dataArray[2] = data;
        CWE690_NULL_Deref_From_Return__getParameter_Web_trim_66b.BadSink(dataArray , req, resp );
    }
#endif //omitbad

}
}
