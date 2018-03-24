using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdministrator.Objects
{
    public enum Gender
    {
        Male,
        Female
    }
    public class Student
    {
        private string _studentNumber;
        private string _name;
        private string _surname;
        private string _id;
        private byte _grade;
        private int _age;
        private Gender _gender;

        public string StudentNumber
        {
            get => _studentNumber;
            set => _studentNumber = value;
        }
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public string Surname
        {
            get => _surname;
            set => _surname = value;
        }
        public string Id
        {
            get => _id;
            set
            {
                _id = value;
                SetAgeFromId(value);
                SetGenderFromId(value);
            }
        }

        public byte Grade
        {
            get => _grade;
            set => _grade = value;
        }
        public int Age => _age;

        public Gender Gender { get => _gender;}

        public Student(string studentNumber, string name, string surname, string id, byte grade)
        {
            StudentNumber = studentNumber;
            Name = name;
            Surname = surname;
            Id = id;
            Grade = grade;
        }

        private void SetAgeFromId(string id)
        {
            int year = int.Parse("20" + id.Substring(0, 2));
            int month = int.Parse(id.Substring(2, 2));
            int day = int.Parse(id.Substring(4, 2));

            DateTime dateOfBirth = new DateTime(year, month, day);

            _age = DateTime.Now.Year - year;
            if(DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
            {
                _age--;
            }
        }

        private void SetGenderFromId(string id)
        {
            int ageIndicator = int.Parse(id.Substring(6, 4));
            if(ageIndicator < 5000)
            {
                _gender = Gender.Female;
            }
            else
            {
                _gender = Gender.Male;
            }
        }
    }
}
