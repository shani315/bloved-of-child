using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BL
{
    public class VolunteerOfChildBL
    {
        static volunteeringEntities1 volunteeringET = new volunteeringEntities1();
        //מאשרת בקשת התנדבות
        public static bool contentedVolunteering(int volunteerOfChildID)
        {
            volunteerOfChild v = volunteeringET.volunteerOfChild.Find(volunteerOfChildID);
            if (v != null)
            {
                v.status = EStatus.contented.ToString();
                volunteeringET.SaveChanges();
                return true;
            }
            return false;
        }
        //דוחה בקשת התנדבות
        public static bool SpurnedVolunteering(int volunteerOfChildID)
        {
            volunteerOfChild v = volunteeringET.volunteerOfChild.Find(volunteerOfChildID);
            if (v != null)
            {
                v.status = EStatus.spurned.ToString();
                volunteeringET.SaveChanges();
                return true;
            }
            return false;
        }
        //ביטול קבוע של התנדבות
        public static bool CancelledVolunteering(int volunteerOfChildID)
        {
            volunteerOfChild voc = volunteeringET.volunteerOfChild.Find(volunteerOfChildID);
            if (voc != null)
            {
                child c = volunteeringET.child.Find(voc.childId);
                family f = volunteeringET.family.Find(c.familyId);
                volunteer v = volunteeringET.volunteer.Find(voc.volunteerId);
                string subject = "ביטול התנדבות קבועה";
                string mail = f.mail;
                string body = "שלום וברכה!, מתנצלים אך נראה שהמתנדבת  " + v.firstName + " " + v.lastName +
                    " אינה יכולה עוד להתחייב בהתנדבות שנערכת ביום " + voc.day + "  בשעה: " + voc.hour +
                    "בקרוב נעדכן אותכם על מתנדבת נוספת המתאימה לתפקיד ,תודה וסליחה.";
                GlobalBL.SendEmail(mail, subject, body);
                v.status = EStatus.cancelled.ToString();
                volunteeringET.SaveChanges();
                return true;
            }
            return false;
        }
        //ביטול קבוע של התנדבות
        public static bool CancellationIndividualdVolunteering(int volunteerOfChildID)
        {
            volunteerOfChild voc = volunteeringET.volunteerOfChild.Find(volunteerOfChildID);
            if (voc != null)
            {
                child c = volunteeringET.child.Find(voc.childId);
                family f = volunteeringET.family.Find(c.familyId);
                volunteer v = volunteeringET.volunteer.Find(voc.volunteerId);
                string subject = "ביטול התנדבות חד פעמי";
                string mail = f.mail;
                string body = "שלום וברכה!, מתנצלים אך נראה שהמתנדבת  " + v.firstName + " " + v.lastName +
                    " אינה יכולה להתנדב ביום  " + voc.day + "  בשעה: " + voc.hour +
                    "בצורה חד פעמית ,סליחה ותודה מראש על ההבנה";
                GlobalBL.SendEmail(mail, subject, body);
                return true;
            }
            return false;
        }
    }
}
