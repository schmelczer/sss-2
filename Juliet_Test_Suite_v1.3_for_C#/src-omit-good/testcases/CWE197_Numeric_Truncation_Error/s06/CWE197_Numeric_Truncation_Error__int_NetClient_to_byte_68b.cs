/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__int_NetClient_to_byte_68b.cs
Label Definition File: CWE197_Numeric_Truncation_Error__int.label.xml
Template File: sources-sink-68b.tmpl.cs
*/
/*
 * @description
 * CWE: 197 Numeric Truncation Error
 * BadSource: NetClient Read data from a web server with WebClient
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * BadSink: to_byte Convert data to a byte
 * Flow Variant: 68 Data flow: data passed as a member variable in the "a" class, which is used by a method in another class in the same package
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE197_Numeric_Truncation_Error
{
class CWE197_Numeric_Truncation_Error__int_NetClient_to_byte_68b
{
#if (!OMITBAD)
    public static void BadSink()
    {
        int data = CWE197_Numeric_Truncation_Error__int_NetClient_to_byte_68a.data;
        {
            /* POTENTIAL FLAW: Convert data to a byte, possibly causing a truncation error */
            IO.WriteLine((byte)data);
        }
    }
#endif


}
}
