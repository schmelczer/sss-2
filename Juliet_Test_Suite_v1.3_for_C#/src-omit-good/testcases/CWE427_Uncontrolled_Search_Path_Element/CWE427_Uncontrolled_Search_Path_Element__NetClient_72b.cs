/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE427_Uncontrolled_Search_Path_Element__NetClient_72b.cs
Label Definition File: CWE427_Uncontrolled_Search_Path_Element.label.xml
Template File: sources-sink-72b.tmpl.cs
*/
/*
 * @description
 * CWE: 427 Uncontrolled Search Path Element
 * BadSource: NetClient Read data from a web server with WebClient
 * GoodSource: Use a hardcoded path
 * Sinks: Environment
 *    BadSink :
 * Flow Variant: 72 Data flow: data passed in a Hashtable from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System.Collections;
using System;

using System.Web;
using System.Runtime.InteropServices;

namespace testcases.CWE427_Uncontrolled_Search_Path_Element
{
class CWE427_Uncontrolled_Search_Path_Element__NetClient_72b
{
#if (!OMITBAD)
    public static void BadSink(Hashtable dataHashtable )
    {
        string data = (string) dataHashtable[2];
        /* POTENTIAL FLAW: Set a new environment variable with a path that is possibly insecure */
        Environment.SetEnvironmentVariable("PATH", data);
    }
#endif


}
}