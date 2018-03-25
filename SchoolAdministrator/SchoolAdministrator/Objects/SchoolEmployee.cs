using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdministrator.Objects
{
    public enum MaritalStatus
    {
        Single,
        Married
    }

    class SchoolEmployee
    {
        private string _employeeId;
        private string _name;
        private string _surname;
        private string _id;
        private Gender _gender;
        private MaritalStatus _maritalStatus;

        public SchoolEmployee(string employeeId, string name, string surname, string id, Gender gender, MaritalStatus maritalStatus)
        {
            _employeeId = employeeId;
            _name = name;
            _surname = surname;
            _id = id;
            _gender = gender;
            _maritalStatus = maritalStatus;
        }

        public string EmployeeId { get => _employeeId; set => _employeeId = value; }
        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public string Id { get => _id;}
        public MaritalStatus MaritalStatus { get => _maritalStatus; set => _maritalStatus = value; }
    }
}
