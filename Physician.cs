using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital
{
    internal class Physician : Employee
    {
        public List<Patient> Patients { get; set; }

        public Physician(int id, string lastName, string firstName, int age, decimal salary)
            : base(id, lastName, firstName, age, salary)
        {
            Patients = new List<Patient>();
        }

        public new string PrintDetails()
        {
            return ($"Physician | Physician Code: {Id} ") +
            base.PrintDetails();
        }
    }
}



