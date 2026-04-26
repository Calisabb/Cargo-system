using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace just_cargo.models
{
    public class Customer
    {
        public int Id { get; }
        static int _id;
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int PackageCount { get; private set; }

        public Customer(string fullName, string phoneNumber, string address)
        {
            Id = ++_id;
            FullName = fullName;
            PhoneNumber = phoneNumber;
            Address = address;
            PackageCount = 0;
        }
    }
}
