/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE477_Obsolete_Functions__Socket_TcpListener_03.cs
Label Definition File: CWE477_Obsolete_Functions.label.xml
Template File: point-flaw-03.tmpl.cs
*/
/*
* @description
* CWE: 477 Use of Obsolete Functions
* Sinks: Socket_TcpListener
*    GoodSink: Use of preferred System.Net.Sockets.TcpListener(IPAddress, Int32)
*    BadSink : Use of deprecated System.Net.Sockets.TcpListener(Int32)
* Flow Variant: 03 Control flow: if(5==5) and if(5!=5)
*
* */

using TestCaseSupport;
using System;

using System.Net;
using System.Net.Sockets;

namespace testcases.CWE477_Obsolete_Functions
{
class CWE477_Obsolete_Functions__Socket_TcpListener_03 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (5 == 5)
        {
            /* FLAW: Use of deprecated Sockets.TcpListener(Int32) */
            TcpListener tcpListener = new TcpListener(13);
        }
    }
#endif //omitbad

}
}
