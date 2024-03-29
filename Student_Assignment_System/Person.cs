﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Assignment_System
{
    [Serializable]
    public abstract class Person
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string PPSNumber { get; set; }

        public Person()
        {

        }
        public Person(string pName, DateTime pDOB, string pAddress, string pPPSNumber)
        {
            this.Name = pName;
            this.DateOfBirth = pDOB;
            this.Address = pAddress;
            this.PPSNumber = pPPSNumber;
        }

        public override string ToString()
        {
            return String.Join(",", this.Name, this.DateOfBirth, this.Address, this.PPSNumber);
        }
    }
}
