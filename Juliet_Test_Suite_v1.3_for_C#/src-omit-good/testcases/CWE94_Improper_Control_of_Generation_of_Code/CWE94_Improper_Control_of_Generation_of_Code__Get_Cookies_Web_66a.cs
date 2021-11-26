/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE94_Improper_Control_of_Generation_of_Code__Get_Cookies_Web_66a.cs
Label Definition File: CWE94_Improper_Control_of_Generation_of_Code.label.xml
Template File: sources-sinks-66a.tmpl.cs
*/
/*
 * @description
 * CWE: 94 Improper Control of Generation of Code
 * BadSource: Get_Cookies_Web Read data from the first cookie using Cookies
 * GoodSource: Set data to an integer represented as a string
 * Sinks:
 *    GoodSink: Validate user input prior to compiling
 *    BadSink : Compile sourceCode containing unvalidated user input
 * Flow Variant: 66 Data flow: data passed in an array from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE94_Improper_Control_of_Generation_of_Code
{
class CWE94_Improper_Control_of_Generation_of_Code__Get_Cookies_Web_66a : AbstractTestCaseWeb
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
        string[] dataArray = new string[5];
        dataArray[2] = data;
        CWE94_Improper_Control_of_Generation_of_Code__Get_Cookies_Web_66b.BadSink(dataArray , req, resp );
    }
#endif //omitbad

}
}
