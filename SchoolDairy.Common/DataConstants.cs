namespace SchoolDairy.Common
{
    public static class DataConstants
    {
      
        public static class Parent
        {
            public const int FirstNameParentMinLenght = 10;
            public const int FirstNameParentMaxLenght = 45;
            public const int LastNameParentMinLenght = 10;
            public const int LastNameParentMaxLenght = 40;
            public const string PhoneNumber = "^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$";
        }
        public static class Student
        {
            public const int FirstNameStudentMinLenght = 10;
            public const int FirstNameStudentMaxLenght = 40;
            public const int MiddleNameStudentMinLenght = 10;
            public const int MiddleNameStudentMaxLenght = 40;
            public const int LastNameStudentMinLenght = 10;
            public const int LastNameStudentMaxLenght = 40;
        }
        public static class Teacher
        {
            public const int FirstNameTeacherMinLenght = 10;
            public const int FirstNameTeachertMaxLenght = 40;
            public const int MiddleNameTeacherMinLenght = 10;
            public const int MiddleNameTeacherMaxLenght = 40;
            public const int LastNameTeacherMinLenght = 10;
            public const int LastNameTeacherMaxLenght = 40;
        }
    }
}
