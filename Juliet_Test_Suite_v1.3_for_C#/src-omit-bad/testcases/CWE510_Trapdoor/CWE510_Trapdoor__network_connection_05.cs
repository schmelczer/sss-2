/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE510_Trapdoor__network_connection_05.cs
Label Definition File: CWE510_Trapdoor.badonly.label.xml
Template File: point-flaw-badonly-05.tmpl.cs
*/
/*
* @description
* CWE: 510 Trapdoor
* Sinks: network_connection
*    BadSink : Presence of a network connection
*    BadOnly (No GoodSink)
* Flow Variant: 05 Control flow: if(privateTrue)
*
* */

using TestCaseSupport;
using System;

using System.IO;
using System.Net;

namespace testcases.CWE510_Trapdoor
{
class CWE510_Trapdoor__network_connection_05 : AbstractTestCaseBadOnly
{
    /* The variable below is not defined as "readonly", but is never
    * assigned any other value, so a tool should be able to identify that
    * reads of it will always return its initialized value.
    */
    private bool privateTrue = true;

}
}
