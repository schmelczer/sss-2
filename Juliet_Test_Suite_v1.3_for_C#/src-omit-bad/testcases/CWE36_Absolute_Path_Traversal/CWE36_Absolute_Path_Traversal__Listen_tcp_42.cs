/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE36_Absolute_Path_Traversal__Listen_tcp_42.cs
Label Definition File: CWE36_Absolute_Path_Traversal.label.xml
Template File: sources-sink-42.tmpl.cs
*/
/*
 * @description
 * CWE: 36 Absolute Path Traversal
 * BadSource: Listen_tcp Read data using a listening tcp connection
 * GoodSource: A hardcoded string
 * BadSink: readFile read line from file from disk
 * Flow Variant: 42 Data flow: data returned from one method to another in the same class
 *
 * */

using TestCaseSupport;
using System;

using System.IO;

using System.Web;

using System.Net.Sockets;
using System.Net;

namespace testcases.CWE36_Absolute_Path_Traversal
{

class CWE36_Absolute_Path_Traversal__Listen_tcp_42 : AbstractTestCase
{

#if (!OMITGOOD)
    private static string GoodG2BSource()
    {
        string data;
        /* FIX: Use a hardcoded string */
        data = "foo";
        return data;
    }

    /* goodG2B() - use goodsource and badsink */
    private static void GoodG2B()
    {
        string data = GoodG2BSource();
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

    public override void Good()
    {
        GoodG2B();
    }
#endif //omitgood
}
}
