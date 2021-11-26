/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE369_Divide_by_Zero__float_listen_tcp_modulo_52c.cs
Label Definition File: CWE369_Divide_by_Zero__float.label.xml
Template File: sources-sinks-52c.tmpl.cs
*/
/*
 * @description
 * CWE: 369 Divide by zero
 * BadSource: listen_tcp Read data using a listening tcp connection
 * GoodSource: A hardcoded non-zero number (two)
 * Sinks: modulo
 *    GoodSink: Check for zero before modulo
 *    BadSink : Modulo by a value that may be zero
 * Flow Variant: 52 Data flow: data passed as an argument from one method to another to another in three different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE369_Divide_by_Zero
{
class CWE369_Divide_by_Zero__float_listen_tcp_modulo_52c
{
#if (!OMITBAD)
    public static void BadSink(float data )
    {
        /* POTENTIAL FLAW: Possibly modulo by zero */
        int result = (int)(100.0 % data);
        IO.WriteLine(result);
    }
#endif


}
}
