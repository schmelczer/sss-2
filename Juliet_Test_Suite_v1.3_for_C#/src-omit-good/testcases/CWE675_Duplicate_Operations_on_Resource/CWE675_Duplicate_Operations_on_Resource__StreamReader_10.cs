/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE675_Duplicate_Operations_on_Resource__StreamReader_10.cs
Label Definition File: CWE675_Duplicate_Operations_on_Resource.label.xml
Template File: sources-sinks-10.tmpl.cs
*/
/*
* @description
* CWE: 675 Duplicate Operations on Resource
* BadSource: StreamReader Open and close a file using StreamReader() and Close()
* GoodSource: Open a file using OpenText()
* Sinks:
*    GoodSink: Do nothing
*    BadSink : Close the StreamReader
* Flow Variant: 10 Control flow: if(IO.staticTrue) and if(IO.staticFalse)
*
* */

using TestCaseSupport;
using System;

using System.IO;

namespace testcases.CWE675_Duplicate_Operations_on_Resource
{
class CWE675_Duplicate_Operations_on_Resource__StreamReader_10 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        StreamReader data;
        if (IO.staticTrue)
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
        if (IO.staticTrue)
        {
            /* POTENTIAL FLAW: Close the file in the sink (it may have been closed in the Source) */
            data.Close();
        }
    }
#endif //omitbad

}
}
