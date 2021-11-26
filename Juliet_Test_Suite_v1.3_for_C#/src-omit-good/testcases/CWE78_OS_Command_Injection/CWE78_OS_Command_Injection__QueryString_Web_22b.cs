/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE78_OS_Command_Injection__QueryString_Web_22b.cs
Label Definition File: CWE78_OS_Command_Injection.label.xml
Template File: sources-sink-22b.tmpl.cs
*/
/*
 * @description
 * CWE: 78 OS Command Injection
 * BadSource: QueryString_Web Parse id param out of the URL query string (without using getParameter())
 * GoodSource: A hardcoded string
 * Sinks: exec
 *    BadSink : dynamic command execution with Runtime.getRuntime().exec()
 * Flow Variant: 22 Control flow: Flow controlled by value of a public static variable. Sink functions are in a separate file from sources.
 *
 * */

using TestCaseSupport;
using System;

using System.Web;


namespace testcases.CWE78_OS_Command_Injection
{

class CWE78_OS_Command_Injection__QueryString_Web_22b
{
#if (!OMITBAD)
    public static string BadSource(HttpRequest req, HttpResponse resp)
    {
        string data;
        if (CWE78_OS_Command_Injection__QueryString_Web_22a.badPublicStatic)
        {
            data = ""; /* initialize data in case id is not in query string */
            /* POTENTIAL FLAW: Parse id param out of the URL querystring (without using getParameter()) */
            {
                if (req.QueryString["id"] != null)
                {
                    data = req.QueryString["id"];
                }
            }
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
        }
        return data;
    }
#endif


}
}
