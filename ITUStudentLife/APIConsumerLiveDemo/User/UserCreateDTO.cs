using System;
using System.Collections.Generic;
using System.Text;

namespace ITUStudentLife.Shared.User
{
    public class UserCreateDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsOkay()
        {
            if(SharedInputChecking.IsStringWrong(FirstName)) return false;
            if (SharedInputChecking.IsStringWrong(LastName)) return false;
            return true;
        }
    }
}
