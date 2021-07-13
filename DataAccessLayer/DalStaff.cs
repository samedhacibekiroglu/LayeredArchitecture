using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
   public class DalStaff
    {
        public static List<EntityStaff> StaffList()
        {
            List<EntityStaff> valuess = new List<EntityStaff>();
            SqlCommand command1 = new SqlCommand("Select * From Table_Information",Connection.bgl);
            if (command1.Connection.State != ConnectionState.Open)
            {
                command1.Connection.Open();
            }
            SqlDataReader dr = command1.ExecuteReader();
            while (dr.Read())
            {
                EntityStaff ent = new EntityStaff();
                ent.Id1 = int.Parse(dr["Id"].ToString());
                ent.Name1 = dr["Name"].ToString();
                ent.Surname1 = dr["Surname"].ToString();
                ent.City1 = dr["City"].ToString();
                ent.Task1 = dr["Task"].ToString();
                ent.Salary1 = decimal.Parse(dr["Salary"].ToString());
                valuess.Add(ent);
            }
            dr.Close();
            return valuess;
        }
        public static int AddStaff(EntityStaff p)
        {
            SqlCommand command2 = new SqlCommand("insert into Table_Information(Name,Surname,City,Task,Salary) VALUES(@p1,@p2,@p3,@p4,@p5)",Connection.bgl);
            if (command2.Connection.State !=ConnectionState.Open)
            {
                command2.Connection.Open();
            }
            command2.Parameters.AddWithValue("@p1", p.Name1);
            command2.Parameters.AddWithValue("@p2", p.Surname1);
            command2.Parameters.AddWithValue("@p3", p.City1);
            command2.Parameters.AddWithValue("@p4", p.Task1);
            command2.Parameters.AddWithValue("p5", p.Salary1);
            return command2.ExecuteNonQuery();
        }
        public static bool DeleteStaff(int p)
        {
            SqlCommand command3 = new SqlCommand("Delete from Table_Information where Id=@p1", Connection.bgl);
            if (command3.Connection.State !=ConnectionState.Open)
            {
                command3.Connection.Open();
            }
            command3.Parameters.AddWithValue("@p1", p);
            return command3.ExecuteNonQuery() > 0;
        }
        public static bool UpdateStaff(EntityStaff ent)
        {
            SqlCommand command4 = new SqlCommand("Update Table_Information SET Name=@p1,Surname=@p2,City=@p3,Task=@p4,Salary=@p5 where Id=@p6", Connection.bgl);
            if (command4.Connection.State != ConnectionState.Open)
            {
                command4.Connection.Open();
            }
            command4.Parameters.AddWithValue("@p1", ent.Name1);
            command4.Parameters.AddWithValue("@p2", ent.Surname1);
            command4.Parameters.AddWithValue("@p3", ent.City1);
            command4.Parameters.AddWithValue("@p4", ent.Task1);
            command4.Parameters.AddWithValue("@p5", ent.Salary1);
            command4.Parameters.AddWithValue("@p6", ent.Id1);
            return command4.ExecuteNonQuery() >0;
        }
    }
}
