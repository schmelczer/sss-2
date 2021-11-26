/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE675_Duplicate_Operations_on_Resource__StreamReader_03.cs
Label Definition File: CWE675_Duplicate_Operations_on_Resource.label.xml
Template File: sources-sinks-03.tmpl.cs
*/
/*
* @description
* CWE: 675 Duplicate Operations on Resource
* BadSource: StreamReader Open and close a file using StreamReader() and Close()
* GoodSource: Open a file using OpenText()
* Sinks:
*    GoodSink: Do nothing
*    BadSink : Close the StreamReader
* Flow Variant: 03 Control flow: if(5==5) and if(5!=5)
*
* */

using TestCaseSupport;
using System;

using System.IO;

namespace testcases.CWE675_Duplicate_Operations_on_Resource
{
class CWE675_Duplicate_Operations_on_Resource__StreamReader_03 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        StreamReader data;
        if (5==5)
        {
            data = new StreamReader(@"BadSource_OpenText.txt");
            /* POTENTIAL FLAW: Close the file in the source */
            data.Close();
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
        }
        if (5==5)
        {
            /* POTENTIAL FLAW: Close the file in the sink (it may have been closed in the Source) */
            data.Close();
        }
    }
#endif //omitbad

}
}
