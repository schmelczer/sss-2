/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE369_Divide_by_Zero__int_Database_modulo_81a.cs
Label Definition File: CWE369_Divide_by_Zero__int.label.xml
Template File: sources-sinks-81a.tmpl.cs
*/
/*
 * @description
 * CWE: 369 Divide by zero
 * BadSource: Database Read data from a database
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: modulo
 *    GoodSink: Check for zero before modulo
 *    BadSink : Modulo by a value that may be zero
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */

using TestCaseSupport;
using System;

using System.Data.SqlClient;

namespace testcases.CWE369_Divide_by_Zero
{
class CWE369_Divide_by_Zero__int_Database_modulo_81a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        int data;
        data = int.MinValue; /* Initialize data */
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
                            string stringNumber = dr.GetString(1);
                            if (stringNumber != null) /* avoid NPD incidental warnings */
                            {
                                try
                                {
                                    data = int.Parse(stringNumber.Trim());
                                }
                                catch (FormatException exceptNumberFormat)
                                {
                                    IO.Logger.Log(NLog.LogLevel.Warn, exceptNumberFormat, "Number format exception parsing data from string");
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
        CWE369_Divide_by_Zero__int_Database_modulo_81_base baseObject = new CWE369_Divide_by_Zero__int_Database_modulo_81_bad();
        baseObject.Action(data );
    }
#endif //omitbad

}
}
