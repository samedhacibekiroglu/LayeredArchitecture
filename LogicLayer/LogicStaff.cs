using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace LogicLayer
{
    public class LogicStaff
    {
        public static List<EntityStaff> LlStaffList()
        {
            return DalStaff.StaffList();
        }
        public static int LlAddStaff(EntityStaff p)
        {
            if (p.Name1 !="" && p.Surname1 !="" &&p.Name1.Length >=3)
            {
                return DalStaff.AddStaff(p);
            }
            else
            {
                return -1;
            }
        }
        public static bool LlDeleteStaff(int sta)
        {
            if (sta >= 1)
            {
                return DalStaff.DeleteStaff(sta);      
            }
            else
            {
                return false;
            }
        }
        public static bool LlUpdateStaff(EntityStaff ent)
        {
            if (ent.Name1 != "")
            {
                return DalStaff.UpdateStaff(ent);
            }
            else
            {
                return false;
            }
        }
    }
}
