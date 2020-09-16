using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BL.cast
{
    class toFamiyDTO
    {
        public familyDTO GetFamily(family f)
        { 
          familyDTO newfamily = new familyDTO();
            newfamily.childrenOnSite = f.childrenOnSite;
            newfamily.city = f.city;
            newfamily.familyID = f.familyID;
            newfamily.formContact = f.formContact;
            newfamily.houseNumber = f.houseNumber;
            newfamily.lastName = f.lastName;
            newfamily.mail = f.mail;
            newfamily.password = f.password;
            newfamily.phone = f.phone;
            newfamily.street = f.street;
            newfamily.userName = f.userName;
            return newfamily;

        }

    }
}
