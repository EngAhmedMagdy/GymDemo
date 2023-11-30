using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GymDemo.Data;
namespace GymDemo
{
    public partial class Members : Form
    {
        public Members()
        {
            InitializeComponent();
            DataGridViewButtonColumn DeleteButton = new DataGridViewButtonColumn()
            {
                Text = "Delete",
                Name = "DeleteMember",
                UseColumnTextForButtonValue = true
            };
            DataGridViewButtonColumn UpdateButton = new DataGridViewButtonColumn()
            {
                Text = "Update",
                Name = "UpdateMember",
                UseColumnTextForButtonValue= true
            };
           
            dataGridView1.DataSource = MemberData.members;
            dataGridView1.Columns.Add(DeleteButton);
            dataGridView1.Columns.Add(UpdateButton);
        }
    }
}
