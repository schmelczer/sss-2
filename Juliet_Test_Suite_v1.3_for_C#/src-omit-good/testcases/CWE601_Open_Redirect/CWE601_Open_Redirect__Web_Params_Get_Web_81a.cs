/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE601_Open_Redirect__Web_Params_Get_Web_81a.cs
Label Definition File: CWE601_Open_Redirect__Web.label.xml
Template File: sources-sink-81a.tmpl.cs
*/
/*
 * @description
 * CWE: 601 Open Redirect
 * BadSource: Params_Get_Web Read data from a querystring using Params.Get()
 * GoodSource: A hardcoded string
 * Sinks:
 *    BadSink : place redirect string directly into redirect api call
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */

using TestCaseSupport;
using System;

using System.Web;


namespace testcases.CWE601_Open_Redirect
{

class CWE601_Open_Redirect__Web_Params_Get_Web_81a : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        /* POTENTIAL FLAW: Read data from a querystring using Params.Get */
        data = req.Params.Get("name");
        CWE601_Open_Redirect__Web_Params_Get_Web_81_base baseObject = new CWE601_Open_Redirect__Web_Params_Get_Web_81_bad();
        baseObject.Action(data , req, resp);
    }
#endif //omitbad

}
}
