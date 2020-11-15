using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public enum EStatus { contented, spurned, cancelled }
    public class volunteerOfChildDTO
    {
        public int volunteerOfChildID { get; set; }
        public Nullable<int> volunteerId { get; set; }
        public Nullable<int> childId { get; set; }
        public Nullable<System.TimeSpan> hour { get; set; }
        public Nullable<int> day { get; set; }
        public string details { get; set; }
        public string remarks { get; set; }
    }
}
