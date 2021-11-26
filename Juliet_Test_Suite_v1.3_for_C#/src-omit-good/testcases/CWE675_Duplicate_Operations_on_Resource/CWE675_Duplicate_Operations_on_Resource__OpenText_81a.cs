/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE675_Duplicate_Operations_on_Resource__OpenText_81a.cs
Label Definition File: CWE675_Duplicate_Operations_on_Resource.label.xml
Template File: sources-sinks-81a.tmpl.cs
*/
/*
 * @description
 * CWE: 675 Duplicate Operations on Resource
 * BadSource: OpenText Open and close a file using OpenText and Close()
 * GoodSource: Open a file using OpenText()
 * Sinks:
 *    GoodSink: Do nothing
 *    BadSink : Close the StreamReader
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */

using TestCaseSupport;
using System;

using System.IO;

namespace testcases.CWE675_Duplicate_Operations_on_Resource
{
class CWE675_Duplicate_Operations_on_Resource__OpenText_81a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        StreamReader data;
        data = File.OpenText(@"BadSource_OpenText.txt");
        /* POTENTIAL FLAW: Close the file in the source */
        data.Close();
        CWE675_Duplicate_Operations_on_Resource__OpenText_81_base baseObject = new CWE675_Duplicate_Operations_on_Resource__OpenText_81_bad();
        baseObject.Action(data );
    }
#endif //omitbad

}
}
