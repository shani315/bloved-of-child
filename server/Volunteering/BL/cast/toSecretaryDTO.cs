using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BL.cast
{
    class toSecretaryDTO
    {
        public secretaryDTO GetSecretary(secretary s)
        {
            secretaryDTO newSecretary = new secretaryDTO();
            newSecretary.accessRights = s.accessRights;
            newSecretary.city = s.city;
            newSecretary.firstName = s.firstName;
            newSecretary.lastName = s.lastName;
            newSecretary.password = s.password;
            newSecretary.secretaryID = s.secretaryID;
            newSecretary.userName = s.userName;
            return newSecretary;

        }
    }
}
