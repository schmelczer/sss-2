/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE506_Embedded_Malicious_Code__base64_encoded_payload_13.cs
Label Definition File: CWE506_Embedded_Malicious_Code.label.xml
Template File: point-flaw-13.tmpl.cs
*/
/*
* @description
* CWE: 506 Embedded Malicious Code
* Sinks: base64_encoded_payload
*    GoodSink: Use a plaintext command
*    BadSink : Use a base64 encoded payload in an attempt to hide the command
* Flow Variant: 13 Control flow: if(IO.STATIC_READONLY_FIVE==5) and if(IO.STATIC_READONLY_FIVE!=5)
*
* */

using TestCaseSupport;
using System;

using System.Diagnostics;
using System.IO;

namespace testcases.CWE506_Embedded_Malicious_Code
{
class CWE506_Embedded_Malicious_Code__base64_encoded_payload_13 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (IO.STATIC_READONLY_FIVE == 5)
        {
            /* FLAW: encoded "calc.exe" */
            string encodedPayload = "Y2FsYy5leGU=";
            byte[] data = Convert.FromBase64String(encodedPayload);
            string base64Decoded = System.Text.Encoding.ASCII.GetString(data);
            try
            {
                Process exeProcess = Process.Start(base64Decoded);
            }
            catch (IOException exceptIO)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error executing command");
            }
        }
    }
#endif //omitbad

}
}