/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE477_Obsolete_Functions__Dns_GetHostByAddress_03.cs
Label Definition File: CWE477_Obsolete_Functions.label.xml
Template File: point-flaw-03.tmpl.cs
*/
/*
* @description
* CWE: 477 Use of Obsolete Functions
* Sinks: Dns_GetHostByAddress
*    GoodSink: Use of preferred System.Net.Dns.GetHostEntry() method
*    BadSink : Use of deprecated System.Net.Dns.GetHostByAddress() method
* Flow Variant: 03 Control flow: if(5==5) and if(5!=5)
*
* */

using TestCaseSupport;
using System;

using System.Net;

namespace testcases.CWE477_Obsolete_Functions
{
class CWE477_Obsolete_Functions__Dns_GetHostByAddress_03 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (5 == 5)
        {
            IPAddress hostIPAddress = IPAddress.Parse("8.8.8.8");
            /* FLAW: Use of deprecated Dns.GetHostByAddress() method */
            IPHostEntry hostInfo = Dns.GetHostByAddress(hostIPAddress);
            IO.WriteLine("Host name : " + hostInfo.HostName);
        }
    }
#endif //omitbad
#if (!OMITGOOD)
    /* Good1() changes 5==5 to 5!=5 */
    private void Good1()
    {
        if (5 != 5)
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run */
            IO.WriteLine("Benign, fixed string");
        }
        else
        {
            IPAddress hostIPAddress = IPAddress.Parse("8.8.8.8");
            /* FIX: Use preferred Dns.GetHostEntry() method */
            IPHostEntry hostInfo = Dns.GetHostEntry(hostIPAddress);
            IO.WriteLine("Host name : " + hostInfo.HostName);
        }
    }

    /* Good2() reverses the bodies in the if statement */
    private void Good2()
    {
        if (5 == 5)
        {
            IPAddress hostIPAddress = IPAddress.Parse("8.8.8.8");
            /* FIX: Use preferred Dns.GetHostEntry() method */
            IPHostEntry hostInfo = Dns.GetHostEntry(hostIPAddress);
            IO.WriteLine("Host name : " + hostInfo.HostName);
        }
    }

    public override void Good()
    {
        Good1();
        Good2();
    }
#endif //omitgood
}
}
