/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE510_Trapdoor__hostname_based_logic_01.cs
Label Definition File: CWE510_Trapdoor.label.xml
Template File: point-flaw-01.tmpl.cs
*/
/*
* @description
* CWE: 510 Trapdoor
* Sinks: hostname_based_logic
*    GoodSink: No special code for a specific hostname
*    BadSink : Special code is executed upon connection of a specific hostname
* Flow Variant: 01 Baseline
*
* */

using TestCaseSupport;
using System;

using System.IO;
using System.Net.Sockets;
using System.Net;
using System.Text;

namespace testcases.CWE510_Trapdoor
{
class CWE510_Trapdoor__hostname_based_logic_01 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        TcpListener listener = null;
        TcpClient tcpConn = null;
        Stream streamOutput = null;
        int port = 20000;
        try
        {
            listener = new TcpListener(IPAddress.Parse("10.10.1.10"), port);
            listener.Start();
            tcpConn = listener.AcceptTcpClient(); /* INCIDENTAL: Use of Socket */
            /* FLAW: hostname-based Logic */
            IPEndPoint endPoint = (IPEndPoint)tcpConn.Client.RemoteEndPoint;
            IPAddress ipAddress = endPoint.Address;
            IPHostEntry hostEntry = Dns.GetHostEntry(ipAddress);
            if (hostEntry.HostName.Equals("admin.google.com"))
            {
                streamOutput = tcpConn.GetStream();
                streamOutput.Write(Encoding.UTF8.GetBytes("Welcome, admin!"), 0, "Welcome, admin!".Length);
            }
            else
            {
                streamOutput = tcpConn.GetStream();
                streamOutput.Write(Encoding.UTF8.GetBytes("Welcome, user."), 0, "Welcome, user.".Length);
            }
        }
        catch (IOException exceptIO)
        {
            IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Could not connect to port " + port.ToString());
        }
        finally
        {
            try
            {
                if (streamOutput != null)
                {
                    streamOutput.Close();
                }
            }
            catch (IOException exceptIO)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error closing objects");
            }

            try
            {
                if (tcpConn != null)
                {
                    tcpConn.Close();
                }
            }
            catch (IOException exceptIO)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error closing objects");
            }

            try
            {
                if (listener != null)
                {
                    listener.Stop();
                }
            }
            catch (IOException exceptIO)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error closing objects");
            }

        }
    }
#endif //omitbad

}
}
