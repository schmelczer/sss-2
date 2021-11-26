/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE675_Duplicate_Operations_on_Resource__OpenText_05.cs
Label Definition File: CWE675_Duplicate_Operations_on_Resource.label.xml
Template File: sources-sinks-05.tmpl.cs
*/
/*
* @description
* CWE: 675 Duplicate Operations on Resource
* BadSource: OpenText Open and close a file using OpenText and Close()
* GoodSource: Open a file using OpenText()
* Sinks:
*    GoodSink: Do nothing
*    BadSink : Close the StreamReader
* Flow Variant: 05 Control flow: if(privateTrue) and if(privateFalse)
*
* */
using TestCaseSupport;
using System;

using System.IO;

namespace testcases.CWE675_Duplicate_Operations_on_Resource
{
class CWE675_Duplicate_Operations_on_Resource__OpenText_05 : AbstractTestCase
{

    /* The two variables below are not defined as "readonly", but are never
     * assigned any other value, so a tool should be able to identify that
     * reads of these will always return their initialized values.
     */
    private bool privateTrue = true;
    private bool privateFalse = false;
#if (!OMITBAD)
    public override void Bad()
    {
        StreamReader data;
        if (privateTrue)
        {
            data = File.OpenText(@"BadSource_OpenText.txt");
            /* POTENTIAL FLAW: Close the file in the source */
            data.Close();
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
        }
        if (privateTrue)
        {
            /* POTENTIAL FLAW: Close the file in the sink (it may have been closed in the Source) */
            data.Close();
        }
    }
#endif //omitbad

}
}
