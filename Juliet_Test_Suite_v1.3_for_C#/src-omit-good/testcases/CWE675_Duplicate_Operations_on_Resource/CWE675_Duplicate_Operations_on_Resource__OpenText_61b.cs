/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE675_Duplicate_Operations_on_Resource__OpenText_61b.cs
Label Definition File: CWE675_Duplicate_Operations_on_Resource.label.xml
Template File: sources-sinks-61b.tmpl.cs
*/
/*
 * @description
 * CWE: 675 Duplicate Operations on Resource
 * BadSource: OpenText Open and close a file using OpenText and Close()
 * GoodSource: Open a file using OpenText()
 * Sinks:
 *    GoodSink: Do nothing
 *    BadSink : Close the StreamReader
 * Flow Variant: 61 Data flow: data returned from one method to another in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.IO;

namespace testcases.CWE675_Duplicate_Operations_on_Resource
{
class CWE675_Duplicate_Operations_on_Resource__OpenText_61b
{
#if (!OMITBAD)
    public static StreamReader BadSource()
    {
        StreamReader data;
        data = File.OpenText(@"BadSource_OpenText.txt");
        /* POTENTIAL FLAW: Close the file in the source */
        data.Close();
        return data;
    }
#endif


}
}
