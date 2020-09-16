using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
    namespace BL.cast
{
    class toChildDTO
    {
       static volunteeringEntities1 volunteeringET = new volunteeringEntities1();
        public static childDTO GetChild(child c)
        {
            childDTO newChild = new childDTO();
            family f = volunteeringET.family.Find(c.familyId);
            newChild.age = c.age;
            newChild.childID = c.childID;
            newChild.dateEntryToSite = c.dateEntryToSite;
            newChild.familyId = c.familyId;
            newChild.firstName = c.firstName;
            newChild.sax = c.sax;
            newChild.childrenOnSite = f.childrenOnSite;
            newChild.city = f.city;
            newChild.mail = f.mail;
            newChild.phone = f.phone;
            newChild.street = f.street;
            newChild.houseNumber = f.houseNumber;
            newChild.formContact = f.formContact;
            return newChild;
        }
        
    }
}
