/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE477_Obsolete_Functions__Dns_GetHostByAddress_13.cs
Label Definition File: CWE477_Obsolete_Functions.label.xml
Template File: point-flaw-13.tmpl.cs
*/
/*
* @description
* CWE: 477 Use of Obsolete Functions
* Sinks: Dns_GetHostByAddress
*    GoodSink: Use of preferred System.Net.Dns.GetHostEntry() method
*    BadSink : Use of deprecated System.Net.Dns.GetHostByAddress() method
* Flow Variant: 13 Control flow: if(IO.STATIC_READONLY_FIVE==5) and if(IO.STATIC_READONLY_FIVE!=5)
*
* */

using TestCaseSupport;
using System;

using System.Net;

namespace testcases.CWE477_Obsolete_Functions
{
class CWE477_Obsolete_Functions__Dns_GetHostByAddress_13 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (IO.STATIC_READONLY_FIVE == 5)
        {
            IPAddress hostIPAddress = IPAddress.Parse("8.8.8.8");
            /* FLAW: Use of deprecated Dns.GetHostByAddress() method */
            IPHostEntry hostInfo = Dns.GetHostByAddress(hostIPAddress);
            IO.WriteLine("Host name : " + hostInfo.HostName);
        }
    }
#endif //omitbad

}
}
