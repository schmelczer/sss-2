/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE80_XSS__Web_ReadLine_72a.cs
Label Definition File: CWE80_XSS__Web.label.xml
Template File: sources-sink-72a.tmpl.cs
*/
/*
 * @description
 * CWE: 80 Cross Site Scripting (XSS)
 * BadSource: ReadLine Read data from the console using ReadLine()
 * GoodSource: A hardcoded string
 * Sinks: Web
 *    BadSink : Display of data in web page without any encoding or validation
 * Flow Variant: 72 Data flow: data passed in a Hashtable from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System.Collections;
using System;

using System.Web;

using System.IO;

namespace testcases.CWE80_XSS
{
class CWE80_XSS__Web_ReadLine_72a : AbstractTestCaseWeb
{

#if (!OMITGOOD)
    public override void Good(HttpRequest req, HttpResponse resp)
    {
        GoodG2B(req, resp);
    }

    /* goodG2B() - use goodsource and badsink */
    private static void GoodG2B(HttpRequest req, HttpResponse resp)
    {
        string data;
        /* FIX: Use a hardcoded string */
        data = "foo";
        Hashtable dataHashtable = new Hashtable(5);
        dataHashtable.Add(0, data);
        dataHashtable.Add(1, data);
        dataHashtable.Add(2, data);
        CWE80_XSS__Web_ReadLine_72b.GoodG2BSink(dataHashtable , req, resp );
    }
#endif //omitgood
}
}
