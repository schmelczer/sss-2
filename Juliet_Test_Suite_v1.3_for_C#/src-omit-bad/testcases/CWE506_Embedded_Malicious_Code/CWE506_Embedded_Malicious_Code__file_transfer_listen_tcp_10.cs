/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE506_Embedded_Malicious_Code__file_transfer_listen_tcp_10.cs
Label Definition File: CWE506_Embedded_Malicious_Code.badonly.label.xml
Template File: point-flaw-badonly-10.tmpl.cs
*/
/*
* @description
* CWE: 506 Embedded Malicious Code
* Sinks: file_transfer_listen_tcp
*    BadSink : Send file contents over the network using a listening tcp connection
*    BadOnly (No GoodSink)
* Flow Variant: 10 Control flow: if(IO.staticTrue)
*
* */

using TestCaseSupport;
using System;

using System.IO;
using System.Net.Sockets;
using System.Net;

namespace testcases.CWE506_Embedded_Malicious_Code
{
class CWE506_Embedded_Malicious_Code__file_transfer_listen_tcp_10 : AbstractTestCaseBadOnly
{

}
}
