using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public enum EStatusVolunteer { LEFTONHEROWN, FIRED, EXSISTS};
    public class volunteerDTO
    {
        public int volunteerID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string phone { get; set; }
        public Nullable<int> age { get; set; }
        public string status { get; set; }
        public string mail { get; set; }
        public string formContact { get; set; }
        public string sax { get; set; }
        public Nullable<System.DateTime> dateEntryToSite { get; set; }
    }
}
