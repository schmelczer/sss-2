/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE80_XSS__CWE182_Web_Params_Get_Web_04.cs
Label Definition File: CWE80_XSS__CWE182_Web.label.xml
Template File: sources-sink-04.tmpl.cs
*/
/*
* @description
* CWE: 80 Cross Site Scripting (XSS)
* BadSource: Params_Get_Web Read data from a querystring using Params.Get()
* GoodSource: A hardcoded string
* BadSink: Web Display of data in web page after using replaceAll() to remove script tags, which will still allow XSS (CWE 182: Collapse of Data into Unsafe Value)
* Flow Variant: 04 Control flow: if(PRIVATE_CONST_TRUE) and if(PRIVATE_CONST_FALSE)
*
* */

using TestCaseSupport;
using System;

using System.Web;


namespace testcases.CWE80_XSS
{

class CWE80_XSS__CWE182_Web_Params_Get_Web_04 : AbstractTestCaseWeb
{

    /* The two variables below are declared "const", so a tool should
     * be able to identify that reads of these will always return their
     * initialized values.
     */
    private const bool PRIVATE_CONST_TRUE = true;
    private const bool PRIVATE_CONST_FALSE = false;
#if (!OMITBAD)
    /* uses badsource and badsink */
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data;
        if (PRIVATE_CONST_TRUE)
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
        if (data != null)
        {
            /* POTENTIAL FLAW: Display of data in web page after using Replace() to remove script tags, which will still allow XSS with strings like <scr<script>ipt> (CWE 182: Collapse of Data into Unsafe Value) */
            resp.Write("<br>Bad(): data = " + data.Replace("(<script>)", ""));
        }
    }
#endif //omitbad

}
}
