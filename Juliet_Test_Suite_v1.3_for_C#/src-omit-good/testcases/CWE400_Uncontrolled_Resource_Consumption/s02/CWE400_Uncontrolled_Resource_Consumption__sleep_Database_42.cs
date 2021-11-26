/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE400_Uncontrolled_Resource_Consumption__sleep_Database_42.cs
Label Definition File: CWE400_Uncontrolled_Resource_Consumption__sleep.label.xml
Template File: sources-sinks-42.tmpl.cs
*/
/*
 * @description
 * CWE: 400 Uncontrolled Resource Consumption
 * BadSource: Database Read count from a database
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks:
 *    GoodSink: Validate count before using it as a parameter in sleep function
 *    BadSink : Use count as the parameter for sleep withhout checking it's size first
 * Flow Variant: 42 Data flow: data returned from one method to another in the same class
 *
 * */

using TestCaseSupport;
using System;

using System.Threading;

using System.Data.SqlClient;

namespace testcases.CWE400_Uncontrolled_Resource_Consumption
{
class CWE400_Uncontrolled_Resource_Consumption__sleep_Database_42 : AbstractTestCase
{
#if (!OMITBAD)
    private static int BadSource()
    {
        int count;
        count = int.MinValue; /* Initialize count */
        /* Read count from a database */
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
                            /* POTENTIAL FLAW: Read count from a database query SqlDataReader */
                            string stringNumber = dr.GetString(1);
                            if (stringNumber != null) /* avoid NPD incidental warnings */
                            {
                                try
                                {
                                    count = int.Parse(stringNumber.Trim());
                                }
                                catch (FormatException exceptNumberFormat)
                                {
                                    IO.Logger.Log(NLog.LogLevel.Warn, exceptNumberFormat, "Number format exception parsing count from string");
                                }
                            }
                        }
                    }
                }
            }
            catch (SqlException exceptSql)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, exceptSql, "Error with SQL statement");
            }
        }
        return count;
    }

    public override void Bad()
    {
        int count = BadSource();
        /* POTENTIAL FLAW: Use count as the input to Thread.Sleep() */
        Thread.Sleep(count);
    }
#endif //omitbad

}
}
