/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE78_OS_Command_Injection__Connect_tcp_72a.cs
Label Definition File: CWE78_OS_Command_Injection.label.xml
Template File: sources-sink-72a.tmpl.cs
*/
/*
 * @description
 * CWE: 78 OS Command Injection
 * BadSource: Connect_tcp Read data using an outbound tcp connection
 * GoodSource: A hardcoded string
 * Sinks: exec
 *    BadSink : dynamic command execution with Runtime.getRuntime().exec()
 * Flow Variant: 72 Data flow: data passed in a Hashtable from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System.Collections;
using System;

using System.Web;

using System.IO;
using System.Net.Sockets;

namespace testcases.CWE78_OS_Command_Injection
{
class CWE78_OS_Command_Injection__Connect_tcp_72a : AbstractTestCase
{

#if (!OMITGOOD)
    public override void Good()
    {
        GoodG2B();
    }

    /* goodG2B() - use goodsource and badsink */
    private static void GoodG2B()
    {
        string data;
        /* FIX: Use a hardcoded string */
        data = "foo";
        Hashtable dataHashtable = new Hashtable(5);
        dataHashtable.Add(0, data);
        dataHashtable.Add(1, data);
        dataHashtable.Add(2, data);
        CWE78_OS_Command_Injection__Connect_tcp_72b.GoodG2BSink(dataHashtable  );
    }
#endif //omitgood
}
}