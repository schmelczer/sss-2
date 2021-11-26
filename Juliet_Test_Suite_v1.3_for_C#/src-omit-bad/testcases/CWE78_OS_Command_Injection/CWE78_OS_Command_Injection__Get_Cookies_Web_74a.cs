/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE78_OS_Command_Injection__Get_Cookies_Web_74a.cs
Label Definition File: CWE78_OS_Command_Injection.label.xml
Template File: sources-sink-74a.tmpl.cs
*/
/*
 * @description
 * CWE: 78 OS Command Injection
 * BadSource: Get_Cookies_Web Read data from the first cookie using Cookies
 * GoodSource: A hardcoded string
 * Sinks: exec
 *    BadSink : dynamic command execution with Runtime.getRuntime().exec()
 * Flow Variant: 74 Data flow: data passed in a Dictionary from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System.Collections.Generic;
using System;

using System.Web;


namespace testcases.CWE78_OS_Command_Injection
{
class CWE78_OS_Command_Injection__Get_Cookies_Web_74a : AbstractTestCaseWeb
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
        Dictionary<int,string> dataDictionary = new Dictionary<int,string>();
        dataDictionary.Add(0, data);
        dataDictionary.Add(1, data);
        dataDictionary.Add(2, data);
        CWE78_OS_Command_Injection__Get_Cookies_Web_74b.GoodG2BSink(dataDictionary , req, resp );
    }
#endif //omitgood
}
}
