using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BL.cast
{
    class toEventOfChildDTO
    {
        public eventOfChildDTO GetEventOfChild(eventOfChild eoc)
        {
            eventOfChildDTO newEventOfChild = new eventOfChildDTO();
            newEventOfChild.actualNumChildren = eoc.actualNumChildren;
            newEventOfChild.dateEvent = eoc.dateEvent;
            newEventOfChild.description = eoc.description;
            newEventOfChild.eventOfChildID = eoc.eventOfChildID;
            newEventOfChild.maxNumChildren = eoc.maxNumChildren;
            newEventOfChild.organizingSecretary = eoc.organizingSecretary;
            newEventOfChild.placeEvent = eoc.placeEvent;
            newEventOfChild.typeEvent = eoc.typeEvent;
            return newEventOfChild;
        }
    }
}
