/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE36_Absolute_Path_Traversal__Environment_22b.cs
Label Definition File: CWE36_Absolute_Path_Traversal.label.xml
Template File: sources-sink-22b.tmpl.cs
*/
/*
 * @description
 * CWE: 36 Absolute Path Traversal
 * BadSource: Environment Read data from an environment variable
 * GoodSource: A hardcoded string
 * Sinks: readFile
 *    BadSink : read line from file from disk
 * Flow Variant: 22 Control flow: Flow controlled by value of a public static variable. Sink functions are in a separate file from sources.
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE36_Absolute_Path_Traversal
{

class CWE36_Absolute_Path_Traversal__Environment_22b
{
#if (!OMITBAD)
    public static string BadSource()
    {
        string data;
        if (CWE36_Absolute_Path_Traversal__Environment_22a.badPublicStatic)
        {
            /* get environment variable ADD */
            /* POTENTIAL FLAW: Read data from an environment variable */
            data = Environment.GetEnvironmentVariable("ADD");
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
        }
        return data;
    }
#endif


}
}
