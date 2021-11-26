/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE78_OS_Command_Injection__Get_Cookies_Web_66a.cs
Label Definition File: CWE78_OS_Command_Injection.label.xml
Template File: sources-sink-66a.tmpl.cs
*/
/*
 * @description
 * CWE: 78 OS Command Injection
 * BadSource: Get_Cookies_Web Read data from the first cookie using Cookies
 * GoodSource: A hardcoded string
 * Sinks: exec
 *    BadSink : dynamic command execution with Runtime.getRuntime().exec()
 * Flow Variant: 66 Data flow: data passed in an array from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;


namespace testcases.CWE78_OS_Command_Injection
{

class CWE78_OS_Command_Injection__Get_Cookies_Web_66a : AbstractTestCaseWeb
{

#if (!OMITGOOD)
    public override void Good(HttpRequest req, HttpResponse resp)
    {
        GoodG2B(req, resp);
    }

    /* goodG2B() - use goodsource and badsink */
    private static void GoodG2B(HttpRequest req, HttpResponse resp)
    {
        string data;
        /* FIX: Use a hardcoded string */
        data = "foo";
        string[] dataArray = new string[5];
        dataArray[2] = data;
        CWE78_OS_Command_Injection__Get_Cookies_Web_66b.GoodG2BSink(dataArray , req, resp );
    }
#endif //omitgood
}
}
