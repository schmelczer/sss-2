/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE81_XSS_Error_Message__Web_ReadLine_52b.cs
Label Definition File: CWE81_XSS_Error_Message__Web.label.xml
Template File: sources-sink-52b.tmpl.cs
*/
/*
 * @description
 * CWE: 81 Cross Site Scripting (XSS) in Error Message
 * BadSource: ReadLine Read data from the console using ReadLine()
 * GoodSource: A hardcoded string
 * Sinks: ErrorStatusCode
 *    BadSink : XSS in StatusCode
 * Flow Variant: 52 Data flow: data passed as an argument from one method to another to another in three different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE81_XSS_Error_Message
{
class CWE81_XSS_Error_Message__Web_ReadLine_52b
{
#if (!OMITBAD)
    public static void BadSink(string data , HttpRequest req, HttpResponse resp)
    {
        CWE81_XSS_Error_Message__Web_ReadLine_52c.BadSink(data , req, resp);
    }
#endif


}
}
