/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE350_Reliance_on_Reverse_DNS_Resolution_for_Security_Action__GetHostEntry_09.cs
Label Definition File: CWE350_Reliance_on_Reverse_DNS_Resolution_for_Security_Action__GetHostEntry.label.xml
Template File: point-flaw-09.tmpl.cs
*/
/*
* @description
* CWE: 350 Reliance on Reverse DNS Resolution for Security Action
* Sinks: GetHostEntry
*    GoodSink: Log host name without using it in a security decision
*    BadSink : Use the reverse DNS of the client to determine whether to allow the connection
* Flow Variant: 09 Control flow: if(IO.STATIC_READONLY_TRUE) and if(IO.STATIC_READONLY_FALSE)
*
* */

using TestCaseSupport;
using System;

using System.Net;

namespace testcases.CWE350_Reliance_on_Reverse_DNS_Resolution_for_Security_Action
{
class CWE350_Reliance_on_Reverse_DNS_Resolution_for_Security_Action__GetHostEntry_09 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (IO.STATIC_READONLY_TRUE)
        {
            string secret_hostname = "www.domain.nonexistanttld";
            IPAddress hostIPAddress = IPAddress.Parse("127.0.0.1");
            IPHostEntry hostInfo = Dns.GetHostEntry(hostIPAddress);
            /* FLAW: Using the reverse DNS of the client to determine whether to allow the connection */
            if (hostInfo.HostName.Equals(secret_hostname))
            {
                IO.WriteLine("Access granted.");
            }
        }
    }
#endif //omitbad

}
}
