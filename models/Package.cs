using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace just_cargo.models
{
    internal class Package
    {
        public string Name { get; set; }
        public int Id { get; }
        static int _id;
        public string PackingNumber { get; set; }
        public string RecieveName { get; set; }
        public string RecieveAddress { get; set; }
        public double Weight { get; set; }


    }
}
