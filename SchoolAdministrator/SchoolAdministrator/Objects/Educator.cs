using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdministrator.Objects
{
    internal class Educator: SchoolEmployee
    {
        private Class _formClass;

        public Educator(string employeeId, string name, string surname, string id, Gender gender, MaritalStatus maritalStatus, Class formClass) : 
            base(employeeId, name, surname, id, gender, maritalStatus)
        {
            _formClass = formClass;
        }

        internal Class FormClass { get => _formClass; set => _formClass = value; }
    }
}
