using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunwoodyHousing
{
    [Serializable]
    abstract public class Resident
    {
        public string IDNumber { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string roomNumber { get; set; }

        public string floorNumber { get; set; }

        public double monthlyRent { get; set; }


    }
}
