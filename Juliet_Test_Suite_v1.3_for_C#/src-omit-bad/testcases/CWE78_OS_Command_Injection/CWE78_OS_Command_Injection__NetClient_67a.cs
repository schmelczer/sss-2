/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE78_OS_Command_Injection__NetClient_67a.cs
Label Definition File: CWE78_OS_Command_Injection.label.xml
Template File: sources-sink-67a.tmpl.cs
*/
/*
 * @description
 * CWE: 78 OS Command Injection
 * BadSource: NetClient Read data from a web server with WebClient
 * GoodSource: A hardcoded string
 * Sinks: exec
 *    BadSink : dynamic command execution with Runtime.getRuntime().exec()
 * Flow Variant: 67 Data flow: data passed in a class from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

using System.IO;
using System.Net;

namespace testcases.CWE78_OS_Command_Injection
{

class CWE78_OS_Command_Injection__NetClient_67a : AbstractTestCase
{

    public class Container
    {
        public string containerOne;
    }

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
        Container dataContainer = new Container();
        dataContainer.containerOne = data;
        CWE78_OS_Command_Injection__NetClient_67b.GoodG2BSink(dataContainer  );
    }
#endif //omitgood
}
}
