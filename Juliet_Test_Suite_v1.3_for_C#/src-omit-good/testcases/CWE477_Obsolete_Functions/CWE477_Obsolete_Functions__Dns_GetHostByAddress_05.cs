/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE477_Obsolete_Functions__Dns_GetHostByAddress_05.cs
Label Definition File: CWE477_Obsolete_Functions.label.xml
Template File: point-flaw-05.tmpl.cs
*/
/*
* @description
* CWE: 477 Use of Obsolete Functions
* Sinks: Dns_GetHostByAddress
*    GoodSink: Use of preferred System.Net.Dns.GetHostEntry() method
*    BadSink : Use of deprecated System.Net.Dns.GetHostByAddress() method
* Flow Variant: 05 Control flow: if(privateTrue) and if(privateFalse)
*
* */

using TestCaseSupport;
using System;

using System.Net;

namespace testcases.CWE477_Obsolete_Functions
{
class CWE477_Obsolete_Functions__Dns_GetHostByAddress_05 : AbstractTestCase
{
    /* The two variables below are not defined as "readonly", but are never
     * assigned any other value, so a tool should be able to identify that
     * reads of these will always return their initialized values.
     */
    private bool privateTrue = true;
    private bool privateFalse = false;
#if (!OMITBAD)
    public override void Bad()
    {
        if (privateTrue)
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
