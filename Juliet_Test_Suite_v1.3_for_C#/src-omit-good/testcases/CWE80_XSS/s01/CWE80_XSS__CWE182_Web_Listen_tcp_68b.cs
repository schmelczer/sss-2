/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE80_XSS__CWE182_Web_Listen_tcp_68b.cs
Label Definition File: CWE80_XSS__CWE182_Web.label.xml
Template File: sources-sink-68b.tmpl.cs
*/
/*
 * @description
 * CWE: 80 Cross Site Scripting (XSS)
 * BadSource: Listen_tcp Read data using a listening tcp connection
 * GoodSource: A hardcoded string
 * BadSink: Web Display of data in web page after using replaceAll() to remove script tags, which will still allow XSS (CWE 182: Collapse of Data into Unsafe Value)
 * Flow Variant: 68 Data flow: data passed as a member variable in the "a" class, which is used by a method in another class in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE80_XSS
{
class CWE80_XSS__CWE182_Web_Listen_tcp_68b
{
#if (!OMITBAD)
    public static void BadSink(HttpRequest req, HttpResponse resp)
    {
        string data = CWE80_XSS__CWE182_Web_Listen_tcp_68a.data;
        if (data != null)
        {
            /* POTENTIAL FLAW: Display of data in web page after using Replace() to remove script tags, which will still allow XSS with strings like <scr<script>ipt> (CWE 182: Collapse of Data into Unsafe Value) */
            resp.Write("<br>Bad(): data = " + data.Replace("(<script>)", ""));
        }
    }
#endif


}
}
