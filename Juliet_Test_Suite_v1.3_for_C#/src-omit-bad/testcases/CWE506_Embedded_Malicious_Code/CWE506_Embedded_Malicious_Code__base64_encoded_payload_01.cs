/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE506_Embedded_Malicious_Code__base64_encoded_payload_01.cs
Label Definition File: CWE506_Embedded_Malicious_Code.label.xml
Template File: point-flaw-01.tmpl.cs
*/
/*
* @description
* CWE: 506 Embedded Malicious Code
* Sinks: base64_encoded_payload
*    GoodSink: Use a plaintext command
*    BadSink : Use a base64 encoded payload in an attempt to hide the command
* Flow Variant: 01 Baseline
*
* */

using TestCaseSupport;
using System;

using System.Diagnostics;
using System.IO;

namespace testcases.CWE506_Embedded_Malicious_Code
{
class CWE506_Embedded_Malicious_Code__base64_encoded_payload_01 : AbstractTestCase
{

#if (!OMITGOOD)
    public override void Good()
    {
        Good1();
    }

    private void Good1()
    {
        /* FIX: plaintext command */
        String decodedPayload = "calc.exe";
        try
        {
            Process exeProcess = Process.Start(decodedPayload);
        }
        catch (IOException exceptIO)
        {
            IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error executing command");
        }
    }
#endif //omitgood
}
}
