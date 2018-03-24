using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunwoodyHousing
{
    class StudentAthlete : Resident
    {
        public StudentAthlete(string id, string fName, string lName,
                        string roomNum, string floorNum)
        {
            IDNumber = id;
            firstName = fName;
            lastName = lName;
            roomNumber = roomNum;
            floorNumber = floorNum;
            monthlyRent = 1200;
        }
    }
}
