/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE675_Duplicate_Operations_on_Resource__OpenText_41.cs
Label Definition File: CWE675_Duplicate_Operations_on_Resource.label.xml
Template File: sources-sinks-41.tmpl.cs
*/
/*
 * @description
 * CWE: 675 Duplicate Operations on Resource
 * BadSource: OpenText Open and close a file using OpenText and Close()
 * GoodSource: Open a file using OpenText()
 * Sinks:
 *    GoodSink: Do nothing
 *    BadSink : Close the StreamReader
 * Flow Variant: 41 Data flow: data passed as an argument from one method to another in the same class
 *
 * */

using TestCaseSupport;
using System;

using System.IO;

namespace testcases.CWE675_Duplicate_Operations_on_Resource
{
class CWE675_Duplicate_Operations_on_Resource__OpenText_41 : AbstractTestCase
{
#if (!OMITBAD)
    private static void BadSink(StreamReader data )
    {
        /* POTENTIAL FLAW: Close the file in the sink (it may have been closed in the Source) */
        data.Close();
    }

    public override void Bad()
    {
        StreamReader data;
        data = File.OpenText(@"BadSource_OpenText.txt");
        /* POTENTIAL FLAW: Close the file in the source */
        data.Close();
        BadSink(data  );
    }
#endif //omitbad

}
}
