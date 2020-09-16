using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.cast
{
    class toVolunteerHistoryDTO
    {
        public static volunteerHistoryDTO GetVolunteerHistory(volunteerHistory vh)
        {
            volunteerHistoryDTO newVolunteerHistory = new volunteerHistoryDTO();
            newVolunteerHistory.childId = vh.childId;
            newVolunteerHistory.dateVolunteer = vh.dateVolunteer;
            newVolunteerHistory.hour = vh.hour;
            newVolunteerHistory.remarks = vh.remarks;
            newVolunteerHistory.volunteerHistoryID = vh.volunteerHistoryID;
            newVolunteerHistory.volunteerId = vh.volunteerId;
            newVolunteerHistory.volunteerOfChildId = vh.volunteerOfChildId;
            newVolunteerHistory.volunteerQualityId = vh.volunteerQualityId;
            return newVolunteerHistory;
        }
    }
}
