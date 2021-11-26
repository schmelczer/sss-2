/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE506_Embedded_Malicious_Code__screen_capture_05.cs
Label Definition File: CWE506_Embedded_Malicious_Code.badonly.label.xml
Template File: point-flaw-badonly-05.tmpl.cs
*/
/*
* @description
* CWE: 506 Embedded Malicious Code
* Sinks: screen_capture
*    BadSink : Perform a screen capture and save it to a file
*    BadOnly (No GoodSink)
* Flow Variant: 05 Control flow: if(privateTrue)
*
* */

using TestCaseSupport;
using System;

using System.Drawing;

namespace testcases.CWE506_Embedded_Malicious_Code
{
class CWE506_Embedded_Malicious_Code__screen_capture_05 : AbstractTestCaseBadOnly
{
    /* The variable below is not defined as "readonly", but is never
    * assigned any other value, so a tool should be able to identify that
    * reads of it will always return its initialized value.
    */
    private bool privateTrue = true;

}
}
