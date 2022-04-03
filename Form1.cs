using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace double_queries
{
   
    public partial class Form1 : Form
    {
        DataTable data = new DataTable();
        
        public Form1()
        {
            InitializeComponent();

            data.Columns.Add(" name");
            data.Columns.Add(" id");
            data.Columns.Add(" CNIC");
            data.Columns.Add(" AGE");
            dataGridView1.DataSource = data;
            dataGridView1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             DataRow row1 = data.NewRow();

             row1[" name"] = textBox1.Text;
            row1[" id"] = textBox2.Text;
             row1[" CNIC"] = textBox3.Text;
             row1[" AGE"] = textBox4.Text;
            data.Rows.Add(row1);
            dataGridView1.DataSource = data;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(data);
            this.Hide();
            form.Show();

        }
    }
}
