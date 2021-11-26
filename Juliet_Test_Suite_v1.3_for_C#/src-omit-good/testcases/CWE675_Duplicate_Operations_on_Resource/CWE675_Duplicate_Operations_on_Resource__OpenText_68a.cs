/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE675_Duplicate_Operations_on_Resource__OpenText_68a.cs
Label Definition File: CWE675_Duplicate_Operations_on_Resource.label.xml
Template File: sources-sinks-68a.tmpl.cs
*/
/*
 * @description
 * CWE: 675 Duplicate Operations on Resource
 * BadSource: OpenText Open and close a file using OpenText and Close()
 * GoodSource: Open a file using OpenText()
 * Sinks:
 *    GoodSink: Do nothing
 *    BadSink : Close the StreamReader
 * Flow Variant: 68 Data flow: data passed as a member variable in the "a" class, which is used by a method in another class in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.IO;

namespace testcases.CWE675_Duplicate_Operations_on_Resource
{
class CWE675_Duplicate_Operations_on_Resource__OpenText_68a : AbstractTestCase
{

    public static StreamReader data;
#if (!OMITBAD)
    public override void Bad()
    {
        data = File.OpenText(@"BadSource_OpenText.txt");
        /* POTENTIAL FLAW: Close the file in the source */
        data.Close();
        CWE675_Duplicate_Operations_on_Resource__OpenText_68b.BadSink();
    }
#endif //omitbad

}
}
