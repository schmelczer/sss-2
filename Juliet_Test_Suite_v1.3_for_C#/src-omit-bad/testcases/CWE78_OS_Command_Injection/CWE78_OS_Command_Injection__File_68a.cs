/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE78_OS_Command_Injection__File_68a.cs
Label Definition File: CWE78_OS_Command_Injection.label.xml
Template File: sources-sink-68a.tmpl.cs
*/
/*
 * @description
 * CWE: 78 OS Command Injection
 * BadSource: File Read data from file (named data.txt)
 * GoodSource: A hardcoded string
 * BadSink: exec dynamic command execution with Runtime.getRuntime().exec()
 * Flow Variant: 68 Data flow: data passed as a member variable in the "a" class, which is used by a method in another class in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

using System.IO;

namespace testcases.CWE78_OS_Command_Injection
{

class CWE78_OS_Command_Injection__File_68a : AbstractTestCase
{

    public static string data;

#if (!OMITGOOD)
    public override void Good()
    {
        GoodG2B();
    }

    /* goodG2B() - use goodsource and badsink */
    private static void GoodG2B()
    {
        /* FIX: Use a hardcoded string */
        data = "foo";
        CWE78_OS_Command_Injection__File_68b.GoodG2BSink();
    }
#endif //omitgood
}
}
