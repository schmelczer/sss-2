/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE470_Unsafe_Reflection__Web_Params_Get_Web_05.cs
Label Definition File: CWE470_Unsafe_Reflection__Web.label.xml
Template File: sources-sink-05.tmpl.cs
*/
/*
* @description
* CWE: 470 Use of Externally-Controlled Input to Select Classes or Code ('Unsafe Reflection')
* BadSource: Params_Get_Web Read data from a querystring using Params.Get()
* GoodSource: Set data to a hardcoded class name
* BadSink:  Instantiate class named in data
* Flow Variant: 05 Control flow: if(privateTrue) and if(privateFalse)
*
* */

using TestCaseSupport;
using System;

using System.Web;


namespace testcases.CWE470_Unsafe_Reflection
{

class CWE470_Unsafe_Reflection__Web_Params_Get_Web_05 : AbstractTestCaseWeb
{

    /* The two variables below are not defined as "readonly", but are never
     * assigned any other value, so a tool should be able to identify that
     * reads of these will always return their initialized values.
     */
    private bool privateTrue = true;
    private bool privateFalse = false;
#if (!OMITBAD)
    /* uses badsource and badsink */
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        if (privateTrue)
        {
            /* POTENTIAL FLAW: Read data from a querystring using Params.Get */
            data = req.Params.Get("name");
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
