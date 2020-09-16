using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class typeDisabilityDTO
    {
        public int typeDisabilityID { get; set; }
        public string typeUser { get; set; }
        public int volunteerId { get; set; }
        public string hearing { get; set; }
        public byte[] incapacity { get; set; }
        public string communication { get; set; }
        public string violence { get; set; }
        public string ASD { get; set; }
        public string lag { get; set; }
        public string AHD { get; set; }
        public string downSyndrome { get; set; }
        public int childId { get; set; }
    }
}
