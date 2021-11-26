/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE506_Embedded_Malicious_Code__file_transfer_connect_tcp_07.cs
Label Definition File: CWE506_Embedded_Malicious_Code.badonly.label.xml
Template File: point-flaw-badonly-07.tmpl.cs
*/
/*
* @description
* CWE: 506 Embedded Malicious Code
* Sinks: file_transfer_connect_tcp
*    BadSink : Send file contents over the network using an outbound tcp connection
*    BadOnly (No GoodSink)
* Flow Variant: 07 Control flow: if(privateFive==5)
*
* */

using TestCaseSupport;
using System;

using System.IO;
using System.Net.Sockets;

namespace testcases.CWE506_Embedded_Malicious_Code
{
class CWE506_Embedded_Malicious_Code__file_transfer_connect_tcp_07 : AbstractTestCaseBadOnly
{
    /* The variable below is not declared "readonly", but is never assigned
     * any other value so a tool should be able to identify that reads of
     * this will always give its initialized value.
     */
    private int privateFive = 5;

}
}
