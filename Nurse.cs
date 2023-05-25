using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital
{

    // Derived class Nurse
    internal class Nurse : Employee
    {
    
        private Room roomAttended { get; set; }


        // Constructor
        public Nurse(int id, string lastName, string firstName, int age, decimal salary, Room roomAttended)
            : base(id, lastName, firstName, age, salary)
        {
            this.roomAttended = roomAttended;
        }

        // Override method to print nurse details
        public new string PrintDetails()
        {
            return ($"Nurse | Nurse Code: {Id} | Room Attended: {roomAttended}") +
            base.PrintDetails();
        }

    }


    


    // Driver class
    
}

