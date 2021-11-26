/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE369_Divide_by_Zero__int_QueryString_Web_modulo_04.cs
Label Definition File: CWE369_Divide_by_Zero__int.label.xml
Template File: sources-sinks-04.tmpl.cs
*/
/*
* @description
* CWE: 369 Divide by zero
* BadSource: QueryString_Web Parse id param out of the URL query string (without using getParameter())
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: modulo
*    GoodSink: Check for zero before modulo
*    BadSink : Modulo by a value that may be zero
* Flow Variant: 04 Control flow: if(PRIVATE_CONST_TRUE) and if(PRIVATE_CONST_FALSE)
*
* */

using TestCaseSupport;
using System;

using System.Web;


namespace testcases.CWE369_Divide_by_Zero
{
class CWE369_Divide_by_Zero__int_QueryString_Web_modulo_04 : AbstractTestCaseWeb
{

    /* The two variables below are declared "const", so a tool should
     * be able to identify that reads of these will always return their
     * initialized values.
     */
    private const bool PRIVATE_CONST_TRUE = true;
    private const bool PRIVATE_CONST_FALSE = false;
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        int data;
        if (PRIVATE_CONST_TRUE)
        {
            data = int.MinValue; /* initialize data in case id is not in query string */
            /* POTENTIAL FLAW: Parse id param out of the URL querystring (without using getParam) */
            {
                if (req.QueryString["id"] != null)
                {
                    try
                    {
                        data = int.Parse(req.QueryString["id"]);
                    }
                    catch (FormatException exceptNumberFormat)
                    {
                        IO.Logger.Log(NLog.LogLevel.Warn, exceptNumberFormat, "Number format exception reading id from query string");
                    }
                }
            }
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = 0;
        }
        if (PRIVATE_CONST_TRUE)
        {
            /* POTENTIAL FLAW: Zero modulus will cause an issue.  An integer division will
            result in an exception.  */
            IO.WriteLine("100%" + data + " = " + (100 % data) + "\n");
        }
    }
#endif //omitbad

}
}
