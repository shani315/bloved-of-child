using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BL
{
    public class FamilyBL
    {
      static volunteeringEntities1 volunteeringET = new volunteeringEntities1();
        //מוסיפה משפחה
        public static bool newFamily(family family)
        {
            if (volunteeringET.family.FirstOrDefault(f => f.mail == family.mail) == null)
            {
                volunteeringET.family.Add(family);
                volunteeringET.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
