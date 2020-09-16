using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BL
{
   public class VolunteerHistoryBL
    {
        static volunteeringEntities1 volunteeringET = new volunteeringEntities1();
        //מחזירה את כל ההתנדבויות שהיו בשבוע האחרון
         public static List<volunteerHistoryDTO> GetAllTheVolunteersThatWereInTheLastWeek()
        {
            List<volunteerHistory> volunteersH = new List<volunteerHistory>();
            List<volunteerHistoryDTO> volunteersHConverts = new List<volunteerHistoryDTO>();
            DateTime dEnd = DateTime.Now;
            DateTime dFirst = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day - 7);

            volunteersH=volunteeringET.volunteerHistory.Where(v => v.dateVolunteer > dFirst && v.dateVolunteer < dEnd).ToList();
            foreach (var volunteerH in volunteersH)
            {
                volunteersHConverts.Add(cast.toVolunteerHistoryDTO.GetVolunteerHistory(volunteerH));
            }
            return volunteersHConverts;
        }
    }
}
