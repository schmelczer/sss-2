/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE566_Authorization_Bypass_Through_SQL_Primary__Web_22b.cs
Label Definition File: CWE566_Authorization_Bypass_Through_SQL_Primary__Web.label.xml
Template File: sources-sink-22b.tmpl.cs
*/
/*
 * @description
 * CWE: 566 Authorization Bypass through SQL primary
 * BadSource:  user id taken from url parameter
 * GoodSource: hardcoded user id
 * Sinks: writeConsole
 *    BadSink : user authorization not checked
 * Flow Variant: 22 Control flow: Flow controlled by value of a public static variable. Sink functions are in a separate file from sources.
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE566_Authorization_Bypass_Through_SQL_Primary
{

class CWE566_Authorization_Bypass_Through_SQL_Primary__Web_22b
{
#if (!OMITBAD)
    public static string BadSource(HttpRequest req, HttpResponse resp)
    {
        string data;
        if (CWE566_Authorization_Bypass_Through_SQL_Primary__Web_22a.badPublicStatic)
        {
            /* FLAW: Get the user ID from a URL parameter */
            data = req.Params.Get("id");
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
