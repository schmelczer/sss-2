/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE80_XSS__Web_Connect_tcp_67b.cs
Label Definition File: CWE80_XSS__Web.label.xml
Template File: sources-sink-67b.tmpl.cs
*/
/*
 * @description
 * CWE: 80 Cross Site Scripting (XSS)
 * BadSource: Connect_tcp Read data using an outbound tcp connection
 * GoodSource: A hardcoded string
 * Sinks: Web
 *    BadSink : Display of data in web page without any encoding or validation
 * Flow Variant: 67 Data flow: data passed in a class from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE80_XSS
{
class CWE80_XSS__Web_Connect_tcp_67b
{
#if (!OMITBAD)
    public static void BadSink(CWE80_XSS__Web_Connect_tcp_67a.Container dataContainer , HttpRequest req, HttpResponse resp)
    {
        string data = dataContainer.containerOne;
        if (data != null)
        {
            /* POTENTIAL FLAW: Display of data in web page without any encoding or validation */
            resp.Write("<br>Bad(): data = " + data);
        }
    }
#endif


}
}