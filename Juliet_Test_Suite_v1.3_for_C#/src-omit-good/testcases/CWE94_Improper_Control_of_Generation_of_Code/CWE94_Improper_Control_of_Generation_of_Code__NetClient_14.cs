/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE94_Improper_Control_of_Generation_of_Code__NetClient_14.cs
Label Definition File: CWE94_Improper_Control_of_Generation_of_Code.label.xml
Template File: sources-sinks-14.tmpl.cs
*/
/*
* @description
* CWE: 94 Improper Control of Generation of Code
* BadSource: NetClient Read data from a web server with WebClient
* GoodSource: Set data to an integer represented as a string
* Sinks:
*    GoodSink: Validate user input prior to compiling
*    BadSink : Compile sourceCode containing unvalidated user input
* Flow Variant: 14 Control flow: if(IO.staticFive==5) and if(IO.staticFive!=5)
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
using System.Net;

namespace testcases.CWE94_Improper_Control_of_Generation_of_Code
{
class CWE94_Improper_Control_of_Generation_of_Code__NetClient_14 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        string data;
        if (IO.staticFive==5)
        {
            data = ""; /* Initialize data */
            /* read input from WebClient */
            {
                try
                {
                    using (WebClient client = new WebClient())
                    {
                        using (StreamReader sr = new StreamReader(client.OpenRead("http://www.example.org/")))
                        {
                            /* POTENTIAL FLAW: Read data from a web server with WebClient */
                            /* This will be reading the first "line" of the response body,
                            * which could be very long if there are no newlines in the HTML */
                            data = sr.ReadLine();
                        }
                    }
                }
                catch (IOException exceptIO)
                {
                    IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error with stream reading");
                }
            }
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
        }
        if (IO.staticFive==5)
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
