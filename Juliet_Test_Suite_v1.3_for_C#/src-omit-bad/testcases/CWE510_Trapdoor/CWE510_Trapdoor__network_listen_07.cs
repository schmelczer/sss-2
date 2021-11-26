/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE510_Trapdoor__network_listen_07.cs
Label Definition File: CWE510_Trapdoor.badonly.label.xml
Template File: point-flaw-badonly-07.tmpl.cs
*/
/*
* @description
* CWE: 510 Trapdoor
* Sinks: network_listen
*    BadSink : Presence of a network listener
*    BadOnly (No GoodSink)
* Flow Variant: 07 Control flow: if(privateFive==5)
*
* */

using TestCaseSupport;
using System;

using System.IO;
using System.Net.Sockets;
using System.Net;

namespace testcases.CWE510_Trapdoor
{
class CWE510_Trapdoor__network_listen_07 : AbstractTestCaseBadOnly
{
    /* The variable below is not declared "readonly", but is never assigned
     * any other value so a tool should be able to identify that reads of
     * this will always give its initialized value.
     */
    private int privateFive = 5;

}
}
