/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE80_XSS__Web_ReadLine_74b.cs
Label Definition File: CWE80_XSS__Web.label.xml
Template File: sources-sink-74b.tmpl.cs
*/
/*
 * @description
 * CWE: 80 Cross Site Scripting (XSS)
 * BadSource: ReadLine Read data from the console using ReadLine()
 * GoodSource: A hardcoded string
 * Sinks: Web
 *    BadSink : Display of data in web page without any encoding or validation
 * Flow Variant: 74 Data flow: data passed in a Dictionary from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System.Collections.Generic;
using System;

using System.Web;

namespace testcases.CWE80_XSS
{
class CWE80_XSS__Web_ReadLine_74b
{
#if (!OMITBAD)
    public static void BadSink(Dictionary<int,string> dataDictionary , HttpRequest req, HttpResponse resp)
    {
        string data = dataDictionary[2];
        if (data != null)
        {
            /* POTENTIAL FLAW: Display of data in web page without any encoding or validation */
            resp.Write("<br>Bad(): data = " + data);
        }
    }
#endif


}
}
