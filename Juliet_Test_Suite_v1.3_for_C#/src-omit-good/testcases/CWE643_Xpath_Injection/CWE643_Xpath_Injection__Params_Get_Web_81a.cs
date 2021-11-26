/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE643_Xpath_Injection__Params_Get_Web_81a.cs
Label Definition File: CWE643_Xpath_Injection.label.xml
Template File: sources-sinks-81a.tmpl.cs
*/
/*
 * @description
 * CWE: 643 Xpath Injection
 * BadSource: Params_Get_Web Read data from a querystring using Params.Get()
 * GoodSource: A hardcoded string
 * Sinks:
 *    GoodSink: validate input through SecurityElement.Escape
 *    BadSink : user input is used without validate
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */

using TestCaseSupport;
using System;

using System.Web;


namespace testcases.CWE643_Xpath_Injection
{
class CWE643_Xpath_Injection__Params_Get_Web_81a : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        /* POTENTIAL FLAW: Read data from a querystring using Params.Get */
        data = req.Params.Get("name");
        CWE643_Xpath_Injection__Params_Get_Web_81_base baseObject = new CWE643_Xpath_Injection__Params_Get_Web_81_bad();
        baseObject.Action(data , req, resp);
    }
#endif //omitbad

}
}
