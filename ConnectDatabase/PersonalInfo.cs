using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectDatabase
{
    public class PersonalInfo
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime? Birthdate { get; set; }
    }

    public class RecordChecker
    {
        public int MaxID { get; set; }
    }

    public class Instantiate
    {
        public static PersonalInfo personalInfo = new PersonalInfo();
        public static RecordChecker recordChecker = new RecordChecker();
    }
}
