/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE15_External_Control_of_System_or_Configuration_Setting__Params_Get_Web_66a.cs
Label Definition File: CWE15_External_Control_of_System_or_Configuration_Setting.label.xml
Template File: sources-sink-66a.tmpl.cs
*/
/*
 * @description
 * CWE: 15 External Control of System or Configuration Setting
 * BadSource: Params_Get_Web Read data from a querystring using Params.Get()
 * GoodSource: A hardcoded string
 * Sinks:
 *    BadSink : Set the catalog name with the value of data
 * Flow Variant: 66 Data flow: data passed in an array from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;


namespace testcases.CWE15_External_Control_of_System_or_Configuration_Setting
{

class CWE15_External_Control_of_System_or_Configuration_Setting__Params_Get_Web_66a : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override  void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        /* POTENTIAL FLAW: Read data from a querystring using Params.Get */
        data = req.Params.Get("name");
        string[] dataArray = new string[5];
        dataArray[2] = data;
        CWE15_External_Control_of_System_or_Configuration_Setting__Params_Get_Web_66b.BadSink(dataArray , req, resp );
    }
#endif //omitbad

}
}
