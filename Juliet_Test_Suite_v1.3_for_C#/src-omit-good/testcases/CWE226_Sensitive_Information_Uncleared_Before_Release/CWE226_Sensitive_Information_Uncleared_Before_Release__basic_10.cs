/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE226_Sensitive_Information_Uncleared_Before_Release__basic_10.cs
Label Definition File: CWE226_Sensitive_Information_Uncleared_Before_Release__basic.label.xml
Template File: point-flaw-10.tmpl.cs
*/
/*
* @description
* CWE: 226 Sensitive Information Uncleared Before Release
* Sinks:
*    GoodSink: Sensitive info (password) is stored in a mutable object, but is cleared after use
*    BadSink : Sensitive info (password) is stored in a mutable object and is uncleared
* Flow Variant: 10 Control flow: if(IO.staticTrue) and if(IO.staticFalse)
*
* */

using TestCaseSupport;
using System;

using System.Data.SqlClient;
using System.IO;
using System.Text;

namespace testcases.CWE226_Sensitive_Information_Uncleared_Before_Release
{
class CWE226_Sensitive_Information_Uncleared_Before_Release__basic_10 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        if (IO.staticTrue)
        {
            StringBuilder password = new StringBuilder();
            /* read user input from console with readLine */
            try
            {
                using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
                {
                    password.Append(sr.ReadLine());
                    using (SqlConnection dBConnection = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = " + password.ToString() + ";"))
                    {
                        dBConnection.Open();
                    }
                }
            }
            catch (IOException exceptIO)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, "Error with stream reading", exceptIO);
            }
            catch (SqlException exceptSql)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, "Error getting database connection", exceptSql);
            }
            /* FLAW: the password is stored in a mutable object (StringBuilder) and it is not cleared */
        }
    }
#endif //omitbad

}
}
