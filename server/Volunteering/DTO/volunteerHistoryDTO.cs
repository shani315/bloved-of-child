using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class volunteerHistoryDTO
    {
        public int volunteerHistoryID { get; set; }
        public Nullable<int> volunteerId { get; set; }
        public Nullable<int> childId { get; set; }
        public Nullable<int> volunteerOfChildId { get; set; }
        public Nullable<int> volunteerQualityId { get; set; }
        public System.TimeSpan hour { get; set; }
        public System.DateTime dateVolunteer { get; set; }
        public string remarks { get; set; }
    }
}
