/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE36_Absolute_Path_Traversal__NetClient_73b.cs
Label Definition File: CWE36_Absolute_Path_Traversal.label.xml
Template File: sources-sink-73b.tmpl.cs
*/
/*
 * @description
 * CWE: 36 Absolute Path Traversal
 * BadSource: NetClient Read data from a web server with WebClient
 * GoodSource: A hardcoded string
 * Sinks: readFile
 *    BadSink : read line from file from disk
 * Flow Variant: 73 Data flow: data passed in a LinkedList from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;
using System.Collections.Generic;

using System.IO;

using System.Web;

namespace testcases.CWE36_Absolute_Path_Traversal
{
class CWE36_Absolute_Path_Traversal__NetClient_73b
{
#if (!OMITBAD)
    public static void BadSink(LinkedList<string> dataLinkedList )
    {
        string data = dataLinkedList.Last.Value;
        /* POTENTIAL FLAW: unvalidated or sandboxed value */
        if (data != null)
        {
            if (File.Exists(data))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(data))
                    {
                        IO.WriteLine(sr.ReadLine());
                    }
                }
                catch (IOException exceptIO)
                {
                    IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error with stream reading");
                }
            }
        }
    }
#endif


}
}
