using System;
using System.Collections.Generic;
using System.Text;

namespace ITUStudentLife.Shared
{
    public class SharedInputChecking
    {
        public static bool IsStringWrong(String val)
        {
            return val == null || val.Length == 0;
        }
        public static bool IsDateWrong(DateTime val)
        {
            return val == null || val.Equals(new DateTime());
        }
    }
}
