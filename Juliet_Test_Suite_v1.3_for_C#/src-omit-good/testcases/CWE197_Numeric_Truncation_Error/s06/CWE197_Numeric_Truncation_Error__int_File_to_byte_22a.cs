/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__int_File_to_byte_22a.cs
Label Definition File: CWE197_Numeric_Truncation_Error__int.label.xml
Template File: sources-sink-22a.tmpl.cs
*/
/*
 * @description
 * CWE: 197 Numeric Truncation Error
 * BadSource: File Read data from file (named c:\data.txt)
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: to_byte
 *    BadSink : Convert data to a byte
 * Flow Variant: 22 Control flow: Flow controlled by value of a public static variable. Sink functions are in a separate file from sources.
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE197_Numeric_Truncation_Error
{
class CWE197_Numeric_Truncation_Error__int_File_to_byte_22a : AbstractTestCase
{

    /* The public static variable below is used to drive control flow in the source function.
     * The public static variable mimics a global variable in the C/C++ language family. */
    public static bool badPublicStatic = false;
#if (!OMITBAD)
    public override void Bad()
    {
        int data;
        badPublicStatic = true;
        data = CWE197_Numeric_Truncation_Error__int_File_to_byte_22b.BadSource();
        {
            /* POTENTIAL FLAW: Convert data to a byte, possibly causing a truncation error */
            IO.WriteLine((byte)data);
        }
    }
#endif //omitbad
    /* The public static variables below are used to drive control flow in the source functions.
     * The public static variable mimics a global variable in the C/C++ language family. */
    public static bool goodG2B1PublicStatic = false;
    public static bool GoodG2B2PublicStatic = false;

}
}
