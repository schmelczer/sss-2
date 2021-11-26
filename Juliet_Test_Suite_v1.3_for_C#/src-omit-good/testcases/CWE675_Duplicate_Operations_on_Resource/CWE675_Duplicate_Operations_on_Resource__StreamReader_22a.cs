/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE675_Duplicate_Operations_on_Resource__StreamReader_22a.cs
Label Definition File: CWE675_Duplicate_Operations_on_Resource.label.xml
Template File: sources-sinks-22a.tmpl.cs
*/
/*
 * @description
 * CWE: 675 Duplicate Operations on Resource
 * BadSource: StreamReader Open and close a file using StreamReader() and Close()
 * GoodSource: Open a file using OpenText()
 * Sinks:
 *    GoodSink: Do nothing
 *    BadSink : Close the StreamReader
 * Flow Variant: 22 Control flow: Flow controlled by value of a public static variable. Sink functions are in a separate file from sources.
 *
 * */

using TestCaseSupport;
using System;

using System.IO;

namespace testcases.CWE675_Duplicate_Operations_on_Resource
{
class CWE675_Duplicate_Operations_on_Resource__StreamReader_22a : AbstractTestCase
{

    /* The public static variable below is used to drive control flow in the sink function. */
    public static bool badPublicStatic = false;
#if (!OMITBAD)
    public override void Bad()
    {
        StreamReader data = null;
        data = new StreamReader(@"BadSource_OpenText.txt");
        /* POTENTIAL FLAW: Close the file in the source */
        data.Close();
        badPublicStatic = true;
        CWE675_Duplicate_Operations_on_Resource__StreamReader_22b.BadSink(data );
    }
#endif //omitbad
    /* The public static variables below are used to drive control flow in the sink functions. */
    public static bool goodB2G1PublicStatic = false;
    public static bool goodB2G2PublicStatic = false;
    public static bool goodG2BPublicStatic = false;

}
}
