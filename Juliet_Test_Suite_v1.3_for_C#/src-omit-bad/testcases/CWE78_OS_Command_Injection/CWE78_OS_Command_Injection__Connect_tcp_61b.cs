/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE78_OS_Command_Injection__Connect_tcp_61b.cs
Label Definition File: CWE78_OS_Command_Injection.label.xml
Template File: sources-sink-61b.tmpl.cs
*/
/*
 * @description
 * CWE: 78 OS Command Injection
 * BadSource: Connect_tcp Read data using an outbound tcp connection
 * GoodSource: A hardcoded string
 * Sinks: exec
 *    BadSink : dynamic command execution with Runtime.getRuntime().exec()
 * Flow Variant: 61 Data flow: data returned from one method to another in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

using System.IO;
using System.Net.Sockets;

namespace testcases.CWE78_OS_Command_Injection
{

class CWE78_OS_Command_Injection__Connect_tcp_61b
{


#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink */
    public static string GoodG2BSource()
    {
        string data;
        /* FIX: Use a hardcoded string */
        data = "foo";
        return data;
    }
#endif
}
}