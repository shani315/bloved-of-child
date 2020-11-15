using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BL
{
    public class VolunteerBL
    {
        static volunteeringEntities1 volunteeringET = new volunteeringEntities1();
        //מחזירה את כל רשימת המתנדבים
        public static List<volunteerDTO> GetAllVolunteers()
        {
            List<volunteer> listOfVolunteers = volunteeringET.volunteer.ToList();
            List<volunteerDTO> listOfVolunteersCast = new List<volunteerDTO>();
            foreach (var item in listOfVolunteers)
            {
                listOfVolunteersCast.Add(cast.toVolunteerDTO.GetVolunteer(item));
            }
            return listOfVolunteersCast;
        }
        //מסירה מתנדב ע"י ת.ז
        public static bool removeVolunteerByID(int id)
        {
            volunteer v = volunteeringET.volunteer.Find(id);
            if (v != null)
            {
                volunteeringET.volunteer.Remove(v);
                volunteeringET.SaveChanges();
                GlobalBL.SendEmail(v.mail, "הסרה מהאתר ידיד לילד", "הוסרת מאתר ידיד לילד מאחר ולא התקבל ממך שירות זמן רב");
                return true;
            }
            else
                return false;
        }
        //מחזירה רשימה של מתנדבות שעזבו
        public static List<volunteerDTO> GetVolunteersWhoLeft()
        {
            List<volunteer> listVolunteerWhoLeft=
            volunteeringET.volunteer.Where(v => v.status==EStatusVolunteer.LEFTONHEROWN.ToString()).ToList();
            List<volunteerDTO> listVolunteerWhoLeftConverts = new List<volunteerDTO>();
            foreach (var volunteer in listVolunteerWhoLeft)
            {
                listVolunteerWhoLeftConverts.Add(cast.toVolunteerDTO.GetVolunteer(volunteer));
            }
            return listVolunteerWhoLeftConverts;
        }
        //מוסיפה מתנדבת חדשה למערכת
        public static bool AddNewVolunteer(volunteer v)
        {
            if (volunteeringET.volunteer.FirstOrDefault(x=>x.mail==v.mail)==null)
            {
                volunteeringET.volunteer.Add(v);
                volunteeringET.SaveChanges();
                return true;
            }
            else
                return false;
        }
    }
}