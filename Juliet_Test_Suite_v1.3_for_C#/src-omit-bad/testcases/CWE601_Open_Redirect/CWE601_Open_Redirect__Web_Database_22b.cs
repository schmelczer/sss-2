/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE601_Open_Redirect__Web_Database_22b.cs
Label Definition File: CWE601_Open_Redirect__Web.label.xml
Template File: sources-sink-22b.tmpl.cs
*/
/*
 * @description
 * CWE: 601 Open Redirect
 * BadSource: Database Read data from a database
 * GoodSource: A hardcoded string
 * Sinks:
 *    BadSink : place redirect string directly into redirect api call
 * Flow Variant: 22 Control flow: Flow controlled by value of a public static variable. Sink functions are in a separate file from sources.
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

using System.Data.SqlClient;

namespace testcases.CWE601_Open_Redirect
{

class CWE601_Open_Redirect__Web_Database_22b
{


#if (!OMITGOOD)
    /* goodG2B1() - use goodsource and badsink by setting the static variable to false instead of true */
    public static string GoodG2B1Source(HttpRequest req, HttpResponse resp)
    {
        string data;
        if (CWE601_Open_Redirect__Web_Database_22a.goodG2B1PublicStatic)
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
        }
        else
        {
            /* FIX: Use a hardcoded string */
            data = "foo";
        }
        return data;
    }

    /* GoodG2B2() - use goodsource and badsink by reversing the blocks in the if in the sink function */
    public static string GoodG2B2Source(HttpRequest req, HttpResponse resp)
    {
        string data;
        if (CWE601_Open_Redirect__Web_Database_22a.GoodG2B2PublicStatic)
        {
            /* FIX: Use a hardcoded string */
            data = "foo";
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
        }
        return data;
    }
#endif
}
}
