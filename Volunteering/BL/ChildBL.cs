
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BL
{
    public class ChildBL
    {
        static volunteeringEntities1 volunteeringET = new volunteeringEntities1();
        //מוסיפה ילד חדש 
        public static bool NewChild(child newChild)
        {
            if(volunteeringET.child.FirstOrDefault(child=>child.tz==newChild.tz)==null)
            {
                volunteeringET.child.Add(newChild);
                volunteeringET.SaveChanges();
                return true;
            }
            return false;
        }
            //מחזירה ילד לפי תעודת זהות
            public static childDTO GetChildById(int id)
        {
            child c = volunteeringET.child.Where(x => x.childID == id).FirstOrDefault();
            return cast.toChildDTO.GetChild(c);
        }
        //מחזירה את כל רשימת הילדים שהסטטוס שלהם לא פעיל
        public static List<childDTO> GetAllChildrenWhoNeedAproval()
        {
            List<child> ListOfCildToAproval = new List<child>();
            ListOfCildToAproval = volunteeringET.child.Where(c => c.status== EStatusChild.INACTIVE.ToString()).ToList();
            List<childDTO> ListOfCildToAprovalConverts = new List<childDTO>();
            foreach (child child in ListOfCildToAproval)
            {
                ListOfCildToAprovalConverts.Add(cast.toChildDTO.GetChild(child));
            }
            return ListOfCildToAprovalConverts;
        }
        //מקבלת ילד לפי תעודת זהות ומשנה לו את הסטטוס לפעיל
        public static bool UpdateTheStatus(int id) 
        {
            child c = volunteeringET.child.Find(id);
            if (c != null)
            {
                c.status = EStatusChild.ACTIVE.ToString();
                string password = GlobalBL.ToRaffleAndPostUserNameAndPassword();
                family f = volunteeringET.family.Find(c.familyId);
                f.password = password;
                f.userName = f.lastName + f.phone;
                volunteeringET.SaveChanges();
                string body = "ברכות, כעת נרשמת בהצלחה לידיד לילד ותוכל להשתמש במגוון שירותי האתר , הסיסמא ושם המשתמש שאיתם תוכל להיכנס לאתר הם: "
                   + "your password is: " + f.password + f.userName;
                string subject = "בקשה להרשמה לאתר ידיד לילד";
                GlobalBL.SendEmail(f.mail, subject, body);
                return true;
            }
            return false;
        }


        //מחזירה את רשימת הילדים
        public static List<childDTO> GetAllChildrens()
        {
            List<child> listOfChildrens = volunteeringET.child.ToList();
            List<childDTO> listOfChildrenscasting = new List<childDTO>();
            foreach (var item in listOfChildrens)
            {
                listOfChildrenscasting.Add(cast.toChildDTO.GetChild(item));
            }
            return listOfChildrenscasting;
        }
        //מחזירה את כמות הילדים שהצטרפו לאתר לפי חודשים
        //public static SortedList<int,int> CountChildrensInMounth()
        //{
        //    SortedList<int, int> listMonthAndChildrens = new SortedList<int, int>();
        //    var q = from volunteer in volunteeringET.child
        //            group volunteer by volunteer.dateEntryToSite.Value.Month;
        //    foreach (var item in q)
        //    {
        //        listMonthAndChildrens.Add(item.Key,)
        //    }

        //}
        //מחזירה פעיל ולא פעיל באחוזים
        public static float GetActiveAndInactiveInPercent()
        {
            float countActive = volunteeringET.child.Count(c => c.status == EStatusChild.ACTIVE.ToString());
            float countInactive = volunteeringET.child.Count(c => c.status == EStatusChild.INACTIVE.ToString());
            return (countActive / (countActive + countInactive))*100;
        }
        //מחזירה חודשים לצד כמות ילדים שהצטרפו בחודש זה

    }
}

