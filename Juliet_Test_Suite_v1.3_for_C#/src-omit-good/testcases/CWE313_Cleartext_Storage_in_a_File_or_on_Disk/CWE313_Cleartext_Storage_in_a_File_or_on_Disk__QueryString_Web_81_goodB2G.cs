/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE313_Cleartext_Storage_in_a_File_or_on_Disk__QueryString_Web_81_goodB2G.cs
Label Definition File: CWE313_Cleartext_Storage_in_a_File_or_on_Disk.label.xml
Template File: sources-sinks-81_goodB2G.tmpl.cs
*/
/*
 * @description
 * CWE: 313 Cleartext storage in a File or on Disk
 * BadSource: QueryString_Web Parse id param out of the URL query string (without using getParameter())
 * GoodSource: A hardcoded string
 * Sinks:
 *    GoodSink: Hash data before storing in registry
 *    BadSink : Store data directly in a file
 * Flow Variant: 81 Data flow: data passed in a parameter to an abstract method
 *
 * */

