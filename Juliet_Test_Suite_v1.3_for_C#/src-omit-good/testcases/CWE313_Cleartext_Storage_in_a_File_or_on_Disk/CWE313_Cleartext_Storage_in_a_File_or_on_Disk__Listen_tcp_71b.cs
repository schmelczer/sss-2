/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE313_Cleartext_Storage_in_a_File_or_on_Disk__Listen_tcp_71b.cs
Label Definition File: CWE313_Cleartext_Storage_in_a_File_or_on_Disk.label.xml
Template File: sources-sinks-71b.tmpl.cs
*/
/*
 * @description
 * CWE: 313 Cleartext storage in a File or on Disk
 * BadSource: Listen_tcp Read data using a listening tcp connection
 * GoodSource: A hardcoded string
 * Sinks:
 *    GoodSink: Hash data before storing in registry
 *    BadSink : Store data directly in a file
 * Flow Variant: 71 Data flow: data passed as an Object reference argument from one method to another in different classes in the same package
 *
 * */

using TestCaseSupport;

using System;

using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.IO;
using System.Web;

namespace testcases.CWE313_Cleartext_Storage_in_a_File_or_on_Disk
{
class CWE313_Cleartext_Storage_in_a_File_or_on_Disk__Listen_tcp_71b
{
#if (!OMITBAD)
    public static void BadSink(Object dataObject )
    {
        string data = (string)dataObject;
        using (SecureString secureData = new SecureString())
        {
            for (int i = 0; i < data.Length; i++)
            {
                secureData.AppendChar(data[i]);
            }
            /* POTENTIAL FLAW: Store data directly in a file */
            File.WriteAllText(@"C:\Users\Public\WriteText.txt", secureData.ToString());
        }
    }
#endif


}
}
