/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE510_Trapdoor__ip_based_logic_16.cs
Label Definition File: CWE510_Trapdoor.label.xml
Template File: point-flaw-16.tmpl.cs
*/
/*
* @description
* CWE: 510 Trapdoor
* Sinks: ip_based_logic
*    GoodSink: No special code for a specific IP address
*    BadSink : Special code is executed upon connection of a specific IP address
* Flow Variant: 16 Control flow: while(true)
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
class CWE510_Trapdoor__ip_based_logic_16 : AbstractTestCase
{

#if (!OMITGOOD)
    /* Good1() change the conditions on the while statements */
    private void Good1()
    {
        while(true)
        {
            TcpListener listener = null;
            TcpClient tcpConn = null;
            Stream streamOutput = null;
            int port = 20000;
            try
            {
                listener = new TcpListener(IPAddress.Parse("10.10.1.10"), port);
                listener.Start();
                tcpConn = listener.AcceptTcpClient();
                streamOutput = tcpConn.GetStream();
                IPEndPoint endPoint = (IPEndPoint)tcpConn.Client.RemoteEndPoint;
                IPAddress ipAddress = endPoint.Address;
                IPHostEntry hostEntry = Dns.GetHostEntry(ipAddress);
                /* FIX: No host-based Logic */
                streamOutput.Write(Encoding.UTF8.GetBytes(("Welcome, " + hostEntry.ToString())), 0, ("Welcome, " + hostEntry.ToString()).Length);
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
            break;
        }
    }

    public override void Good()
    {
        Good1();
    }
#endif //omitgood
}
}
