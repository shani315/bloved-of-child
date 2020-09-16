using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BL.cast
{
    class toVolunteerOfChildDTO
    {
        public volunteerOfChildDTO GetVolunteerOfChild(volunteerOfChild vfc)
        {
            volunteerOfChildDTO newVolunteerOfChild = new volunteerOfChildDTO();
            newVolunteerOfChild.childId = vfc.childId;
            newVolunteerOfChild.day = vfc.day;
            newVolunteerOfChild.details = vfc.details;
            newVolunteerOfChild.hour = vfc.hour;
            newVolunteerOfChild.remarks = vfc.remarks;
            newVolunteerOfChild.volunteerId = vfc.volunteerId;
            newVolunteerOfChild.volunteerOfChildID = vfc.volunteerOfChildID;
            return newVolunteerOfChild;
        }
    }
}
