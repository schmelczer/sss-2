/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE477_Obsolete_Functions__Dns_GetHostByAddress_01.cs
Label Definition File: CWE477_Obsolete_Functions.label.xml
Template File: point-flaw-01.tmpl.cs
*/
/*
* @description
* CWE: 477 Use of Obsolete Functions
* Sinks: Dns_GetHostByAddress
*    GoodSink: Use of preferred System.Net.Dns.GetHostEntry() method
*    BadSink : Use of deprecated System.Net.Dns.GetHostByAddress() method
* Flow Variant: 01 Baseline
*
* */

using TestCaseSupport;
using System;

using System.Net;

namespace testcases.CWE477_Obsolete_Functions
{
class CWE477_Obsolete_Functions__Dns_GetHostByAddress_01 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        IPAddress hostIPAddress = IPAddress.Parse("8.8.8.8");
        /* FLAW: Use of deprecated Dns.GetHostByAddress() method */
        IPHostEntry hostInfo = Dns.GetHostByAddress(hostIPAddress);
        IO.WriteLine("Host name : " + hostInfo.HostName);
    }
#endif //omitbad

}
}
