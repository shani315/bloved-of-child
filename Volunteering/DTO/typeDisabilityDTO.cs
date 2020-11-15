using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public enum eTypeUser { volunteer,child}
    public enum eCommunication { exhausting ,ipad, letteres, FacialExpressions, SignLanguage, NotCalling, Other, immaterial }
    public enum eViolence { himself , ToTheEnvironment, ToHimselfAndTheEnvironment, without }
    public enum eAHD { yes,no}
    public enum eLag { easy , medium , difficult }
    public enum eIncapacity { ship ,cp, MuscularDystrophy, Going, DisabilityNotFromTheSyndrome ,}
    public enum eDownSyndrome { TheHowlOfTheCat, Rath, Glider, HighPerformance}
    public enum eASD { PDD , PDD_NOS , AspergerSyndrome}
   public class typeDisabilityDTO
    {
        public int typeDisabilityID { get; set; }
        public string typeUser { get; set; }
        public Nullable<int> volunteerId { get; set; }
        public Nullable<int> eventOfChildId { get; set; }
        public string hearing { get; set; }
        public byte[] incapacity { get; set; }
        public string communication { get; set; }
        public string violence { get; set; }
        public string ASD { get; set; }
        public string lag { get; set; }
        public string AHD { get; set; }
        public string downSyndrome { get; set; }
        public Nullable<int> childId { get; set; }
    }
}
