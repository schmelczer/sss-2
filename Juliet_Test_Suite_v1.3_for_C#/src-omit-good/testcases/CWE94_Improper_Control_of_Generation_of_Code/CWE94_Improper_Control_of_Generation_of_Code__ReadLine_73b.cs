/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE94_Improper_Control_of_Generation_of_Code__ReadLine_73b.cs
Label Definition File: CWE94_Improper_Control_of_Generation_of_Code.label.xml
Template File: sources-sinks-73b.tmpl.cs
*/
/*
 * @description
 * CWE: 94 Improper Control of Generation of Code
 * BadSource: ReadLine Read data from the console using ReadLine()
 * GoodSource: Set data to an integer represented as a string
 * Sinks:
 *    GoodSink: Validate user input prior to compiling
 *    BadSink : Compile sourceCode containing unvalidated user input
 * Flow Variant: 73 Data flow: data passed in a LinkedList from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;
using System.Collections.Generic;

using System.Reflection;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Text;
using System.Web;

namespace testcases.CWE94_Improper_Control_of_Generation_of_Code
{
class CWE94_Improper_Control_of_Generation_of_Code__ReadLine_73b
{
#if (!OMITBAD)
    public static void BadSink(LinkedList<string> dataLinkedList )
    {
        string data = dataLinkedList.Last.Value;
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
#endif


}
}
