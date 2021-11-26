/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE78_OS_Command_Injection__NetClient_54d.cs
Label Definition File: CWE78_OS_Command_Injection.label.xml
Template File: sources-sink-54d.tmpl.cs
*/
/*
 * @description
 * CWE: 78 OS Command Injection
 * BadSource: NetClient Read data from a web server with WebClient
 * GoodSource: A hardcoded string
 * Sinks: exec
 *    BadSink : dynamic command execution with Runtime.getRuntime().exec()
 * Flow Variant: 54 Data flow: data passed as an argument from one method through three others to a fifth; all five functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE78_OS_Command_Injection
{
class CWE78_OS_Command_Injection__NetClient_54d
{
#if (!OMITBAD)
    public static void BadSink(string data )
    {
        CWE78_OS_Command_Injection__NetClient_54e.BadSink(data );
    }
#endif


}
}