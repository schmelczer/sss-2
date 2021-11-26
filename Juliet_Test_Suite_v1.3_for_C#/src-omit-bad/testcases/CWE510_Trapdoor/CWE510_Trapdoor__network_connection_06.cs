/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE510_Trapdoor__network_connection_06.cs
Label Definition File: CWE510_Trapdoor.badonly.label.xml
Template File: point-flaw-badonly-06.tmpl.cs
*/
/*
* @description
* CWE: 510 Trapdoor
* Sinks: network_connection
*    BadSink : Presence of a network connection
*    BadOnly (No GoodSink)
* Flow Variant: 06 Control flow: if(PRIVATE_CONST_FIVE==5)
*
* */

using TestCaseSupport;
using System;

using System.IO;
using System.Net;

namespace testcases.CWE510_Trapdoor
{
class CWE510_Trapdoor__network_connection_06 : AbstractTestCaseBadOnly
{
    /* The variable below is declared "const", so a tool should be able
     * to identify that reads of this will always give its initialized
     * value.
     */
    private const int PRIVATE_CONST_FIVE = 5;

}
}
