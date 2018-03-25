using System.Collections.Generic;

namespace SchoolAdministrator.Objects
{
    internal class Class
    {
        private List<Student> _students;
        private Educator _educator;
        private string _name;

        public Class(Educator educator, string name)
        {
            _educator = educator;
            name = _name;
        }

        public List<Student> Students { get => _students; set => _students = value; }
        public string Name { get => _name; set => _name = value; }
        internal Educator Educator { get => _educator; set => _educator = value; }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
    }
}