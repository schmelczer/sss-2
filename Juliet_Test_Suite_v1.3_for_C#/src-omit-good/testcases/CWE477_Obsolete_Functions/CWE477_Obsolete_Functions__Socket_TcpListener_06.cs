/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE477_Obsolete_Functions__Socket_TcpListener_06.cs
Label Definition File: CWE477_Obsolete_Functions.label.xml
Template File: point-flaw-06.tmpl.cs
*/
/*
* @description
* CWE: 477 Use of Obsolete Functions
* Sinks: Socket_TcpListener
*    GoodSink: Use of preferred System.Net.Sockets.TcpListener(IPAddress, Int32)
*    BadSink : Use of deprecated System.Net.Sockets.TcpListener(Int32)
* Flow Variant: 06 Control flow: if(PRIVATE_CONST_FIVE==5) and if(PRIVATE_CONST_FIVE!=5)
*
* */

using TestCaseSupport;
using System;

using System.Net;
using System.Net.Sockets;

namespace testcases.CWE477_Obsolete_Functions
{
class CWE477_Obsolete_Functions__Socket_TcpListener_06 : AbstractTestCase
{
    /* The variable below is declared "const", so a tool should be able
     * to identify that reads of this will always give its initialized
     * value.
     */
    private const int PRIVATE_CONST_FIVE = 5;
#if (!OMITBAD)
    public override void Bad()
    {
        if (PRIVATE_CONST_FIVE == 5)
        {
            /* FLAW: Use of deprecated Sockets.TcpListener(Int32) */
            TcpListener tcpListener = new TcpListener(13);
        }
    }
#endif //omitbad

}
}
