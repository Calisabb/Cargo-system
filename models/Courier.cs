using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace just_cargo.models
{
    public  class Courier
    {
        public int Id { get;  }
        static int _id;
        public string FullName { get; set; }
        public bool IsAvailable { get; set; }
        public int DeliveredCount { get; private set; }

        public Courier(string FullName,bool IsAvailable,int DeliveredCount)
        {
            this.FullName = FullName;
            this.IsAvailable = IsAvailable;
            this.DeliveredCount = DeliveredCount;
            Id = ++_id;
        }

    }
}
