/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE506_Embedded_Malicious_Code__file_transfer_connect_tcp_03.cs
Label Definition File: CWE506_Embedded_Malicious_Code.badonly.label.xml
Template File: point-flaw-badonly-03.tmpl.cs
*/
/*
* @description
* CWE: 506 Embedded Malicious Code
* Sinks: file_transfer_connect_tcp
*    BadSink : Send file contents over the network using an outbound tcp connection
*    BadOnly (No GoodSink)
* Flow Variant: 03 Control flow: if(5==5)
*
* */

using TestCaseSupport;
using System;

using System.IO;
using System.Net.Sockets;

namespace testcases.CWE506_Embedded_Malicious_Code
{
class CWE506_Embedded_Malicious_Code__file_transfer_connect_tcp_03 : AbstractTestCaseBadOnly
{

}
}
