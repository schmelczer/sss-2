/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE470_Unsafe_Reflection__Web_QueryString_Web_03.cs
Label Definition File: CWE470_Unsafe_Reflection__Web.label.xml
Template File: sources-sink-03.tmpl.cs
*/
/*
* @description
* CWE: 470 Use of Externally-Controlled Input to Select Classes or Code ('Unsafe Reflection')
* BadSource: QueryString_Web Parse id param out of the URL query string (without using getParameter())
* GoodSource: Set data to a hardcoded class name
* BadSink:  Instantiate class named in data
* Flow Variant: 03 Control flow: if(5==5) and if(5!=5)
*
* */

using TestCaseSupport;
using System;

using System.Web;


namespace testcases.CWE470_Unsafe_Reflection
{

class CWE470_Unsafe_Reflection__Web_QueryString_Web_03 : AbstractTestCaseWeb
{
#if (!OMITBAD)
    /* uses badsource and badsink */
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        if (5 == 5)
        {
            data = ""; /* initialize data in case id is not in query string */
            /* POTENTIAL FLAW: Parse id param out of the URL querystring (without using getParameter()) */
            {
                if (req.QueryString["id"] != null)
                {
                    data = req.QueryString["id"];
                }
            }
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
        }
        /* POTENTIAL FLAW: Instantiate object of class named in data (which may be from external input) */
        var container = Activator.CreateInstance(null, data);
        Object tempClassObj = container.Unwrap();
        IO.WriteLine(tempClassObj.GetType().ToString()); /* Use tempClassObj in some way */
    }
#endif //omitbad

}
}
