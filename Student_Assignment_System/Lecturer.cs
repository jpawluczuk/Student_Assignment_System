﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Student_Assignment_System
{
    class Lecturer : Person
    {
        public string LecturerID { get; set; }
        public string LecturerPassword { get; set; }
        public string ModulesToTeach { get; set; }
        public string DateOfHire { get; set; }

        public Lecturer(
            string pname, string pDOB, string pAddress, string pPPSNumber, string LecturerID, string LecturerPassword, string ModulesToTeach, string DateOfHire)
            : base(pname, pDOB, pAddress, pPPSNumber)
        {
            this.LecturerID = LecturerID;
            this.LecturerPassword = LecturerPassword;
            this.ModulesToTeach = ModulesToTeach;
            this.DateOfHire = DateOfHire;
        }



    }
}