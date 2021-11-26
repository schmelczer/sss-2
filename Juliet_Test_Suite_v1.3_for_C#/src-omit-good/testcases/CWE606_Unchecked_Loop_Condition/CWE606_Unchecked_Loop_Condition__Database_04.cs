/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE606_Unchecked_Loop_Condition__Database_04.cs
Label Definition File: CWE606_Unchecked_Loop_Condition.label.xml
Template File: sources-sinks-04.tmpl.cs
*/
/*
* @description
* CWE: 606 Unchecked Input for Loop Condition
* BadSource: Database Read data from a database
* GoodSource: hardcoded int in string form
* Sinks:
*    GoodSink: validate loop variable
*    BadSink : loop variable not validated
* Flow Variant: 04 Control flow: if(PRIVATE_CONST_TRUE) and if(PRIVATE_CONST_FALSE)
*
* */

using TestCaseSupport;
using System;

using System.Web;

using System.Data.SqlClient;

namespace testcases.CWE606_Unchecked_Loop_Condition
{
class CWE606_Unchecked_Loop_Condition__Database_04 : AbstractTestCase
{

    /* The two variables below are declared "const", so a tool should
     * be able to identify that reads of these will always return their
     * initialized values.
     */
    private const bool PRIVATE_CONST_TRUE = true;
    private const bool PRIVATE_CONST_FALSE = false;
#if (!OMITBAD)
    public override void Bad()
    {
        string data;
        if (PRIVATE_CONST_TRUE)
        {
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
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
        }
        if (PRIVATE_CONST_TRUE)
        {
            int numberOfLoops;
            try
            {
                numberOfLoops = int.Parse(data);
            }
            catch (FormatException exceptNumberFormat)
            {
                IO.WriteLine("Invalid response. Numeric input expected. Assuming 1.");
                IO.Logger.Log(NLog.LogLevel.Warn, exceptNumberFormat, "Invalid response. Numeric input expected. Assuming 1.");
                numberOfLoops = 1;
            }
            for (int i = 0; i < numberOfLoops; i++)
            {
                /* POTENTIAL FLAW: user supplied input used for loop counter test */
                IO.WriteLine("hello world");
            }
        }
    }
#endif //omitbad

}
}
