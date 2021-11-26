/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE23_Relative_Path_Traversal__NetClient_66a.cs
Label Definition File: CWE23_Relative_Path_Traversal.label.xml
Template File: sources-sink-66a.tmpl.cs
*/
/*
 * @description
 * CWE: 23 Relative Path Traversal
 * BadSource: NetClient Read data from a web server with WebClient
 * GoodSource: A hardcoded string
 * Sinks: readFile
 *    BadSink : no validation
 * Flow Variant: 66 Data flow: data passed in an array from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

using System.IO;
using System.Net;

namespace testcases.CWE23_Relative_Path_Traversal
{

class CWE23_Relative_Path_Traversal__NetClient_66a : AbstractTestCase
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
        string[] dataArray = new string[5];
        dataArray[2] = data;
        CWE23_Relative_Path_Traversal__NetClient_66b.GoodG2BSink(dataArray  );
    }
#endif //omitgood
}
}
