/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE510_Trapdoor__network_listen_04.cs
Label Definition File: CWE510_Trapdoor.badonly.label.xml
Template File: point-flaw-badonly-04.tmpl.cs
*/
/*
* @description
* CWE: 510 Trapdoor
* Sinks: network_listen
*    BadSink : Presence of a network listener
*    BadOnly (No GoodSink)
* Flow Variant: 04 Control flow: if(PRIVATE_CONST_TRUE)
*
* */

using TestCaseSupport;
using System;

using System.IO;
using System.Net.Sockets;
using System.Net;

namespace testcases.CWE510_Trapdoor
{
class CWE510_Trapdoor__network_listen_04 : AbstractTestCaseBadOnly
{
    /* The variable below are is "const", so a tool should
     * be able to identify that reads of it will always return its
     * initialized value.
     */
    private const bool PRIVATE_CONST_TRUE = true;

}
}
