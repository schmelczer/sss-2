/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE83_XSS_Attribute__Web_Params_Get_Web_61a.cs
Label Definition File: CWE83_XSS_Attribute__Web.label.xml
Template File: sources-sink-61a.tmpl.cs
*/
/*
 * @description
 * CWE: 83 Cross Site Scripting (XSS) in attributes; Examples(replace QUOTE with an actual double quote): ?img_loc=http://www.google.comQUOTE%20onerror=QUOTEalert(1) and ?img_loc=http://www.google.comQUOTE%20onerror=QUOTEjavascript:alert(1)
 * BadSource: Params_Get_Web Read data from a querystring using Params.Get()
 * GoodSource: A hardcoded string
 * Sinks: Write
 *    BadSink : XSS in img src attribute
 * Flow Variant: 61 Data flow: data returned from one method to another in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE83_XSS_Attribute
{
class CWE83_XSS_Attribute__Web_Params_Get_Web_61a : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data = CWE83_XSS_Attribute__Web_Params_Get_Web_61b.BadSource(req, resp);
        if (data != null)
        {
            /* POTENTIAL FLAW: Input is not verified/sanitized before use in an image tag */
            resp.Write("<br>Bad() - <img src=\"" + data +"\">");
        }
    }
#endif //omitbad

}
}
