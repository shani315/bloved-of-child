using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BL
{
    public class EventOfVolunteerBL
    {
        static volunteeringEntities1 volunteeringET = new volunteeringEntities1();
        //בדיקה מי יכולה להשתתף באירוע ושליחת אימייל לכל אחת
        public static bool invitationParticipants(int eventsVolunteerID)
        {
            //בדיקה מי יכול להשתתף באירוע לפי מספר שעות התנדבות מינימאלי
            eventsVolunteer eventsVolunteer = volunteeringET.eventsVolunteer.Find(eventsVolunteerID);
            var groupByIdVolunteer = volunteeringET.volunteerHistory.GroupBy(x => x.volunteerOfChildId);

            volunteeringET.volunteerHistory.GroupBy(v => v.volunteerOfChildId);
            return true;
        }
        // מתנדב מאשר השתתפות באירוע
        public static bool approvalParticipationInEvent(int id)
        {
            eventOfVolunteer eventOfVolunteer= volunteeringET.eventOfVolunteer.Find(id);
            if(eventOfVolunteer!=null)
            {
                eventOfVolunteer.IsParticipant = eIsParticipant.participation.ToString();
                volunteeringET.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
