/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE643_Xpath_Injection__Params_Get_Web_53c.cs
Label Definition File: CWE643_Xpath_Injection.label.xml
Template File: sources-sinks-53c.tmpl.cs
*/
/*
 * @description
 * CWE: 643 Xpath Injection
 * BadSource: Params_Get_Web Read data from a querystring using Params.Get()
 * GoodSource: A hardcoded string
 * Sinks:
 *    GoodSink: validate input through SecurityElement.Escape
 *    BadSink : user input is used without validate
 * Flow Variant: 53 Data flow: data passed as an argument from one method through two others to a fourth; all four functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

using System.Runtime.InteropServices;
using System.Xml.XPath;

namespace testcases.CWE643_Xpath_Injection
{
class CWE643_Xpath_Injection__Params_Get_Web_53c
{
#if (!OMITBAD)
    public static void BadSink(string data , HttpRequest req, HttpResponse resp)
    {
        CWE643_Xpath_Injection__Params_Get_Web_53d.BadSink(data , req, resp);
    }
#endif


}
}