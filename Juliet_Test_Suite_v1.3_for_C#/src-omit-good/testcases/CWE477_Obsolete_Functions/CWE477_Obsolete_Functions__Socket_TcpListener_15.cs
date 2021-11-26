/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE477_Obsolete_Functions__Socket_TcpListener_15.cs
Label Definition File: CWE477_Obsolete_Functions.label.xml
Template File: point-flaw-15.tmpl.cs
*/
/*
* @description
* CWE: 477 Use of Obsolete Functions
* Sinks: Socket_TcpListener
*    GoodSink: Use of preferred System.Net.Sockets.TcpListener(IPAddress, Int32)
*    BadSink : Use of deprecated System.Net.Sockets.TcpListener(Int32)
* Flow Variant: 15 Control flow: switch(7)
*
* */

using TestCaseSupport;
using System;

using System.Net;
using System.Net.Sockets;

namespace testcases.CWE477_Obsolete_Functions
{
class CWE477_Obsolete_Functions__Socket_TcpListener_15 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        switch (7)
        {
        case 7:
            /* FLAW: Use of deprecated Sockets.TcpListener(Int32) */
            TcpListener tcpListener = new TcpListener(13);
            break;
        default:
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
            break;
        }
    }
#endif //omitbad

}
}
