/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE209_Information_Leak_Error__StackTrace_Web_08.cs
Label Definition File: CWE209_Information_Leak_Error.label.xml
Template File: point-flaw-08.tmpl.cs
*/
/*
* @description
* CWE: 209 Information exposure through error message
* Sinks: StackTrace_Web
*    GoodSink: Print generic error message to console
*    BadSink : Print stack trace to console
* Flow Variant: 08 Control flow: if(PrivateReturnsTrue()) and if(PrivateReturnsFalse())
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE209_Information_Leak_Error
{
class CWE209_Information_Leak_Error__StackTrace_Web_08 : AbstractTestCaseWeb
{
    /* The methods below always return the same value, so a tool
     * should be able to figure out that every call to these
     * methods will return true or return false.
     */
    private static bool PrivateReturnsTrue()
    {
        return true;
    }

    private static bool PrivateReturnsFalse()
    {
        return false;
    }
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        if (PrivateReturnsTrue())
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
