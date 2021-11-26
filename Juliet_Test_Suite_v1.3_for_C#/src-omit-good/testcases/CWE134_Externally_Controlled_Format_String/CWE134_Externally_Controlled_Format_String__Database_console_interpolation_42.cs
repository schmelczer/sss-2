/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE134_Externally_Controlled_Format_String__Database_console_interpolation_42.cs
Label Definition File: CWE134_Externally_Controlled_Format_String.label.xml
Template File: sources-sinks-42.tmpl.cs
*/
/*
 * @description
 * CWE: 134 Externally Controlled Format String
 * BadSource: Database Read data from a database
 * GoodSource: A hardcoded string
 * Sinks: console_interpolation
 *    GoodSink: console write with interpolation
 *    BadSink : console write formatted without validation
 * Flow Variant: 42 Data flow: data returned from one method to another in the same class
 *
 * */

using TestCaseSupport;
using System;

using System.Data.SqlClient;

namespace testcases.CWE134_Externally_Controlled_Format_String
{
class CWE134_Externally_Controlled_Format_String__Database_console_interpolation_42 : AbstractTestCase
{
#if (!OMITBAD)
    private static string BadSource()
    {
        string data;
        data = ""; /* Initialize data */
        /* Read data from a database */
        {
            try
            {
                /* setup the connection */
                using (SqlConnection connection = IO.GetDBConnection())
                {
                    connection.Open();
                    /* prepare and execute a (hardcoded) query */
                    using (SqlCommand command = new SqlCommand(null, connection))
                    {
                        command.CommandText = "select name from users where id=0";
                        command.Prepare();
                        using (SqlDataReader dr = command.ExecuteReader())
                        {
                            /* POTENTIAL FLAW: Read data from a database query SqlDataReader */
                            data = dr.GetString(1);
                        }
                    }
                }
            }
            catch (SqlException exceptSql)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, exceptSql, "Error with SQL statement");
            }
        }
        return data;
    }

    public override void Bad()
    {
        string data = BadSource();
        if (data != null)
        {
            /* POTENTIAL FLAW: uncontrolled string formatting */
            Console.Write(string.Format(data));
        }
    }
#endif //omitbad

}
}
