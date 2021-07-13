using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
  public class EntityStaff
    {
        private int Id;
        private string Name;
        private string Surname;
        private string City;
        private string Task;
        private decimal Salary;

        public int Id1 { get => Id; set => Id = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string Surname1 { get => Surname; set => Surname = value; }
        public string City1 { get => City; set => City = value; }
        public string Task1 { get => Task; set => Task = value; }
        public decimal Salary1 { get => Salary; set => Salary = value; }
    }
}
