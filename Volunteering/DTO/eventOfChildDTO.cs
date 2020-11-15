using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class eventOfChildDTO
    {
        public int eventOfChildID { get; set; }
        public Nullable<int> organizingSecretary { get; set; }
        public string typeEvent { get; set; }
        public Nullable<System.DateTime> dateEvent { get; set; }
        public Nullable<int> maxNumChildren { get; set; }
        public Nullable<int> actualNumChildren { get; set; }
        public string placeEvent { get; set; }
        public string description { get; set; }
    }
}
