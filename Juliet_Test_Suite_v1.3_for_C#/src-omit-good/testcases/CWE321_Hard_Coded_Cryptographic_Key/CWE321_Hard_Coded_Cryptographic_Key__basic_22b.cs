/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE321_Hard_Coded_Cryptographic_Key__basic_22b.cs
Label Definition File: CWE321_Hard_Coded_Cryptographic_Key__basic.label.xml
Template File: sources-sink-22b.tmpl.cs
*/
/*
 * @description
 * CWE: 321 Hard coded crypto key
 * BadSource:  Set data to a hardcoded value
 * GoodSource: Read data from the console using readLine()
 * Sinks:
 *    BadSink : Use data as a cryptographic key
 * Flow Variant: 22 Control flow: Flow controlled by value of a public static variable. Sink functions are in a separate file from sources.
 *
 * */

using TestCaseSupport;
using System;

using System.IO;

namespace testcases.CWE321_Hard_Coded_Cryptographic_Key
{

class CWE321_Hard_Coded_Cryptographic_Key__basic_22b
{
#if (!OMITBAD)
    public static string BadSource()
    {
        string data;
        if (CWE321_Hard_Coded_Cryptographic_Key__basic_22a.badPublicStatic)
        {
            /* FLAW: Set data to a hardcoded value */
            data = "23 ~j;asn!@#/>as";
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
