using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    enum EFormContact {SMS,EMAIL }
   public class familyDTO
    {
        public int familyID { get; set; }
        public string lastName { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public Nullable<int> houseNumber { get; set; }
        public string phone { get; set; }
        public string mail { get; set; }
        public string formContact { get; set; }
        public Nullable<int> childrenOnSite { get; set; }
    }
}
