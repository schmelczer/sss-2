/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE113_HTTP_Response_Splitting__Web_Params_Get_Web_setHeader_74b.cs
Label Definition File: CWE113_HTTP_Response_Splitting__Web.label.xml
Template File: sources-sinks-74b.tmpl.cs
*/
/*
 * @description
 * CWE: 113 HTTP Response Splitting
 * BadSource: Params_Get_Web Read data from a querystring using Params.Get()
 * GoodSource: A hardcoded string
 * Sinks: setHeader
 *    GoodSink: URLEncode input
 *    BadSink : querystring to AddHeader()
 * Flow Variant: 74 Data flow: data passed in a Dictionary from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;
using System.Collections.Generic;

using System.Web;
using System.Text;

namespace testcases.CWE113_HTTP_Response_Splitting
{
class CWE113_HTTP_Response_Splitting__Web_Params_Get_Web_setHeader_74b
{
#if (!OMITBAD)
    public static void BadSink(Dictionary<int,string> dataDictionary , HttpRequest req, HttpResponse resp)
    {
        string data = dataDictionary[2];
        if (data != null)
        {
            /* POTENTIAL FLAW: Input not verified before inclusion in header */
            resp.AddHeader("Location", "/author.jsp?lang=" + data);
        }
    }
#endif


}
}
