/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE369_Divide_by_Zero__int_Params_Get_Web_modulo_22b.cs
Label Definition File: CWE369_Divide_by_Zero__int.label.xml
Template File: sources-sinks-22b.tmpl.cs
*/
/*
 * @description
 * CWE: 369 Divide by zero
 * BadSource: Params_Get_Web Read data from a querystring using Params.Get()
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: modulo
 *    GoodSink: Check for zero before modulo
 *    BadSink : Modulo by a value that may be zero
 * Flow Variant: 22 Control flow: Flow controlled by value of a public static variable. Sink functions are in a separate file from sources.
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE369_Divide_by_Zero
{
class CWE369_Divide_by_Zero__int_Params_Get_Web_modulo_22b
{
#if (!OMITBAD)
    public static void BadSink(int data , HttpRequest req, HttpResponse resp)
    {
        if (CWE369_Divide_by_Zero__int_Params_Get_Web_modulo_22a.badPublicStatic)
        {
            /* POTENTIAL FLAW: Zero modulus will cause an issue.  An integer division will
            result in an exception.  */
            IO.WriteLine("100%" + data + " = " + (100 % data) + "\n");
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = 0;
        }
    }
#endif


}
}
