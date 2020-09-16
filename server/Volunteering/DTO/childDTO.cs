using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
 public enum EStatusChild { ACTIVE, INACTIVE, PENDING }
    public class childDTO
    {
        public string city { get; set; }
        public string street { get; set; }
        public Nullable<int> houseNumber { get; set; }
        public string phone { get; set; }
        public string mail { get; set; }
        public string formContact { get; set; }
        public Nullable<int> childrenOnSite { get; set; }
        public int childID { get; set; }
        public Nullable<int> familyId { get; set; }
        public string firstName { get; set; }
        public Nullable<int> age { get; set; }
        public string sax { get; set; }
        public string status { get; set; }
        public Nullable<System.DateTime> dateEntryToSite { get; set; }
    }
}
