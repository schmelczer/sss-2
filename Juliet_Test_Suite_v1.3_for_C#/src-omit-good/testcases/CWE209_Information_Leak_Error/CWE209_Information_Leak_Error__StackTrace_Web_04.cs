/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE209_Information_Leak_Error__StackTrace_Web_04.cs
Label Definition File: CWE209_Information_Leak_Error.label.xml
Template File: point-flaw-04.tmpl.cs
*/
/*
* @description
* CWE: 209 Information exposure through error message
* Sinks: StackTrace_Web
*    GoodSink: Print generic error message to console
*    BadSink : Print stack trace to console
* Flow Variant: 04 Control flow: if(PRIVATE_CONST_TRUE) and if(PRIVATE_CONST_FALSE)
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE209_Information_Leak_Error
{
class CWE209_Information_Leak_Error__StackTrace_Web_04 : AbstractTestCaseWeb
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
        if (PRIVATE_CONST_TRUE)
        {
            try
            {
                throw new InvalidOperationException();
            }
            catch (InvalidOperationException exceptInvalidOperationException)
            {
                resp.Write(exceptInvalidOperationException.ToString()); /* FLAW: Print stack trace in response on error */
            }
        }
    }
#endif //omitbad

}
}
