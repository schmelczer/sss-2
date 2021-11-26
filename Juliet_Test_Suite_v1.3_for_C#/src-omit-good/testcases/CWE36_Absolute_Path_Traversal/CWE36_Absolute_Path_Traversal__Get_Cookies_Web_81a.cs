/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE36_Absolute_Path_Traversal__Get_Cookies_Web_81a.cs
Label Definition File: CWE36_Absolute_Path_Traversal.label.xml
Template File: sources-sink-81a.tmpl.cs
*/
/*
 * @description
 * CWE: 36 Absolute Path Traversal
 * BadSource: Get_Cookies_Web Read data from the first cookie using Cookies
 * GoodSource: A hardcoded string
 * Sinks: readFile
 *    BadSink : read line from file from disk
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */

using TestCaseSupport;
using System;

using System.Web;


namespace testcases.CWE36_Absolute_Path_Traversal
{

class CWE36_Absolute_Path_Traversal__Get_Cookies_Web_81a : AbstractTestCaseWeb
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
        CWE36_Absolute_Path_Traversal__Get_Cookies_Web_81_base baseObject = new CWE36_Absolute_Path_Traversal__Get_Cookies_Web_81_bad();
        baseObject.Action(data , req, resp);
    }
#endif //omitbad

}
}
