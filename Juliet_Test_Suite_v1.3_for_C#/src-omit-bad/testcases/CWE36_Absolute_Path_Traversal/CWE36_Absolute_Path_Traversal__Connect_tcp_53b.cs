/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE36_Absolute_Path_Traversal__Connect_tcp_53b.cs
Label Definition File: CWE36_Absolute_Path_Traversal.label.xml
Template File: sources-sink-53b.tmpl.cs
*/
/*
 * @description
 * CWE: 36 Absolute Path Traversal
 * BadSource: Connect_tcp Read data using an outbound tcp connection
 * GoodSource: A hardcoded string
 * Sinks: readFile
 *    BadSink : read line from file from disk
 * Flow Variant: 53 Data flow: data passed as an argument from one method through two others to a fourth; all four functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE36_Absolute_Path_Traversal
{
class CWE36_Absolute_Path_Traversal__Connect_tcp_53b
{


#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink */
    public static void GoodG2BSink(string data )
    {
        CWE36_Absolute_Path_Traversal__Connect_tcp_53c.GoodG2BSink(data );
    }
#endif
}
}
