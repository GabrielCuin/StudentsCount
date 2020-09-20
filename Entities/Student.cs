namespace StudentsCount.Entities
{
    class Student
    {
        public string StudentName { get; set; }
        public int StudentID { get; set; }

        public Student(string studentName, int studentID)
        {
            StudentName = studentName;
            StudentID = studentID;
        }

        public Student(int studentID)
        {
            StudentID = studentID;
        }
        public override int GetHashCode()
        {
            return StudentID.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Student))
            {
                return false;
            }
            Student other = obj as Student;
            return StudentID.Equals(other.StudentID);
        }
    }
}
