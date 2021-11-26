/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE313_Cleartext_Storage_in_a_File_or_on_Disk__Database_74b.cs
Label Definition File: CWE313_Cleartext_Storage_in_a_File_or_on_Disk.label.xml
Template File: sources-sinks-74b.tmpl.cs
*/
/*
 * @description
 * CWE: 313 Cleartext storage in a File or on Disk
 * BadSource: Database Read data from a database
 * GoodSource: A hardcoded string
 * Sinks:
 *    GoodSink: Hash data before storing in registry
 *    BadSink : Store data directly in a file
 * Flow Variant: 74 Data flow: data passed in a Dictionary from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;
using System.Collections.Generic;

using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.IO;
using System.Web;

namespace testcases.CWE313_Cleartext_Storage_in_a_File_or_on_Disk
{
class CWE313_Cleartext_Storage_in_a_File_or_on_Disk__Database_74b
{
#if (!OMITBAD)
    public static void BadSink(Dictionary<int,string> dataDictionary )
    {
        string data = dataDictionary[2];
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
