/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE94_Improper_Control_of_Generation_of_Code__Listen_tcp_05.cs
Label Definition File: CWE94_Improper_Control_of_Generation_of_Code.label.xml
Template File: sources-sinks-05.tmpl.cs
*/
/*
* @description
* CWE: 94 Improper Control of Generation of Code
* BadSource: Listen_tcp Read data using a listening tcp connection
* GoodSource: Set data to an integer represented as a string
* Sinks:
*    GoodSink: Validate user input prior to compiling
*    BadSink : Compile sourceCode containing unvalidated user input
* Flow Variant: 05 Control flow: if(privateTrue) and if(privateFalse)
*
* */
using TestCaseSupport;
using System;

using System.Reflection;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Text;
using System.Web;

using System.IO;
using System.Net.Sockets;
using System.Net;

namespace testcases.CWE94_Improper_Control_of_Generation_of_Code
{
class CWE94_Improper_Control_of_Generation_of_Code__Listen_tcp_05 : AbstractTestCase
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
        string data;
        if (privateTrue)
        {
            data = ""; /* Initialize data */
            /* Read data using a listening tcp connection */
            {
                TcpListener listener = null;
                try
                {
                    listener = new TcpListener(IPAddress.Parse("10.10.1.10"), 39543);
                    listener.Start();
                    using (TcpClient tcpConn = listener.AcceptTcpClient())
                    {
                        /* read input from socket */
                        using (StreamReader sr = new StreamReader(tcpConn.GetStream()))
                        {
                            /* POTENTIAL FLAW: Read data using a listening tcp connection */
                            data = sr.ReadLine();
                        }
                    }
                }
                catch (IOException exceptIO)
                {
                    IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error with stream reading");
                }
                finally
                {
                    if (listener != null)
                    {
                        try
                        {
                            listener.Stop();
                        }
                        catch(SocketException se)
                        {
                            IO.Logger.Log(NLog.LogLevel.Warn, se, "Error closing TcpListener");
                        }
                    }
                }
            }
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
        }
        if (privateTrue)
        {
            StringBuilder sourceCode = new StringBuilder("");
            sourceCode.Append("public class Calculator \n{\n");
            sourceCode.Append("\tpublic int Sum()\n\t{\n");
            sourceCode.Append("\t\treturn (10 + " + data.ToString() + ");\n");
            sourceCode.Append("\t}\n");
            sourceCode.Append("}\n");
            /* POTENTIAL FLAW: Compile sourceCode containing unvalidated user input */
            CodeDomProvider provider = CodeDomProvider.CreateProvider("CSharp");
            CompilerParameters cp = new CompilerParameters();
            CompilerResults cr = provider.CompileAssemblyFromSource(cp, sourceCode.ToString());
            Assembly a = cr.CompiledAssembly;
            object calculator = a.CreateInstance("Calculator");
            Type calculatorType = calculator.GetType();
            MethodInfo mi = calculatorType.GetMethod("Sum");
            int s = (int)mi.Invoke(calculator, new object[] {});
            IO.WriteLine("Result: " + s.ToString());
        }
    }
#endif //omitbad

}
}
