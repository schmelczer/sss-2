/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE81_XSS_Error_Message__Web_Get_Cookies_Web_73a.cs
Label Definition File: CWE81_XSS_Error_Message__Web.label.xml
Template File: sources-sink-73a.tmpl.cs
*/
/*
 * @description
 * CWE: 81 Cross Site Scripting (XSS) in Error Message
 * BadSource: Get_Cookies_Web Read data from the first cookie using Cookies
 * GoodSource: A hardcoded string
 * Sinks: ErrorStatusCode
 *    BadSink : XSS in StatusCode
 * Flow Variant: 73 Data flow: data passed in a LinkedList from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System.Collections.Generic;
using System;

using System.Web;


namespace testcases.CWE81_XSS_Error_Message
{

class CWE81_XSS_Error_Message__Web_Get_Cookies_Web_73a : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        data = ""; /* initialize data in case there are no cookies */
        /* Read data from cookies */
        {
            HttpCookieCollection cookieSources = req.Cookies;
            if (cookieSources != null)
            {
                /* POTENTIAL FLAW: Read data from the first cookie value */
                data = cookieSources[0].Value;
            }
        }
        LinkedList<string> dataLinkedList = new LinkedList<string>();
        dataLinkedList.AddLast(data);
        dataLinkedList.AddLast(data);
        dataLinkedList.AddLast(data);
        CWE81_XSS_Error_Message__Web_Get_Cookies_Web_73b.BadSink(dataLinkedList , req, resp );
    }
#endif //omitbad

}
}
