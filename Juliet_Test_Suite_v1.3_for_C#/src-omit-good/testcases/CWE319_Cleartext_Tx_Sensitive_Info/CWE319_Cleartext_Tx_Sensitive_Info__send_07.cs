/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE319_Cleartext_Tx_Sensitive_Info__send_07.cs
Label Definition File: CWE319_Cleartext_Tx_Sensitive_Info__send.label.xml
Template File: sources-sinks-07.tmpl.cs
*/
/*
* @description
* CWE: 319 Cleartext Transmission of Sensitive Information
* BadSource:  Establish data as a password
* GoodSource: Use a regular string (non-sensitive string)
* Sinks:
*    GoodSink: encrypted_channel
*    BadSink : unencrypted_channel
* Flow Variant: 07 Control flow: if(privateFive==5) and if(privateFive!=5)
*
* */

using TestCaseSupport;
using System;

using System.IO;
using System.Net.Sockets;
using System.Net.Security;
using System.Text;

using System.Security;

namespace testcases.CWE319_Cleartext_Tx_Sensitive_Info
{
class CWE319_Cleartext_Tx_Sensitive_Info__send_07 : AbstractTestCase
{

    /* The variable below is not declared "readonly", but is never assigned
     * any other value so a tool should be able to identify that reads of
     * this will always give its initialized value. */
    private int privateFive = 5;
#if (!OMITBAD)
    public override void Bad()
    {
        string data;
        if (privateFive==5)
        {
            using (SecureString securePwd = new SecureString())
            {
                for (int i = 0; i < "AP@ssw0rd".Length; i++)
                {
                    /* INCIDENTAL: CWE-798 Use of Hard-coded Credentials */
                    securePwd.AppendChar("AP@ssw0rd"[i]);
                }
                /* POTENTIAL FLAW: Set data to be a password, which can be transmitted over a non-secure
                 * channel in the sink */
                data = securePwd.ToString();
            }
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
        }
        if (privateFive==5)
        {
            try
            {
                using (TcpClient tcpClient = new TcpClient("remote_host", 1337))
                {
                    using (StreamWriter writer = new StreamWriter(tcpClient.GetStream()))
                    {
                        /* POTENTIAL FLAW: sending data over an unencrypted (non-SSL) channel */
                        writer.WriteLine(data);
                    }
                }
            }
            catch (IOException exceptIO)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, "Error writing to the TcpClient", exceptIO);
            }
        }
    }
#endif //omitbad

}
}
