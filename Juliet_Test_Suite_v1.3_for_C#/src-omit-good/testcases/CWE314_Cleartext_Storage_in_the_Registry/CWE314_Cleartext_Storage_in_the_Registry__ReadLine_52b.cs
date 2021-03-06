/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE314_Cleartext_Storage_in_the_Registry__ReadLine_52b.cs
Label Definition File: CWE314_Cleartext_Storage_in_the_Registry.label.xml
Template File: sources-sinks-52b.tmpl.cs
*/
/*
 * @description
 * CWE: 314 Cleartext storage in the registry
 * BadSource: ReadLine Read data from the console using ReadLine()
 * GoodSource: A hardcoded string
 * Sinks:
 *    GoodSink: Hash data before storing in registry
 *    BadSink : Store data directly in registry
 * Flow Variant: 52 Data flow: data passed as an argument from one method to another to another in three different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using Microsoft.Win32;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace testcases.CWE314_Cleartext_Storage_in_the_Registry
{
class CWE314_Cleartext_Storage_in_the_Registry__ReadLine_52b
{
#if (!OMITBAD)
    public static void BadSink(string data )
    {
        CWE314_Cleartext_Storage_in_the_Registry__ReadLine_52c.BadSink(data );
    }
#endif


}
}
