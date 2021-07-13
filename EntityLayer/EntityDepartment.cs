using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
   public class EntityDepartment
    {
        private int DepartmentId;
        private string DepartmentName;
        private string DepartmentSurname;

        public int DepartmentId1 { get => DepartmentId; set => DepartmentId = value; }
        public string DepartmentName1 { get => DepartmentName; set => DepartmentName = value; }
        public string DepartmentSurname1 { get => DepartmentSurname; set => DepartmentSurname = value; }
    }
}
