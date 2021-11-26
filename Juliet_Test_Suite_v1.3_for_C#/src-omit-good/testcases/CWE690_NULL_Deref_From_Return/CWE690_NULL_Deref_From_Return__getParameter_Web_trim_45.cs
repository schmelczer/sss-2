/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE690_NULL_Deref_From_Return__getParameter_Web_trim_45.cs
Label Definition File: CWE690_NULL_Deref_From_Return.label.xml
Template File: sources-sinks-45.tmpl.cs
*/
/*
 * @description
 * CWE: 690 Unchecked return value is null, leading to a null pointer dereference.
 * BadSource: getParameter_Web Set data to return of getParameter_Web
 * GoodSource: Set data to fixed, non-null String
 * Sinks: trim
 *    GoodSink: Check data for null before calling trim()
 *    BadSink : Call trim() on possibly null object
 * Flow Variant: 45 Data flow: data passed as a private class member variable from one function to another in the same class
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE690_NULL_Deref_From_Return
{
class CWE690_NULL_Deref_From_Return__getParameter_Web_trim_45 : AbstractTestCaseWeb
{

    private string dataBad;
    private string dataGoodG2B;
    private string dataGoodB2G;
#if (!OMITBAD)
    private void BadSink(HttpRequest req, HttpResponse resp)
    {
        string data = dataBad;
        /* POTENTIAL FLAW: data could be null */
        string stringTrimmed = data.Trim();
        IO.WriteLine(stringTrimmed);
    }

    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        /* POTENTIAL FLAW: data may be set to null */
        data = req.QueryString["CWE690"];
        dataBad = data;
        BadSink(req, resp);
    }
#endif //omitbad

}
}
