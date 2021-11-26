/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE314_Cleartext_Storage_in_the_Registry__Database_81_goodB2G.cs
Label Definition File: CWE314_Cleartext_Storage_in_the_Registry.label.xml
Template File: sources-sinks-81_goodB2G.tmpl.cs
*/
/*
 * @description
 * CWE: 314 Cleartext storage in the registry
 * BadSource: Database Read data from a database
 * GoodSource: A hardcoded string
 * Sinks:
 *    GoodSink: Hash data before storing in registry
 *    BadSink : Store data directly in registry
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */
