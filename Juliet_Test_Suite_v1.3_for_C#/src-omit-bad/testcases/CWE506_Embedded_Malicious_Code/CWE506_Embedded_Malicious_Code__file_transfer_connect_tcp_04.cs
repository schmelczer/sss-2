/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE506_Embedded_Malicious_Code__file_transfer_connect_tcp_04.cs
Label Definition File: CWE506_Embedded_Malicious_Code.badonly.label.xml
Template File: point-flaw-badonly-04.tmpl.cs
*/
/*
* @description
* CWE: 506 Embedded Malicious Code
* Sinks: file_transfer_connect_tcp
*    BadSink : Send file contents over the network using an outbound tcp connection
*    BadOnly (No GoodSink)
* Flow Variant: 04 Control flow: if(PRIVATE_CONST_TRUE)
*
* */

using TestCaseSupport;
using System;

using System.IO;
using System.Net.Sockets;

namespace testcases.CWE506_Embedded_Malicious_Code
{
class CWE506_Embedded_Malicious_Code__file_transfer_connect_tcp_04 : AbstractTestCaseBadOnly
{
    /* The variable below are is "const", so a tool should
     * be able to identify that reads of it will always return its
     * initialized value.
     */
    private const bool PRIVATE_CONST_TRUE = true;

}
}
