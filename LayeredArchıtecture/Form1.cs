using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using LogicLayer;

namespace LayeredArchıtecture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<EntityStaff> StaffList = LogicStaff.LlStaffList();
            dataGridView1.DataSource = StaffList;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            EntityStaff ent = new EntityStaff();
            ent.Name1 = txtName.Text;
            ent.Surname1 = TxtSurname.Text;
            ent.City1 = txtCıty.Text;
            ent.Task1 = txtTask.Text;
            ent.Salary1 = int.Parse(TxtSalary.Text);
            LogicStaff.LlAddStaff(ent);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            EntityStaff ent = new EntityStaff();
            ent.Id1 = Convert.ToInt32(txtId.Text);
            LogicStaff.LlDeleteStaff(ent.Id1);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            EntityStaff ent = new EntityStaff();
            ent.Id1 = Convert.ToInt32(txtId.Text);
            ent.Name1 = txtName.Text;
            ent.Surname1 = TxtSurname.Text;
            ent.City1 = txtCıty.Text;
            ent.Task1 = txtTask.Text;
            ent.Salary1 = int.Parse(TxtSalary.Text);
            LogicStaff.LlAddStaff(ent);
        }
    }
}
