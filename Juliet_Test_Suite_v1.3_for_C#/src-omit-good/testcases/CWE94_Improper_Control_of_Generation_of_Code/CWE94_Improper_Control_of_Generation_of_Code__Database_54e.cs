/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE94_Improper_Control_of_Generation_of_Code__Database_54e.cs
Label Definition File: CWE94_Improper_Control_of_Generation_of_Code.label.xml
Template File: sources-sinks-54e.tmpl.cs
*/
/*
 * @description
 * CWE: 94 Improper Control of Generation of Code
 * BadSource: Database Read data from a database
 * GoodSource: Set data to an integer represented as a string
 * Sinks:
 *    GoodSink: Validate user input prior to compiling
 *    BadSink : Compile sourceCode containing unvalidated user input
 * Flow Variant: 54 Data flow: data passed as an argument from one method through three others to a fifth; all five functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Reflection;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Text;
using System.Web;

namespace testcases.CWE94_Improper_Control_of_Generation_of_Code
{
class CWE94_Improper_Control_of_Generation_of_Code__Database_54e
{
#if (!OMITBAD)
    public static void BadSink(string data )
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
#endif


}
}
