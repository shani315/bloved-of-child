using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BL.cast
{
    class toVolunteerDTO
    {
        public static volunteerDTO GetVolunteer(volunteer v)
        {
            volunteerDTO newVolunteer = new volunteerDTO();
            newVolunteer.age = v.age;
            newVolunteer.dateEntryToSite = v.dateEntryToSite;
            newVolunteer.firstName = v.firstName;
            newVolunteer.formContact = v.formContact;
            newVolunteer.lastName = v.lastName;
            newVolunteer.mail = v.mail;
            newVolunteer.password = v.password;
            newVolunteer.phone = v.phone;
            newVolunteer.sax = v.sax;
            newVolunteer.status = v.status;
            newVolunteer.userName = v.userName;
            newVolunteer.volunteerID = v.volunteerID;
            return newVolunteer;
        }
    }
}
