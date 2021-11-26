/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE506_Embedded_Malicious_Code__screen_capture_06.cs
Label Definition File: CWE506_Embedded_Malicious_Code.badonly.label.xml
Template File: point-flaw-badonly-06.tmpl.cs
*/
/*
* @description
* CWE: 506 Embedded Malicious Code
* Sinks: screen_capture
*    BadSink : Perform a screen capture and save it to a file
*    BadOnly (No GoodSink)
* Flow Variant: 06 Control flow: if(PRIVATE_CONST_FIVE==5)
*
* */

using TestCaseSupport;
using System;

using System.Drawing;

namespace testcases.CWE506_Embedded_Malicious_Code
{
class CWE506_Embedded_Malicious_Code__screen_capture_06 : AbstractTestCaseBadOnly
{
    /* The variable below is declared "const", so a tool should be able
     * to identify that reads of this will always give its initialized
     * value.
     */
    private const int PRIVATE_CONST_FIVE = 5;

}
}
