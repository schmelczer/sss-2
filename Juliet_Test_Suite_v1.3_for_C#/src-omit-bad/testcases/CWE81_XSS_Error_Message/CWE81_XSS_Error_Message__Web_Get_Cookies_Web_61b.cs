/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE81_XSS_Error_Message__Web_Get_Cookies_Web_61b.cs
Label Definition File: CWE81_XSS_Error_Message__Web.label.xml
Template File: sources-sink-61b.tmpl.cs
*/
/*
 * @description
 * CWE: 81 Cross Site Scripting (XSS) in Error Message
 * BadSource: Get_Cookies_Web Read data from the first cookie using Cookies
 * GoodSource: A hardcoded string
 * Sinks: ErrorStatusCode
 *    BadSink : XSS in StatusCode
 * Flow Variant: 61 Data flow: data returned from one method to another in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;


namespace testcases.CWE81_XSS_Error_Message
{

class CWE81_XSS_Error_Message__Web_Get_Cookies_Web_61b
{


#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink */
    public static string GoodG2BSource(HttpRequest req, HttpResponse resp)
    {
        string data;
        /* FIX: Use a hardcoded string */
        data = "foo";
        return data;
    }
#endif
}
}