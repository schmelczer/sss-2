/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE606_Unchecked_Loop_Condition__Get_Cookies_Web_81a.cs
Label Definition File: CWE606_Unchecked_Loop_Condition.label.xml
Template File: sources-sinks-81a.tmpl.cs
*/
/*
 * @description
 * CWE: 606 Unchecked Input for Loop Condition
 * BadSource: Get_Cookies_Web Read data from the first cookie using Cookies
 * GoodSource: hardcoded int in string form
 * Sinks:
 *    GoodSink: validate loop variable
 *    BadSink : loop variable not validated
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE606_Unchecked_Loop_Condition
{
class CWE606_Unchecked_Loop_Condition__Get_Cookies_Web_81a : AbstractTestCaseWeb
{

#if (!OMITGOOD)
    public override void Good(HttpRequest req, HttpResponse resp)
    {
        GoodG2B(req, resp);
        GoodB2G(req, resp);
    }

    /* goodG2B() - use GoodSource and BadSink */
    private void GoodG2B(HttpRequest req, HttpResponse resp)
    {
        string data;
        /* FIX: Use a hardcoded int as a string */
        data = "5";
        CWE606_Unchecked_Loop_Condition__Get_Cookies_Web_81_base baseObject = new CWE606_Unchecked_Loop_Condition__Get_Cookies_Web_81_goodG2B();
        baseObject.Action(data , req, resp);
    }

    /* goodB2G() - use BadSource and GoodSink */
    private void GoodB2G(HttpRequest req, HttpResponse resp)
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
        CWE606_Unchecked_Loop_Condition__Get_Cookies_Web_81_base baseObject = new CWE606_Unchecked_Loop_Condition__Get_Cookies_Web_81_goodB2G();
        baseObject.Action(data , req, resp);
    }
#endif //omitgood
}
}
