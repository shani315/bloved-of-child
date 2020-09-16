using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BL.cast
{
    class toChildEventDTO
    {
public childEventDTO GetChildEvent(childEvent ce)
        {
            childEventDTO newchildEvent = new childEventDTO();
            newchildEvent.childEventID = ce.childEventID;
            newchildEvent.childId = ce.childId;
            newchildEvent.eventId = ce.eventId;
            return newchildEvent;        }
    }
}
