/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE675_Duplicate_Operations_on_Resource__StreamReader_61a.cs
Label Definition File: CWE675_Duplicate_Operations_on_Resource.label.xml
Template File: sources-sinks-61a.tmpl.cs
*/
/*
 * @description
 * CWE: 675 Duplicate Operations on Resource
 * BadSource: StreamReader Open and close a file using StreamReader() and Close()
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
class CWE675_Duplicate_Operations_on_Resource__StreamReader_61a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        StreamReader data = CWE675_Duplicate_Operations_on_Resource__StreamReader_61b.BadSource();
        /* POTENTIAL FLAW: Close the file in the sink (it may have been closed in the Source) */
        data.Close();
    }
#endif //omitbad

}
}
