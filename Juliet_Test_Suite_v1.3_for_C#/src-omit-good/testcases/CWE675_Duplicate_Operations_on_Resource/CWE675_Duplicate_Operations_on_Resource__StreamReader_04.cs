/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE675_Duplicate_Operations_on_Resource__StreamReader_04.cs
Label Definition File: CWE675_Duplicate_Operations_on_Resource.label.xml
Template File: sources-sinks-04.tmpl.cs
*/
/*
* @description
* CWE: 675 Duplicate Operations on Resource
* BadSource: StreamReader Open and close a file using StreamReader() and Close()
* GoodSource: Open a file using OpenText()
* Sinks:
*    GoodSink: Do nothing
*    BadSink : Close the StreamReader
* Flow Variant: 04 Control flow: if(PRIVATE_CONST_TRUE) and if(PRIVATE_CONST_FALSE)
*
* */

using TestCaseSupport;
using System;

using System.IO;

namespace testcases.CWE675_Duplicate_Operations_on_Resource
{
class CWE675_Duplicate_Operations_on_Resource__StreamReader_04 : AbstractTestCase
{

    /* The two variables below are declared "const", so a tool should
     * be able to identify that reads of these will always return their
     * initialized values.
     */
    private const bool PRIVATE_CONST_TRUE = true;
    private const bool PRIVATE_CONST_FALSE = false;
#if (!OMITBAD)
    public override void Bad()
    {
        StreamReader data;
        if (PRIVATE_CONST_TRUE)
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
        if (PRIVATE_CONST_TRUE)
        {
            /* POTENTIAL FLAW: Close the file in the sink (it may have been closed in the Source) */
            data.Close();
        }
    }
#endif //omitbad

}
}
