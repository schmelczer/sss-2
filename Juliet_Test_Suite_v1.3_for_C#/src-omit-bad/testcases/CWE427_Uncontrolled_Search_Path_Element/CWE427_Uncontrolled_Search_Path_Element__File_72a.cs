/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE427_Uncontrolled_Search_Path_Element__File_72a.cs
Label Definition File: CWE427_Uncontrolled_Search_Path_Element.label.xml
Template File: sources-sink-72a.tmpl.cs
*/
/*
 * @description
 * CWE: 427 Uncontrolled Search Path Element
 * BadSource: File Read data from file (named data.txt)
 * GoodSource: Use a hardcoded path
 * Sinks: Environment
 *    BadSink :
 * Flow Variant: 72 Data flow: data passed in a Hashtable from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System.Collections;
using System;

using System.Web;
using System.Runtime.InteropServices;

using System.IO;

namespace testcases.CWE427_Uncontrolled_Search_Path_Element
{
class CWE427_Uncontrolled_Search_Path_Element__File_72a : AbstractTestCase
{

#if (!OMITGOOD)
    public override void Good()
    {
        GoodG2B();
    }

    /* goodG2B() - use goodsource and badsink */
    private static void GoodG2B()
    {
        string data;
        /* FIX: Set the path as the "system" path */
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            data = "/bin";
        }
        else
        {
            data = "%SystemRoot%\\system32";
        }
        Hashtable dataHashtable = new Hashtable(5);
        dataHashtable.Add(0, data);
        dataHashtable.Add(1, data);
        dataHashtable.Add(2, data);
        CWE427_Uncontrolled_Search_Path_Element__File_72b.GoodG2BSink(dataHashtable  );
    }
#endif //omitgood
}
}
