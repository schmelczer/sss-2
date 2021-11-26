/*
 * @description A class defines a readonly static array with public protection.
 * 
 * This is the "bad" version, which has a public readonly static array.
 * 
 * */

using System;
using TestCaseSupport;

namespace testcases.CWE582_Array_Public_Readonly_Static
{
    class CWE582_Array_Public_Readonly_Static__basic_01_bad : AbstractTestCaseClassIssueBad
    {
        public readonly static int[] INT_ARRAY = { 1, 2, 3, 4, 5 }; /* FLAW: public, readonly, static */

        /* This is here so that AbstractTestCaseClassIsssueGood implementation is satisfied */
        public override object Clone()
        {
            throw new NotImplementedException();
        }

}
}
