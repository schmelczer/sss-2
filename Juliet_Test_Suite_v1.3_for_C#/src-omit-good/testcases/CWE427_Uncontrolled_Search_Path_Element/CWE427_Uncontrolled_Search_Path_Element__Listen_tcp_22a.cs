/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE427_Uncontrolled_Search_Path_Element__Listen_tcp_22a.cs
Label Definition File: CWE427_Uncontrolled_Search_Path_Element.label.xml
Template File: sources-sink-22a.tmpl.cs
*/
/*
 * @description
 * CWE: 427 Uncontrolled Search Path Element
 * BadSource: Listen_tcp Read data using a listening tcp connection
 * GoodSource: Use a hardcoded path
 * Sinks: Environment
 *    BadSink :
 * Flow Variant: 22 Control flow: Flow controlled by value of a public static variable. Sink functions are in a separate file from sources.
 *
 * */

using TestCaseSupport;
using System;

using System.Web;
using System.Runtime.InteropServices;

namespace testcases.CWE427_Uncontrolled_Search_Path_Element
{
class CWE427_Uncontrolled_Search_Path_Element__Listen_tcp_22a : AbstractTestCase
{

    /* The public static variable below is used to drive control flow in the source function.
     * The public static variable mimics a global variable in the C/C++ language family. */
    public static bool badPublicStatic = false;
#if (!OMITBAD)
    public override void Bad()
    {
        string data;
        badPublicStatic = true;
        data = CWE427_Uncontrolled_Search_Path_Element__Listen_tcp_22b.BadSource();
        /* POTENTIAL FLAW: Set a new environment variable with a path that is possibly insecure */
        Environment.SetEnvironmentVariable("PATH", data);
    }
#endif //omitbad
    /* The public static variables below are used to drive control flow in the source functions.
     * The public static variable mimics a global variable in the C/C++ language family. */
    public static bool goodG2B1PublicStatic = false;
    public static bool GoodG2B2PublicStatic = false;

}
}
