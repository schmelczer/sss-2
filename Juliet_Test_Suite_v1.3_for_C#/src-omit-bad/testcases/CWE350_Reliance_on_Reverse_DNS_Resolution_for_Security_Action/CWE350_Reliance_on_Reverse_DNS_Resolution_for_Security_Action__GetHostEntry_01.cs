/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE350_Reliance_on_Reverse_DNS_Resolution_for_Security_Action__GetHostEntry_01.cs
Label Definition File: CWE350_Reliance_on_Reverse_DNS_Resolution_for_Security_Action__GetHostEntry.label.xml
Template File: point-flaw-01.tmpl.cs
*/
/*
* @description
* CWE: 350 Reliance on Reverse DNS Resolution for Security Action
* Sinks: GetHostEntry
*    GoodSink: Log host name without using it in a security decision
*    BadSink : Use the reverse DNS of the client to determine whether to allow the connection
* Flow Variant: 01 Baseline
*
* */

using TestCaseSupport;
using System;

using System.Net;

namespace testcases.CWE350_Reliance_on_Reverse_DNS_Resolution_for_Security_Action
{
class CWE350_Reliance_on_Reverse_DNS_Resolution_for_Security_Action__GetHostEntry_01 : AbstractTestCase
{

#if (!OMITGOOD)
    public override void Good()
    {
        Good1();
    }

    private void Good1()
    {
        string secret_hostname = "www.domain.nonexistanttld";
        IPAddress hostIPAddress = IPAddress.Parse("127.0.0.1");
        IPHostEntry hostInfo = Dns.GetHostEntry(hostIPAddress);
        /* FIX: Copy the host name to a log - do not attempt to use the host name in a security decision */
        if (hostInfo.HostName.Equals(secret_hostname))
        {
            IO.Logger.Log(NLog.LogLevel.Info, hostInfo.HostName);
        }
    }
#endif //omitgood
}
}
