/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE427_Uncontrolled_Search_Path_Element__Connect_tcp_51a.cs
Label Definition File: CWE427_Uncontrolled_Search_Path_Element.label.xml
Template File: sources-sink-51a.tmpl.cs
*/
/*
 * @description
 * CWE: 427 Uncontrolled Search Path Element
 * BadSource: Connect_tcp Read data using an outbound tcp connection
 * GoodSource: Use a hardcoded path
 * BadSink: Environment
 * Flow Variant: 51 Data flow: data passed as an argument from one function to another in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;
using System.Runtime.InteropServices;

using System.IO;
using System.Net.Sockets;

namespace testcases.CWE427_Uncontrolled_Search_Path_Element
{

class CWE427_Uncontrolled_Search_Path_Element__Connect_tcp_51a : AbstractTestCase
{

#if (!OMITGOOD)
    public override void Good()
    {
        GoodG2B();
    }

    /* goodG2B() - use goodsource and badsink */
    private void GoodG2B()
    {
        string data;
        /* FIX: Set the path as the "system" path */
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            data = "/bin";
        }
        else
        {
            data = "%SystemRoot%\\system32";
        }
        CWE427_Uncontrolled_Search_Path_Element__Connect_tcp_51b.GoodG2BSink(data  );
    }
#endif //omitgood
}
}
