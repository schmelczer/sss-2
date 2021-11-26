/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE117_Improper_Output_Neutralization_for_Logs__Params_Get_Web_71a.cs
Label Definition File: CWE117_Improper_Output_Neutralization_for_Logs.label.xml
Template File: sources-sinks-71a.tmpl.cs
*/
/*
 * @description
 * CWE: 117 Improper Output Neutralization for Logs
 * BadSource: Params_Get_Web Read data from a querystring using Params.Get()
 * GoodSource: A hardcoded string
 * Sinks: readFile
 *    GoodSink: Logging output is neutralized
 *    BadSink : Logging output is not neutralized
 * Flow Variant: 71 Data flow: data passed as an Object reference argument from one method to another in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;


namespace testcases.CWE117_Improper_Output_Neutralization_for_Logs
{
class CWE117_Improper_Output_Neutralization_for_Logs__Params_Get_Web_71a : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        /* POTENTIAL FLAW: Read data from a querystring using Params.Get */
        data = req.Params.Get("name");
        CWE117_Improper_Output_Neutralization_for_Logs__Params_Get_Web_71b.BadSink((Object)data , req, resp );
    }
#endif //omitbad

}
}
