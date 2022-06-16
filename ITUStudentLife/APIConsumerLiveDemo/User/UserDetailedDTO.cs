using System;
using System.Collections.Generic;
using System.Text;

namespace ITUStudentLife.Shared.User
{
    public class UserDetailedDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<int> PostAbstractIds { get; set; }

        //Student helper details
        public bool IsStudentHelper { get; set; }
        public String FieldOfStudy { get; set; }
        public int MyRating { get; set; }
    }
}
