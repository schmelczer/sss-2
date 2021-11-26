/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE601_Open_Redirect__Web_Params_Get_Web_66a.cs
Label Definition File: CWE601_Open_Redirect__Web.label.xml
Template File: sources-sink-66a.tmpl.cs
*/
/*
 * @description
 * CWE: 601 Open Redirect
 * BadSource: Params_Get_Web Read data from a querystring using Params.Get()
 * GoodSource: A hardcoded string
 * Sinks:
 *    BadSink : place redirect string directly into redirect api call
 * Flow Variant: 66 Data flow: data passed in an array from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;


namespace testcases.CWE601_Open_Redirect
{

class CWE601_Open_Redirect__Web_Params_Get_Web_66a : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override  void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        /* POTENTIAL FLAW: Read data from a querystring using Params.Get */
        data = req.Params.Get("name");
        string[] dataArray = new string[5];
        dataArray[2] = data;
        CWE601_Open_Redirect__Web_Params_Get_Web_66b.BadSink(dataArray , req, resp );
    }
#endif //omitbad

}
}
