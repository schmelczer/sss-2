/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE78_OS_Command_Injection__Params_Get_Web_52a.cs
Label Definition File: CWE78_OS_Command_Injection.label.xml
Template File: sources-sink-52a.tmpl.cs
*/
/*
 * @description
 * CWE: 78 OS Command Injection
 * BadSource: Params_Get_Web Read data from a querystring using Params.Get()
 * GoodSource: A hardcoded string
 * Sinks: exec
 *    BadSink : dynamic command execution with Runtime.getRuntime().exec()
 * Flow Variant: 52 Data flow: data passed as an argument from one method to another to another in three different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;


namespace testcases.CWE78_OS_Command_Injection
{

class CWE78_OS_Command_Injection__Params_Get_Web_52a : AbstractTestCaseWeb
{

#if (!OMITGOOD)
    public override void Good(HttpRequest req, HttpResponse resp)
    {
        GoodG2B(req, resp);
    }

    /* goodG2B() - use goodsource and badsink */
    private void GoodG2B(HttpRequest req, HttpResponse resp)
    {
        string data;
        /* FIX: Use a hardcoded string */
        data = "foo";
        CWE78_OS_Command_Injection__Params_Get_Web_52b.GoodG2BSink(data , req, resp);
    }
#endif //omitgood
}
}