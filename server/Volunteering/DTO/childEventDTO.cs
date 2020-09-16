using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class childEventDTO
    {
        public int childEventID { get; set; }
        public Nullable<int> eventId { get; set; }
        public Nullable<int> childId { get; set; }
    }
}
