using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SALIZONPOGI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            itlistView.Visible = true;
            crimlistView.Visible = false;
            educlistView.Visible = false;
            nursinglistView.Visible = false;
            engineerlistView.Visible = false;
            tourismlistView.Visible = false;
            balistView.Visible = false;
            hklistView.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            crimlistView.Visible = true;
            educlistView.Visible = false;
            itlistView.Visible = false;
            nursinglistView.Visible = false;
            engineerlistView.Visible = false;
            tourismlistView.Visible = false;
            balistView.Visible = false;
            hklistView.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            educlistView.Visible = true;
            crimlistView.Visible = false;
            itlistView.Visible = false;
            nursinglistView.Visible = false;
            engineerlistView.Visible = false;
            tourismlistView.Visible = false;
            balistView.Visible = false;
            hklistView.Visible = false;
        }

        private void educlistView_SelectedIndexChanged(object sender, EventArgs e)// WLAY LABOT
        {

        }

        private void crimlistView_SelectedIndexChanged(object sender, EventArgs e)// WLAY LABOT
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            nursinglistView.Visible = true;
            itlistView.Visible = false;
            crimlistView.Visible = false;
            educlistView.Visible = false;
            engineerlistView.Visible = false;
            tourismlistView.Visible = false;
            balistView.Visible = false;
            hklistView.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            engineerlistView.Visible = true;
            crimlistView.Visible = false;
            educlistView.Visible = false;
            nursinglistView.Visible = false;
            itlistView.Visible = false;
            tourismlistView.Visible = false;
            balistView.Visible = false;
            hklistView.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tourismlistView.Visible = true;
            engineerlistView.Visible = false;
            crimlistView.Visible = false;
            educlistView.Visible = false;
            nursinglistView.Visible = false;
            itlistView.Visible = false;
            balistView.Visible = false;
            hklistView.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            balistView.Visible = true;
            tourismlistView.Visible = false;
            engineerlistView.Visible = false;
            crimlistView.Visible = false;
            educlistView.Visible = false;
            nursinglistView.Visible = false;
            itlistView.Visible = false;
            hklistView.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hklistView.Visible = true;
            balistView.Visible = false;
            tourismlistView.Visible = false;
            engineerlistView.Visible = false;
            crimlistView.Visible = false;
            educlistView.Visible = false;
            nursinglistView.Visible = false;
            itlistView.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form1 lamionaq = new Form1();
            lamionaq.Show();
            this.Close();
        }

        private void itlistView_SelectedIndexChanged(object sender, EventArgs e)// WLAY LABOT
        {

        }

        private void label3_Click(object sender, EventArgs e)// WLAY LABOT
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            itlistView.View = View.Details;
            itlistView.GridLines = true;
            itlistView.FullRowSelect = false;
            itlistView.Columns.Add("FIRSTNAME", 150);
            itlistView.Columns.Add("MIDDLENAME", 150);
            itlistView.Columns.Add("LASTNAME", 150);
            itlistView.Columns.Add("AGE", 50);
            itlistView.Columns.Add("ID NUMBER", 100);
            itlistView.Columns.Add("GENDER", 80);

            crimlistView.View = View.Details;
            crimlistView.GridLines = true;
            crimlistView.FullRowSelect = false;
            crimlistView.Columns.Add("FIRSTNAME", 150);
            crimlistView.Columns.Add("MIDDLENAME", 150);
            crimlistView.Columns.Add("LASTNAME", 150);
            crimlistView.Columns.Add("AGE", 50);
            crimlistView.Columns.Add("ID NUMBER", 100);
            crimlistView.Columns.Add("GENDER", 80);

            educlistView.View = View.Details;
            educlistView.GridLines = true;
            educlistView.FullRowSelect = false;
            educlistView.Columns.Add("FIRSTNAME", 150);
            educlistView.Columns.Add("MIDDLENAME", 150);
            educlistView.Columns.Add("LASTNAME", 150);
            educlistView.Columns.Add("AGE", 50);
            educlistView.Columns.Add("ID NUMBER", 100);
            educlistView.Columns.Add("GENDER", 80);

            nursinglistView.View = View.Details;
            nursinglistView.GridLines = true;
            nursinglistView.FullRowSelect = false;
            nursinglistView.Columns.Add("FIRSTNAME", 150);
            nursinglistView.Columns.Add("MIDDLENAME", 150);
            nursinglistView.Columns.Add("LASTNAME", 150);
            nursinglistView.Columns.Add("AGE", 50);
            nursinglistView.Columns.Add("ID NUMBER", 100);
            nursinglistView.Columns.Add("GENDER", 80);

            engineerlistView.View = View.Details;
            engineerlistView.GridLines = true;
            engineerlistView.FullRowSelect = false;
            engineerlistView.Columns.Add("FIRSTNAME", 150);
            engineerlistView.Columns.Add("MIDDLENAME", 150);
            engineerlistView.Columns.Add("LASTNAME", 150);
            engineerlistView.Columns.Add("AGE", 50);
            engineerlistView.Columns.Add("ID NUMBER", 100);
            engineerlistView.Columns.Add("GENDER", 80);

            tourismlistView.View = View.Details;
            tourismlistView.GridLines = true;
            tourismlistView.FullRowSelect = false;
            tourismlistView.Columns.Add("FIRSTNAME", 150);
            tourismlistView.Columns.Add("MIDDLENAME", 150);
            tourismlistView.Columns.Add("LASTNAME", 150);
            tourismlistView.Columns.Add("AGE", 50);
            tourismlistView.Columns.Add("ID NUMBER", 100);
            tourismlistView.Columns.Add("GENDER", 80);

            balistView.View = View.Details;
            balistView.GridLines = true;
            balistView.FullRowSelect = false;
            balistView.Columns.Add("FIRSTNAME", 150);
            balistView.Columns.Add("MIDDLENAME", 150);
            balistView.Columns.Add("LASTNAME", 150);
            balistView.Columns.Add("AGE", 50);
            balistView.Columns.Add("ID NUMBER", 100);
            balistView.Columns.Add("GENDER", 80);

            hklistView.View = View.Details;
            hklistView.GridLines = true;
            hklistView.FullRowSelect = false;
            hklistView.Columns.Add("FIRSTNAME", 150);
            hklistView.Columns.Add("MIDDLENAME", 150);
            hklistView.Columns.Add("LASTNAME", 150);
            hklistView.Columns.Add("AGE", 50);
            hklistView.Columns.Add("ID NUMBER", 100);
            hklistView.Columns.Add("GENDER", 80);

            ListViewItem item1 = new ListViewItem("John");
            item1.SubItems.Add("Santos");
            item1.SubItems.Add("Cruz");
            item1.SubItems.Add("19");
            item1.SubItems.Add("2025-001");
            item1.SubItems.Add("Male");

            itlistView.Items.Add(item1);

            ListViewItem item2 = new ListViewItem("Maria");

            item2.SubItems.Add("Lopez");
            item2.SubItems.Add("Reyes");
            item2.SubItems.Add("20");
            item2.SubItems.Add("2025-002");
            item2.SubItems.Add("Female");

            crimlistView.Items.Add(item2);

            ListViewItem item3 = new ListViewItem("Kevin");
            item3.SubItems.Add("Garcia");
            item3.SubItems.Add("Flores");
            item3.SubItems.Add("18");
            item3.SubItems.Add("2025-003");
            item3.SubItems.Add("Male");

            educlistView.Items.Add(item3);

            ListViewItem item4 = new ListViewItem("Angela");
            item4.SubItems.Add("Morales");
            item4.SubItems.Add("Diaz");
            item4.SubItems.Add("20");
            item4.SubItems.Add("2025-004");
            item4.SubItems.Add("Female");
            nursinglistView.Items.Add(item4);

            ListViewItem item5 = new ListViewItem("Joshua");
            item5.SubItems.Add("Ramos");
            item5.SubItems.Add("Torres");
            item5.SubItems.Add("19");
            item5.SubItems.Add("2025-005");
            item5.SubItems.Add("Male");
            engineerlistView.Items.Add(item5);

            ListViewItem item6 = new ListViewItem("Nicole");
            item6.SubItems.Add("Fernandez");
            item6.SubItems.Add("Castro");
            item6.SubItems.Add("21");
            item6.SubItems.Add("2025-006");
            item6.SubItems.Add("Female");
            tourismlistView.Items.Add(item6);

            ListViewItem item7 = new ListViewItem("Daniel");
            item7.SubItems.Add("Aquino");
            item7.SubItems.Add("Mendoza");
            item7.SubItems.Add("18");
            item7.SubItems.Add("2025-007");
            item7.SubItems.Add("Male");
            balistView.Items.Add(item7);

            ListViewItem item8 = new ListViewItem("Sophia");
            item8.SubItems.Add("Navarro");
            item8.SubItems.Add("Villanueva");
            item8.SubItems.Add("20");
            item8.SubItems.Add("2025-008");
            item8.SubItems.Add("Female");
            hklistView.Items.Add(item8);
        }

        private void hklistView_SelectedIndexChanged(object sender, EventArgs e)// WLAY LABOT
        {

        }

        private void engineerlistView_SelectedIndexChanged(object sender, EventArgs e)// WLAY LABOT
        {

        }

        private void nursinglistView_SelectedIndexChanged(object sender, EventArgs e)// WLAY LABOT
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            itlistView.Visible = true;
            crimlistView.Visible = false;
            educlistView.Visible = false;
            nursinglistView.Visible = false;
            engineerlistView.Visible = false;
            tourismlistView.Visible = false;
            balistView.Visible = false;
            hklistView.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            crimlistView.Visible = true;
            educlistView.Visible = false;
            itlistView.Visible = false;
            nursinglistView.Visible = false;
            engineerlistView.Visible = false;
            tourismlistView.Visible = false;
            balistView.Visible = false;
            hklistView.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            educlistView.Visible = true;
            crimlistView.Visible = false;
            itlistView.Visible = false;
            nursinglistView.Visible = false;
            engineerlistView.Visible = false;
            tourismlistView.Visible = false;
            balistView.Visible = false;
            hklistView.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            nursinglistView.Visible = true;
            itlistView.Visible = false;
            crimlistView.Visible = false;
            educlistView.Visible = false;
            engineerlistView.Visible = false;
            tourismlistView.Visible = false;
            balistView.Visible = false;
            hklistView.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            engineerlistView.Visible = true;
            crimlistView.Visible = false;
            educlistView.Visible = false;
            nursinglistView.Visible = false;
            itlistView.Visible = false;
            tourismlistView.Visible = false;
            balistView.Visible = false;
            hklistView.Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            tourismlistView.Visible = true;
            engineerlistView.Visible = false;
            crimlistView.Visible = false;
            educlistView.Visible = false;
            nursinglistView.Visible = false;
            itlistView.Visible = false;
            balistView.Visible = false;
            hklistView.Visible = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            balistView.Visible = true;
            tourismlistView.Visible = false;
            engineerlistView.Visible = false;
            crimlistView.Visible = false;
            educlistView.Visible = false;
            nursinglistView.Visible = false;
            itlistView.Visible = false;
            hklistView.Visible = false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            hklistView.Visible = true;
            balistView.Visible = false;
            tourismlistView.Visible = false;
            engineerlistView.Visible = false;
            crimlistView.Visible = false;
            educlistView.Visible = false;
            nursinglistView.Visible = false;
            itlistView.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)// WLAY LABOT
        {

        }

    }

}
