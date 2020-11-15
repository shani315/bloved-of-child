using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BL
{
    public class TypeDisabilityBL
    {
       static volunteeringEntities1 volunteeringET = new volunteeringEntities1();
        //מוסיפה סוג התנדבות למתנדב/מוגבלות לילד חדש
        public static bool addtypeDisability(typeDisability typeDisability)
        {

            if (volunteeringET.typeDisability.FirstOrDefault(t => t.childId == typeDisability.childId) == null)
            {
                volunteeringET.typeDisability.Add(typeDisability);
                volunteeringET.SaveChanges();

                return true;
            }
            else
                return false;

        }
    }
}
