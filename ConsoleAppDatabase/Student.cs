using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppDatabase
{
    public class Student
    {
        //Instance Fields
        #region Instance Fields
        private int _id;
        private string _name;
        private int _phone;
        #endregion

        //Properties
        #region Properties
        public int Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int StudentId
        {
            get { return _id; }
            set { _id = value; }
        }
        #endregion

        //Constructor
        public Student(int id, string name, int phone)
        {
            StudentId = id;
            Name = name;
            Phone = phone;
        }

    }
}
