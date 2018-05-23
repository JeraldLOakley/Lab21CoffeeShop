using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab21.Models
{
    public class Registration
    {
        private string firstName;
        private string lastName;
        private string address;
        private string email;
        private string phoneNumber;

        public Registration(string firstName, string lastName, string address, string email, string phoneNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.email = email;
            this.phoneNumber = phoneNumber;
        }

        public Registration()
        {
            firstName = "";
            lastName = "";
            address = "";
            email = "";
            phoneNumber = "";

        }
       
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
    }
}