/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE80_XSS__Web_File_68b.cs
Label Definition File: CWE80_XSS__Web.label.xml
Template File: sources-sink-68b.tmpl.cs
*/
/*
 * @description
 * CWE: 80 Cross Site Scripting (XSS)
 * BadSource: File Read data from file (named data.txt)
 * GoodSource: A hardcoded string
 * BadSink: Web Display of data in web page without any encoding or validation
 * Flow Variant: 68 Data flow: data passed as a member variable in the "a" class, which is used by a method in another class in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE80_XSS
{
class CWE80_XSS__Web_File_68b
{


#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink */
    public static void GoodG2BSink(HttpRequest req, HttpResponse resp)
    {
        string data = CWE80_XSS__Web_File_68a.data;
        if (data != null)
        {
            /* POTENTIAL FLAW: Display of data in web page without any encoding or validation */
            resp.Write("<br>Bad(): data = " + data);
        }
    }
#endif
}
}
