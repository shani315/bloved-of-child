using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BL.cast
{
    class toTypeDisabilityDTO
    {
        public typeDisabilityDTO GetTypeDisability(typeDisability td)
        {
            typeDisabilityDTO newTypeDisability = new typeDisabilityDTO();
            newTypeDisability.AHD = td.AHD;
            newTypeDisability.ASD = td.ASD;
            newTypeDisability.childId = td.childId;
            newTypeDisability.communication = td.communication;
            newTypeDisability.downSyndrome = td.downSyndrome;
            newTypeDisability.hearing = td.hearing;
            newTypeDisability.incapacity = td.incapacity;
            newTypeDisability.lag = td.lag;
            newTypeDisability.typeDisabilityID = td.typeDisabilityID;
            newTypeDisability.typeUser = td.typeUser;
            newTypeDisability.violence = td.violence;
            newTypeDisability.volunteerId = td.volunteerId;
            return newTypeDisability;
            newTypeDisability.AHD = td.AHD;
        }
    }
}
