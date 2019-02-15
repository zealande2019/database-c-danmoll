using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppDatabase
{
    public class Exam
    {
        #region Instance fields
        private int _id;
        private string _name;
        private int _grade;
        private string _studentName;
        #endregion

        #region Properties
        public int ExamGrade
        {
            get { return _grade; }
            set { _grade = value; }
        }
        
        public string ExamName
        {
            get { return _name; }
            set { _name = value; }
        }


        public int ExamId
        {
            get { return _id; }
            set { _id = value; }
        }

        public string StudentName
        {
            get { return _studentName; }
            set { _studentName = value; }
        }
        #endregion

        #region Constructor
        public Exam(int Id, string Name, int Grade, string Student)
        {
            ExamId = Id;
            ExamName = Name;
            ExamGrade = Grade;
            StudentName = Student;            
        }
        #endregion

    }
}
