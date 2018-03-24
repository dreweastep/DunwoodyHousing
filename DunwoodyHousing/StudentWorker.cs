using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunwoodyHousing
{
    class StudentWorker : Resident
    {
        public int monthlyHours;

        public StudentWorker(string id, string fName, string lName,
                        string roomNum, string floorNum, int hours)
        {
            IDNumber = id;
            firstName = fName;
            lastName = lName;
            roomNumber = roomNum;
            floorNumber = floorNum;
            monthlyHours = hours;
            monthlyRent = 1245 - ((monthlyHours * 14) / 2);
        }
    }
}
