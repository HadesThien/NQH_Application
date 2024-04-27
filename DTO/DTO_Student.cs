﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Student :DTO_Person
    {
        //Properties
        public string School { get; set; }
        public string Number { get; set; }
        public string Street { get; set; }
        public string Ward { get; set; }
        public string District { get; set; }
        public string DateCreated { get; set; }
        public List<DTO_Register> Registers { get; set; }
        public List<DTO_Payment> Payments { get; set; }
        public List<DTO_Buy> Buys { get; set; }

        //Constructor
        public DTO_Student(string id, string name, string gender, DateTime dob,string numberPhone, string school, string number, string street, string ward, string district, string dateCreated)
            : base(id, name, gender, dob,numberPhone) {
            School = school;
            Number = number;
            Street = street;
            Ward = ward;
            District = district;
            DateCreated = dateCreated;
            Registers = new List<DTO_Register> ();
            Payments = new List<DTO_Payment>();
            Buys = new List<DTO_Buy>();
        }
        //Methods
        public void register(DTO_Register r) {
            Registers.Add(r);
        }
        public void removeRegister(DTO_Register r) {
            Registers.Remove(r);
        }
    }
}
