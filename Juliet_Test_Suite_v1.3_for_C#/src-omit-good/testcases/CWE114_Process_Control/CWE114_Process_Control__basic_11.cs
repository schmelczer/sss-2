/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE114_Process_Control__basic_11.cs
Label Definition File: CWE114_Process_Control__basic.label.xml
Template File: point-flaw-11.tmpl.cs
*/
/*
* @description
* CWE: 114 Process Control
* Sinks:
*    GoodSink: use Assembly.LoadFrom() to load a library
*    BadSink : use Assembly.Load() to load a library
* Flow Variant: 11 Control flow: if(IO.StaticReturnsTrue()) and if(IO.StaticReturnsFalse())
*
* */

using TestCaseSupport;
using System;

using System.Reflection;

namespace testcases.CWE114_Process_Control
{
class CWE114_Process_Control__basic_11 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (IO.StaticReturnsTrue())
        {
            string libraryName = "test.dll";
            /* FLAW: Attempt to load a library with Assembly.Load() without the full path to the library. */
            Assembly.Load(libraryName);
        }
    }
#endif //omitbad

}
}
