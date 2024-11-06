using SchoolDairy.Data.Models;

namespace SchoolDairy.Data
{
    public class DataConstants
    {
        public static class Employee
        {
            public const int FirstNameEmployeeMinLenght = 20;
            public const int FirstNameEmployeeMaxLenght = 40;
            public const int LastNameEmployeeMinLenght = 20;
            public const int LastNameEmployeeMaxLenght = 40;
        }
        public static class Parent
        {
            public const int FirstNameParentMinLenght = 20;
            public const int FirstNameParentMaxLenght = 40;
            public const int LastNameParentMinLenght = 20;
            public const int LastNameParentMaxLenght = 40;
            public const string PhoneNumber = "^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$";



        }
    }
}
