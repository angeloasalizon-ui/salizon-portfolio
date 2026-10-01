using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SALIZONPOGI
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//WLAY LABOT
        {
            dataGridView1.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) //WLAY LABOT
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

            dataGridView1.ColumnCount = 5;

            dataGridView1.Columns[0].Name = "Code";
            dataGridView1.Columns[1].Name = "Subject Name";
            dataGridView1.Columns[2].Name = "Section";
            dataGridView1.Columns[3].Name = "Schedule";
            dataGridView1.Columns[4].Name = "Units";


            string[,] subjects =
            {
        { "ICT101", "Introduction to Programming", "BSIT-1A", "Mon 8:00-10:00 AM", "3" },
        { "ICT102", "Computer Fundamentals", "BSIT-1A", "Tue 10:00-12:00 PM", "3" },
        { "ICT103", "Web Development Basics", "BSIT-1B", "Wed 1:00-3:00 PM", "3" },
        { "ICT104", "Database Management", "BSIT-1A", "Thu 9:00-11:00 AM", "3" },
        { "ICT105", "Object-Oriented Programming", "BSIT-1B", "Fri 2:00-4:00 PM", "4" },
        { "ICT106", "Networking Fundamentals", "BSIT-1C", "Mon 1:00-3:00 PM", "3" },
        { "ICT107", "System Analysis and Design", "BSIT-1A", "Tue 8:00-10:00 AM", "3" },
        { "ICT108", "Human Computer Interaction", "BSIT-1C", "Wed 10:00-12:00 PM", "2" }
    };


            for (int i = 0; i < subjects.GetLength(0); i++)
            {
                dataGridView1.Rows.Add(
                    subjects[i, 0],
                    subjects[i, 1],
                    subjects[i, 2],
                    subjects[i, 3],
                    subjects[i, 4]
                );
            }

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 lamionaq = new Form1();
            lamionaq.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
