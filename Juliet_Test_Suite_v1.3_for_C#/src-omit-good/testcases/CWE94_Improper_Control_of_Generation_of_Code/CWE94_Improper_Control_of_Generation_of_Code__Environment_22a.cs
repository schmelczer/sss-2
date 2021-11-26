/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE94_Improper_Control_of_Generation_of_Code__Environment_22a.cs
Label Definition File: CWE94_Improper_Control_of_Generation_of_Code.label.xml
Template File: sources-sinks-22a.tmpl.cs
*/
/*
 * @description
 * CWE: 94 Improper Control of Generation of Code
 * BadSource: Environment Read data from an environment variable
 * GoodSource: Set data to an integer represented as a string
 * Sinks:
 *    GoodSink: Validate user input prior to compiling
 *    BadSink : Compile sourceCode containing unvalidated user input
 * Flow Variant: 22 Control flow: Flow controlled by value of a public static variable. Sink functions are in a separate file from sources.
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE94_Improper_Control_of_Generation_of_Code
{
class CWE94_Improper_Control_of_Generation_of_Code__Environment_22a : AbstractTestCase
{

    /* The public static variable below is used to drive control flow in the sink function. */
    public static bool badPublicStatic = false;
#if (!OMITBAD)
    public override void Bad()
    {
        string data = null;
        /* get environment variable ADD */
        /* POTENTIAL FLAW: Read data from an environment variable */
        data = Environment.GetEnvironmentVariable("ADD");
        badPublicStatic = true;
        CWE94_Improper_Control_of_Generation_of_Code__Environment_22b.BadSink(data );
    }
#endif //omitbad
    /* The public static variables below are used to drive control flow in the sink functions. */
    public static bool goodB2G1PublicStatic = false;
    public static bool goodB2G2PublicStatic = false;
    public static bool goodG2BPublicStatic = false;

}
}
