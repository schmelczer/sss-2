/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE114_Process_Control__basic_16.cs
Label Definition File: CWE114_Process_Control__basic.label.xml
Template File: point-flaw-16.tmpl.cs
*/
/*
* @description
* CWE: 114 Process Control
* Sinks:
*    GoodSink: use Assembly.LoadFrom() to load a library
*    BadSink : use Assembly.Load() to load a library
* Flow Variant: 16 Control flow: while(true)
*
* */

using TestCaseSupport;
using System;

using System.Reflection;

namespace testcases.CWE114_Process_Control
{
class CWE114_Process_Control__basic_16 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        while(true)
        {
            string libraryName = "test.dll";
            /* FLAW: Attempt to load a library with Assembly.Load() without the full path to the library. */
            Assembly.Load(libraryName);
            break;
        }
    }
#endif //omitbad

}
}
