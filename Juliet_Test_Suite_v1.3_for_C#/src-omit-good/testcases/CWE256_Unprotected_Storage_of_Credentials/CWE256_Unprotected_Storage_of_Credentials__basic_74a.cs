/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE256_Unprotected_Storage_of_Credentials__basic_74a.cs
Label Definition File: CWE256_Unprotected_Storage_of_Credentials__basic.label.xml
Template File: sources-sinks-74a.tmpl.cs
*/
/*
 * @description
 * CWE: 256 Unprotected Storage of Credentials
 * BadSource:  Read password from a .txt file
 * GoodSource: Read password from a .txt file (from the property named password) and then decrypt it
 * Sinks:
 *    GoodSink: Decrypt password and use decrypted password as password to connect to DB
 *    BadSink : Use password as password to connect to DB
 * Flow Variant: 74 Data flow: data passed in a Dictionary from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System.Collections.Generic;
using System;

using System.Data.SqlClient;
using System.Security.Cryptography;
using System.IO;
using System.Text;

namespace testcases.CWE256_Unprotected_Storage_of_Credentials
{
class CWE256_Unprotected_Storage_of_Credentials__basic_74a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        string password;
        password = ""; /* init password */
        /* retrieve the password */
        try
        {
            password = Encoding.UTF8.GetString(File.ReadAllBytes("../../../common/strong_password_file.txt"));
        }
        catch (IOException exceptIO)
        {
            IO.Logger.Log(NLog.LogLevel.Warn, "Error with file reading", exceptIO);
        }
        /* POTENTIAL FLAW: The raw password read from the .txt file is passed on (without being decrypted) */
        Dictionary<int,string> passwordDictionary = new Dictionary<int,string>();
        passwordDictionary.Add(0, password);
        passwordDictionary.Add(1, password);
        passwordDictionary.Add(2, password);
        CWE256_Unprotected_Storage_of_Credentials__basic_74b.BadSink(passwordDictionary  );
    }
#endif //omitbad

}
}
