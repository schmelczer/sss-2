/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE36_Absolute_Path_Traversal__NetClient_54d.cs
Label Definition File: CWE36_Absolute_Path_Traversal.label.xml
Template File: sources-sink-54d.tmpl.cs
*/
/*
 * @description
 * CWE: 36 Absolute Path Traversal
 * BadSource: NetClient Read data from a web server with WebClient
 * GoodSource: A hardcoded string
 * Sinks: readFile
 *    BadSink : read line from file from disk
 * Flow Variant: 54 Data flow: data passed as an argument from one method through three others to a fifth; all five functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE36_Absolute_Path_Traversal
{
class CWE36_Absolute_Path_Traversal__NetClient_54d
{
#if (!OMITBAD)
    public static void BadSink(string data )
    {
        CWE36_Absolute_Path_Traversal__NetClient_54e.BadSink(data );
    }
#endif


}
}
