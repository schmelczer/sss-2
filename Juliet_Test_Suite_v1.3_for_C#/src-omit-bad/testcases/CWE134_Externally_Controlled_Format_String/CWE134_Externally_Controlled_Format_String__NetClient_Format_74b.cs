/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE134_Externally_Controlled_Format_String__NetClient_Format_74b.cs
Label Definition File: CWE134_Externally_Controlled_Format_String.label.xml
Template File: sources-sinks-74b.tmpl.cs
*/
/*
 * @description
 * CWE: 134 Externally Controlled Format String
 * BadSource: NetClient Read data from a web server with WebClient
 * GoodSource: A hardcoded string
 * Sinks: Format
 *    GoodSink: console write formatted using string.Format
 *    BadSink : console write formatted without validation
 * Flow Variant: 74 Data flow: data passed in a Dictionary from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;
using System.Collections.Generic;

namespace testcases.CWE134_Externally_Controlled_Format_String
{
class CWE134_Externally_Controlled_Format_String__NetClient_Format_74b
{


#if (!OMITGOOD)
    /* goodG2B() - use GoodSource and BadSink */
    public static  void GoodG2BSink(Dictionary<int,string> dataDictionary )
    {
        string data = dataDictionary[2];
        if (data != null)
        {
            /* POTENTIAL FLAW: uncontrolled string formatting */
            Console.Write(string.Format(data));
        }
    }

    /* goodB2G() - use BadSource and GoodSink */
    public static void GoodB2GSink(Dictionary<int,string> dataDictionary )
    {
        string data = dataDictionary[2];
        if (data != null)
        {
            /* FIX: explicitly defined string formatting */
            Console.Write(string.Format("{0}{1}", data, Environment.NewLine));
        }
    }
#endif
}
}
