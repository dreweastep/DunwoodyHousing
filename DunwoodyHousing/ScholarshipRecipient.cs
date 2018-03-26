using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunwoodyHousing
{
    [Serializable]
    class ScholarshipRecipient : Resident
    {
        public ScholarshipRecipient(string id, string fName, string lName,
                       string roomNum, string floorNum)
        {
            IDNumber = id;
            firstName = fName;
            lastName = lName;
            roomNumber = roomNum;
            floorNumber = floorNum;
            monthlyRent = 100;
        }
    }
}
