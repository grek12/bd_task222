﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bd_task222
{
    public partial class Form2 : Form
    {
        DB_Tools db = new DB_Tools();
        DataTable table = new DataTable();
        public Form2()
        {
            InitializeComponent();
            dataGridView1.DataSource = table;
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.Fill($"Select * from Customers where [Address] Like '%{textBox1.Text}%';", table);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            db.Fill($"Select * from Customers where [Family] Like '%{textBox2.Text}%';", table);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            db.Fill($"Select Commondity, Min(price) from Providers Where Commondity = '{textBox3.Text}' Group by Commondity;", table);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            db.Fill($"select * from Providers where Commondity = '{textBox4.Text}' order by Price asc;", table);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
