/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE601_Open_Redirect__Web_Params_Get_Web_53c.cs
Label Definition File: CWE601_Open_Redirect__Web.label.xml
Template File: sources-sink-53c.tmpl.cs
*/
/*
 * @description
 * CWE: 601 Open Redirect
 * BadSource: Params_Get_Web Read data from a querystring using Params.Get()
 * GoodSource: A hardcoded string
 * Sinks:
 *    BadSink : place redirect string directly into redirect api call
 * Flow Variant: 53 Data flow: data passed as an argument from one method through two others to a fourth; all four functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE601_Open_Redirect
{
class CWE601_Open_Redirect__Web_Params_Get_Web_53c
{


#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink */
    public static void GoodG2BSink(string data , HttpRequest req, HttpResponse resp)
    {
        CWE601_Open_Redirect__Web_Params_Get_Web_53d.GoodG2BSink(data , req, resp);
    }
#endif
}
}
