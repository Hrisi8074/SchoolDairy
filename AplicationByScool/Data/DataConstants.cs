namespace SchoolDairy.Data
{
    public static class DataConstants
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
        public static class Student
        {
            public const int FirstNameStudentMinLenght = 20;
            public const int FirstNameStudentMaxLenght = 40;
            public const int MiddleNameStudentMinLenght = 20;
            public const int MiddleNameStudentMaxLenght = 40;
            public const int LastNameStudentMinLenght = 20;
            public const int LastNameStudentMaxLenght = 40;
        }
        public static class Teacher
        {
            public const int FirstNameTeacherMinLenght = 20;
            public const int FirstNameTeachertMaxLenght = 40;
            public const int MiddleNameTeacherMinLenght = 20;
            public const int MiddleNameTeacherMaxLenght = 40;
            public const int LastNameTeacherMinLenght = 20;
            public const int LastNameTeacherMaxLenght = 40;
        }
    }
}
