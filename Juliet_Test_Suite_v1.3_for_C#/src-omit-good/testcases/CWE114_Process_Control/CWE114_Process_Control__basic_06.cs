/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE114_Process_Control__basic_06.cs
Label Definition File: CWE114_Process_Control__basic.label.xml
Template File: point-flaw-06.tmpl.cs
*/
/*
* @description
* CWE: 114 Process Control
* Sinks:
*    GoodSink: use Assembly.LoadFrom() to load a library
*    BadSink : use Assembly.Load() to load a library
* Flow Variant: 06 Control flow: if(PRIVATE_CONST_FIVE==5) and if(PRIVATE_CONST_FIVE!=5)
*
* */

using TestCaseSupport;
using System;

using System.Reflection;

namespace testcases.CWE114_Process_Control
{
class CWE114_Process_Control__basic_06 : AbstractTestCase
{
    /* The variable below is declared "const", so a tool should be able
     * to identify that reads of this will always give its initialized
     * value.
     */
    private const int PRIVATE_CONST_FIVE = 5;
#if (!OMITBAD)
    public override void Bad()
    {
        if (PRIVATE_CONST_FIVE == 5)
        {
            string libraryName = "test.dll";
            /* FLAW: Attempt to load a library with Assembly.Load() without the full path to the library. */
            Assembly.Load(libraryName);
        }
    }
#endif //omitbad

}
}
