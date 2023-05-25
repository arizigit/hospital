using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital
{
    internal class Patient
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public string SecurityName { get; set; }
        public string PensionName { get; set; }
        public decimal Salary { get; set; }
        public List<Physician> Physicians { get; set; }

        public Patient(int id, string ln, string fn, int age)
        {
            Id = id;
            LastName = ln;
            FirstName = fn;
            Age = age;
            Physicians = new List<Physician>();
        }
    }
}
