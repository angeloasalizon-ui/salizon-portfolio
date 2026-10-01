using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SALIZONPOGI
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            itlistView.View = View.Details;
            itlistView.GridLines = true;
            itlistView.FullRowSelect = false;
            itlistView.Columns.Add("FIRSTNAME", 120);
            itlistView.Columns.Add("MIDDLENAME", 100);
            itlistView.Columns.Add("LASTNAME", 120);
            itlistView.Columns.Add("AGE", 50);
            itlistView.Columns.Add("ID NUMBER", 100);
            itlistView.Columns.Add("GENDER", 80);

            crimlistView7.View = View.Details;
            crimlistView7.GridLines = true;
            crimlistView7.FullRowSelect = false;
            crimlistView7.Columns.Add("FIRSTNAME", 120);
            crimlistView7.Columns.Add("MIDDLENAME", 100);
            crimlistView7.Columns.Add("LASTNAME", 120);
            crimlistView7.Columns.Add("AGE", 50);
            crimlistView7.Columns.Add("ID NUMBER", 100);
            crimlistView7.Columns.Add("GENDER", 80);

            edlistView3.View = View.Details;
            edlistView3.GridLines = true;
            edlistView3.FullRowSelect = false;
            edlistView3.Columns.Add("FIRSTNAME", 120);
            edlistView3.Columns.Add("MIDDLENAME", 100);
            edlistView3.Columns.Add("LASTNAME", 120);
            edlistView3.Columns.Add("AGE", 50);
            edlistView3.Columns.Add("ID NUMBER", 100);
            edlistView3.Columns.Add("GENDER", 80);

            nlistView4.View = View.Details;
            nlistView4.GridLines = true;
            nlistView4.FullRowSelect = false;
            nlistView4.Columns.Add("FIRSTNAME", 120);
            nlistView4.Columns.Add("MIDDLENAME", 100);
            nlistView4.Columns.Add("LASTNAME", 120);
            nlistView4.Columns.Add("AGE", 50);
            nlistView4.Columns.Add("ID NUMBER", 100);
            nlistView4.Columns.Add("GENDER", 80);

            hmlistView5.View = View.Details;
            hmlistView5.GridLines = true;
            hmlistView5.FullRowSelect = false;
            hmlistView5.Columns.Add("FIRSTNAME", 120);
            hmlistView5.Columns.Add("MIDDLENAME", 100);
            hmlistView5.Columns.Add("LASTNAME", 120);
            hmlistView5.Columns.Add("AGE", 50);
            hmlistView5.Columns.Add("ID NUMBER", 100);
            hmlistView5.Columns.Add("GENDER", 80);

            elistView6.View = View.Details;
            elistView6.GridLines = true;
            elistView6.FullRowSelect = false;
            elistView6.Columns.Add("FIRSTNAME", 120);
            elistView6.Columns.Add("MIDDLENAME", 100);
            elistView6.Columns.Add("LASTNAME", 120);
            elistView6.Columns.Add("AGE", 50);
            elistView6.Columns.Add("ID NUMBER", 100);
            elistView6.Columns.Add("GENDER", 80);

            hklistView2.View = View.Details;
            hklistView2.GridLines = true;
            hklistView2.FullRowSelect = false;
            hklistView2.Columns.Add("FIRSTNAME", 120);
            hklistView2.Columns.Add("MIDDLENAME", 100);
            hklistView2.Columns.Add("LASTNAME", 120);
            hklistView2.Columns.Add("AGE", 50);
            hklistView2.Columns.Add("ID NUMBER", 100);
            hklistView2.Columns.Add("GENDER", 80);

            balistView8.View = View.Details;
            balistView8.GridLines = true;
            balistView8.FullRowSelect = false;
            balistView8.Columns.Add("FIRSTNAME", 120);
            balistView8.Columns.Add("MIDDLENAME", 100);
            balistView8.Columns.Add("LASTNAME", 120);
            balistView8.Columns.Add("AGE", 50);
            balistView8.Columns.Add("ID NUMBER", 100);
            balistView8.Columns.Add("GENDER", 80);

            itpanel.Location = new System.Drawing.Point(283, 69);
            crimpanel.Location = new System.Drawing.Point(283, 69);
            educpanel.Location = new System.Drawing.Point(283, 69);
            nursingpanel.Location = new System.Drawing.Point(283, 69);
            engineerpanel.Location = new System.Drawing.Point(283, 69);
            hkpanel.Location = new System.Drawing.Point(283, 69);
            tourismpanel.Location = new System.Drawing.Point(283, 69);
            bapanel.Location = new System.Drawing.Point(283, 69);


        }

        private void itpanel_Paint(object sender, PaintEventArgs e) // WLAY LABOT
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)// WLAY LABOT
        {


        }

        private void label3_Click(object sender, EventArgs e)// WLAY LABOT
        {

        }

        private void label2_Click(object sender, EventArgs e)// WLAY LABOT
        {

        }

        private void BSIT_Click(object sender, EventArgs e)// WLAY LABOT
        {
            crimpanel.Visible = false;
            itpanel.Visible = true;
            educpanel.Visible = false;
            nursingpanel.Visible = false;
            tourismpanel.Visible = false;
            engineerpanel.Visible = false;
            hkpanel.Visible = false;
            bapanel.Visible = false;
        }

        private void BSCRIM_Click(object sender, EventArgs e)
        {
            crimpanel.Visible = true;
            itpanel.Visible = false;
            educpanel.Visible = false;
            nursingpanel.Visible = false;
            tourismpanel.Visible = false;
            engineerpanel.Visible = false;
            hkpanel.Visible = false;
            bapanel.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            educpanel.Visible = true;
            itpanel.Visible = false;
            crimpanel.Visible = false;
            nursingpanel.Visible = false;
            tourismpanel.Visible = false;
            engineerpanel.Visible = false;
            hkpanel.Visible = false;
            bapanel.Visible = false;
        }

        private void educpanel_Paint(object sender, PaintEventArgs e)// WLAY LABOT
        {


        }

        private void label23_Click(object sender, EventArgs e)// WLAY LABOT
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            nursingpanel.Visible = true;
            educpanel.Visible = false;
            itpanel.Visible = false;
            crimpanel.Visible = false;
            tourismpanel.Visible = false;
            engineerpanel.Visible = false;
            hkpanel.Visible = false;
            bapanel.Visible = false;
        }

        private void label30_Click(object sender, EventArgs e)// WLAY LABOT
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            tourismpanel.Visible = true;
            nursingpanel.Visible = false;
            educpanel.Visible = false;
            itpanel.Visible = false;
            crimpanel.Visible = false;
            engineerpanel.Visible = false;
            hkpanel.Visible = false;
            bapanel.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            engineerpanel.Visible = true;
            tourismpanel.Visible = false;
            nursingpanel.Visible = false;
            educpanel.Visible = false;
            itpanel.Visible = false;
            crimpanel.Visible = false;
            hkpanel.Visible = false;
            bapanel.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hkpanel.Visible = true;
            engineerpanel.Visible = false;
            tourismpanel.Visible = false;
            nursingpanel.Visible = false;
            educpanel.Visible = false;
            itpanel.Visible = false;
            crimpanel.Visible = false;
            bapanel.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bapanel.Visible = true;
            hkpanel.Visible = false;
            engineerpanel.Visible = false;
            tourismpanel.Visible = false;
            nursingpanel.Visible = false;
            educpanel.Visible = false;
            itpanel.Visible = false;
            crimpanel.Visible = false;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            Form1 lamionaq = new Form1();
            lamionaq.Show();
            this.Close();
        }

        private void listView7_SelectedIndexChanged(object sender, EventArgs e)// WLAY LABOT
        {

        }

        private void label49_Click(object sender, EventArgs e)// WLAY LABOT
        {

        }

        private void engineerpanel_Paint(object sender, PaintEventArgs e)// WLAY LABOT
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)// WLAY LABOT
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            itadd.Enabled = true;
            ittextBox1.Enabled = true;
            ittextBox2.Enabled = true;
            ittextBox3.Enabled = true;
            ittextBox4.Enabled = true;
            ittextBox5.Enabled = true;
            itcomboBox1.Enabled = true;
            itlistView.Enabled = true;
            button9.Enabled = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            crimbutton13.Enabled = false;
            crimbutton15.Enabled = true;
            button16.Enabled = false;
            crimbutton14.Enabled = false;
            crimtextBox10.Enabled = true;
            crimtextBox6.Enabled = true;
            crimtextBox7.Enabled = true;
            crimtextBox8.Enabled = true;
            crimtextBox9.Enabled = true;
            crimcomboBox2.Enabled = true;
            crimlistView7.Enabled = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button18.Enabled = false;
            edbutton1.Enabled = true;
            edbutton2.Enabled = true;
            edbutton17.Enabled = true;
            edtextBox11.Enabled = true;
            edtextBox12.Enabled = true;
            edtextBox13.Enabled = true;
            edtextBox14.Enabled = true;
            edtextBox15.Enabled = true;
            edcomboBox3.Enabled = true;
            edlistView3.Enabled = true;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            nbutton19.Enabled = true;
            nbutton20.Enabled = true;
            nbutton21.Enabled = true;
            ntextBox16.Enabled = true;
            ntextBox17.Enabled = true;
            ntextBox18.Enabled = true;
            ntextBox19.Enabled = true;
            ntextBox20.Enabled = true;
            ncomboBox4.Enabled = true;
            nlistView4.Enabled = true;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            hmbutton23.Enabled = true;
            hmbutton24.Enabled = true;
            hmbutton25.Enabled = true;
            hmtextBox21.Enabled = true;
            hmtextBox22.Enabled = true;
            hmtextBox23.Enabled = true;
            hmtextBox24.Enabled = true;
            hmtextBox25.Enabled = true;
            hmcomboBox5.Enabled = true;
            hmlistView5.Enabled = true;
        }

        private void button30_Click(object sender, EventArgs e)// WLAY LABOT
        {

        }

        private void button30_Click_1(object sender, EventArgs e)
        {
            ebutton27.Enabled = true;
            ebutton28.Enabled = true;
            ebutton29.Enabled = true;
            etextBox26.Enabled = true;
            etextBox27.Enabled = true;
            etextBox28.Enabled = true;
            etextBox29.Enabled = true;
            etextBox30.Enabled = true;
            ecomboBox6.Enabled = true;
            elistView6.Enabled = true;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            hkbutton31.Enabled = true;
            hkbutton32.Enabled = true;
            hkbutton33.Enabled = true;
            hktextBox31.Enabled = true;
            hktextBox32.Enabled = true;
            hktextBox33.Enabled = true;
            hktextBox34.Enabled = true;
            hktextBox35.Enabled = true;
            hkcomboBox7.Enabled = true;
            hklistView2.Enabled = true;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            babutton35.Enabled = true;
            babutton36.Enabled = true;
            babutton37.Enabled = true;
            batextBox36.Enabled = true;
            batextBox37.Enabled = true;
            batextBox38.Enabled = true;
            batextBox39.Enabled = true;
            batextBox40.Enabled = true;
            bacomboBox8.Enabled = true;
            balistView8.Enabled = true;
        }

        private void ItlistView_SelectedIndexChanged(object sender, EventArgs e)// WLAY LABOT
        {

        }

        private void itadd_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(ittextBox1.Text);
            item.SubItems.Add(ittextBox2.Text);
            item.SubItems.Add(ittextBox3.Text);
            item.SubItems.Add(ittextBox4.Text);
            item.SubItems.Add(ittextBox5.Text);
            item.SubItems.Add(itcomboBox1.Text);
            itlistView.Items.Add(item);
            ittextBox1.Enabled = false;
            ittextBox2.Enabled = false;
            ittextBox3.Enabled = false;
            ittextBox4.Enabled = false;
            ittextBox5.Enabled = false;
            itcomboBox1.Enabled = false;
            itadd.Enabled = false;
            button9.Enabled = true;
            itupd.Enabled = true;
            ittextBox1.Clear();
            ittextBox2.Clear();
            ittextBox3.Clear();
            ittextBox4.Clear();
            ittextBox5.Clear();
            itcomboBox1.ResetText();
        }
        private void itlistView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itlistView.SelectedItems.Count > 0)
            {
                ListViewItem item = itlistView.SelectedItems[0];

                ittextBox1.Text = item.SubItems[0].Text;
                ittextBox2.Text = item.SubItems[1].Text;
                ittextBox3.Text = item.SubItems[2].Text;
                ittextBox4.Text = item.SubItems[3].Text;
                ittextBox5.Text = item.SubItems[4].Text;
                itcomboBox1.Text = item.SubItems[5].Text;

                ittextBox1.Enabled = true;
                ittextBox2.Enabled = true;
                ittextBox3.Enabled = true;
                ittextBox4.Enabled = true;
                ittextBox5.Enabled = true;
                itcomboBox1.Enabled = true;

                itupd.Enabled = true;
                itdel.Enabled = true;
            }
        }

        private void itupd_Click(object sender, EventArgs e)
        {


            if (itlistView.SelectedItems.Count > 0)
            {
                ListViewItem item = itlistView.SelectedItems[0];

                item.SubItems[0].Text = ittextBox1.Text;
                item.SubItems[1].Text = ittextBox2.Text;
                item.SubItems[2].Text = ittextBox3.Text;
                item.SubItems[3].Text = ittextBox4.Text;
                item.SubItems[4].Text = ittextBox5.Text;
                item.SubItems[5].Text = itcomboBox1.Text;

                MessageBox.Show("Updated successfully.");

                ittextBox1.Text = "";
                ittextBox2.Text = "";
                ittextBox3.Text = "";
                ittextBox4.Text = "";
                ittextBox5.Text = "";
                itcomboBox1.SelectedIndex = -1;
            }
        }

        private void itdel_Click(object sender, EventArgs e)
        {
            ittextBox1.Clear();
            ittextBox2.Clear();
            ittextBox3.Clear();
            ittextBox4.Clear();
            ittextBox5.Clear();
            itcomboBox1.Text = "";
            itdel.Enabled = false;
            button9.Enabled = true;

            if (itlistView.SelectedItems.Count > 0)
            {
                itlistView.Items.Remove(itlistView.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Please select an item to delete.");
            }
        }

        private void crimbutton15_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(crimtextBox10.Text);
            item.SubItems.Add(crimtextBox9.Text);
            item.SubItems.Add(crimtextBox8.Text);
            item.SubItems.Add(crimtextBox7.Text);
            item.SubItems.Add(crimtextBox6.Text);
            item.SubItems.Add(crimcomboBox2.Text);
            crimlistView7.Items.Add(item);
            crimtextBox10.Enabled = false;
            crimtextBox9.Enabled = false;
            crimtextBox8.Enabled = false;
            crimtextBox7.Enabled = false;
            crimtextBox6.Enabled = false;
            crimcomboBox2.Enabled = false;
            crimbutton15.Enabled = true;
            crimbutton13.Enabled = false;
            button16.Enabled = true;
            crimbutton14.Enabled = true;
            crimtextBox10.Clear();
            crimtextBox9.Clear();
            crimtextBox8.Clear();
            crimtextBox7.Clear();
            crimtextBox6.Clear();
            crimcomboBox2.ResetText();
        }

        private void crimbutton14_Click(object sender, EventArgs e)
        {
            if (crimlistView7.SelectedItems.Count > 0)
            {
                ListViewItem item = crimlistView7.SelectedItems[0];

                item.SubItems[0].Text = crimtextBox10.Text;
                item.SubItems[1].Text = crimtextBox9.Text;
                item.SubItems[2].Text = crimtextBox8.Text;
                item.SubItems[3].Text = crimtextBox7.Text;
                item.SubItems[4].Text = crimtextBox6.Text;
                item.SubItems[5].Text = crimcomboBox2.Text;

                MessageBox.Show("Updated successfully.");

                crimtextBox10.Text = "";
                crimtextBox9.Text = "";
                crimtextBox8.Text = "";
                crimtextBox7.Text = "";
                crimtextBox6.Text = "";
                crimcomboBox2.SelectedIndex = -1;
            }
        }

        private void crimbutton13_Click(object sender, EventArgs e)
        {
            crimtextBox10.Clear();
            crimtextBox9.Clear();
            crimtextBox8.Clear();
            crimtextBox7.Clear();
            crimtextBox6.Clear();
            crimcomboBox2.Text = "";
            crimbutton13.Enabled = false;
            button16.Enabled = true;

            if (crimlistView7.SelectedItems.Count > 0)
            {
                crimlistView7.Items.Remove(crimlistView7.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Please select an item to delete.");
            }

        }

        private void crimlistView7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (crimlistView7.SelectedItems.Count > 0)
            {
                ListViewItem item = crimlistView7.SelectedItems[0];

                crimtextBox10.Text = item.SubItems[0].Text;
                crimtextBox9.Text = item.SubItems[1].Text;
                crimtextBox8.Text = item.SubItems[2].Text;
                crimtextBox7.Text = item.SubItems[3].Text;
                crimtextBox6.Text = item.SubItems[4].Text;
                crimcomboBox2.Text = item.SubItems[5].Text;

                crimtextBox10.Enabled = true;
                crimtextBox9.Enabled = true;
                crimtextBox8.Enabled = true;
                crimtextBox7.Enabled = true;
                crimtextBox6.Enabled = true;
                crimcomboBox2.Enabled = true;

                crimbutton14.Enabled = true;
                crimbutton13.Enabled = true;
            }

        }

        private void edbutton17_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(edtextBox15.Text);
            item.SubItems.Add(edtextBox14.Text);
            item.SubItems.Add(edtextBox13.Text);
            item.SubItems.Add(edtextBox12.Text);
            item.SubItems.Add(edtextBox11.Text);
            item.SubItems.Add(edcomboBox3.Text);
            edlistView3.Items.Add(item);
            edtextBox15.Enabled = false;
            edtextBox14.Enabled = false;
            edtextBox13.Enabled = false;
            edtextBox12.Enabled = false;
            edtextBox11.Enabled = false;
            edcomboBox3.Enabled = false;
            edbutton17.Enabled = false;
            button18.Enabled = true;
            edbutton2.Enabled = true;
            edtextBox15.Clear();
            edtextBox14.Clear();
            edtextBox13.Clear();
            edtextBox12.Clear();
            edtextBox11.Clear();
            edcomboBox3.ResetText();

        }

        private void edbutton1_Click(object sender, EventArgs e)
        {
            edtextBox15.Clear();
            edtextBox14.Clear();
            edtextBox13.Clear();
            edtextBox12.Clear();
            edtextBox11.Clear();
            edcomboBox3.Text = "";
            edbutton1.Enabled = false;
            button18.Enabled = true;

            if (edlistView3.SelectedItems.Count > 0)
            {
                edlistView3.Items.Remove(edlistView3.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Please select an item to delete.");
            }

        }

        private void edbutton2_Click(object sender, EventArgs e)
        {
            if (edlistView3.SelectedItems.Count > 0)
            {
                ListViewItem item = edlistView3.SelectedItems[0];

                item.SubItems[0].Text = edtextBox15.Text;
                item.SubItems[1].Text = edtextBox14.Text;
                item.SubItems[2].Text = edtextBox13.Text;
                item.SubItems[3].Text = edtextBox12.Text;
                item.SubItems[4].Text = edtextBox11.Text;
                item.SubItems[5].Text = edcomboBox3.Text;

                MessageBox.Show("Updated successfully.");
                edtextBox15.Text = "";
                edtextBox14.Text = "";
                edtextBox13.Text = "";
                edtextBox12.Text = "";
                edtextBox11.Text = "";
                edcomboBox3.SelectedIndex = -1;

            }

        }

        private void edlistView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (edlistView3.SelectedItems.Count > 0)
            {
                ListViewItem item = edlistView3.SelectedItems[0];

                edtextBox15.Text = item.SubItems[0].Text;
                edtextBox14.Text = item.SubItems[1].Text;
                edtextBox13.Text = item.SubItems[2].Text;
                edtextBox12.Text = item.SubItems[3].Text;
                edtextBox11.Text = item.SubItems[4].Text;
                edcomboBox3.Text = item.SubItems[5].Text;

                edtextBox15.Enabled = true;
                edtextBox14.Enabled = true;
                edtextBox13.Enabled = true;
                edtextBox12.Enabled = true;
                edtextBox11.Enabled = true;
                edcomboBox3.Enabled = true;

                edbutton2.Enabled = true;
                edbutton1.Enabled = true;
            }

        }

        private void nbutton21_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(ntextBox20.Text);
            item.SubItems.Add(ntextBox19.Text);
            item.SubItems.Add(ntextBox18.Text);
            item.SubItems.Add(ntextBox17.Text);
            item.SubItems.Add(ntextBox16.Text);
            item.SubItems.Add(ncomboBox4.Text);
            nlistView4.Items.Add(item);
            ntextBox20.Enabled = false;
            ntextBox19.Enabled = false;
            ntextBox18.Enabled = false;
            ntextBox17.Enabled = false;
            ntextBox16.Enabled = false;
            nlistView4.Enabled = false;
            nbutton21.Enabled = false;
            button22.Enabled = true;
            nbutton20.Enabled = true;
            ntextBox20.Clear();
            ntextBox19.Clear();
            ntextBox18.Clear();
            ntextBox17.Clear();
            ntextBox16.Clear();
            ncomboBox4.ResetText();

        }

        private void nbutton20_Click(object sender, EventArgs e)
        {
            if (nlistView4.SelectedItems.Count > 0)
            {
                ListViewItem item = nlistView4.SelectedItems[0];

                item.SubItems[0].Text = ntextBox20.Text;
                item.SubItems[1].Text = ntextBox19.Text;
                item.SubItems[2].Text = ntextBox18.Text;
                item.SubItems[3].Text = ntextBox17.Text;
                item.SubItems[4].Text = ntextBox16.Text;
                item.SubItems[5].Text = ncomboBox4.Text;

                MessageBox.Show("Updated successfully.");
                ntextBox20.Text = "";
                ntextBox19.Text = "";
                ntextBox18.Text = "";
                ntextBox17.Text = "";
                ntextBox16.Text = "";
                ncomboBox4.SelectedIndex = -1;

            }

        }

        private void nbutton19_Click(object sender, EventArgs e)// WLAY LABOT
        {


        }

        private void nbutton19_Click_1(object sender, EventArgs e)
        {
            ntextBox20.Clear();
            ntextBox19.Clear();
            ntextBox18.Clear();
            ntextBox17.Clear();
            ntextBox16.Clear();
            ncomboBox4.Text = "";
            nbutton19.Enabled = false;
            button22.Enabled = true;

            if (nlistView4.SelectedItems.Count > 0)
            {
                nlistView4.Items.Remove(nlistView4.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Please select an item to delete.");
            }
        }

        private void nlistView4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nlistView4.SelectedItems.Count > 0)
            {
                ListViewItem item = nlistView4.SelectedItems[0];

                ntextBox20.Text = item.SubItems[0].Text;
                ntextBox19.Text = item.SubItems[1].Text;
                ntextBox18.Text = item.SubItems[2].Text;
                ntextBox17.Text = item.SubItems[3].Text;
                ntextBox16.Text = item.SubItems[4].Text;
                ncomboBox4.Text = item.SubItems[5].Text;

                ntextBox20.Enabled = true;
                ntextBox19.Enabled = true;
                ntextBox18.Enabled = true;
                ntextBox17.Enabled = true;
                ntextBox16.Enabled = true;
                ncomboBox4.Enabled = true;

                nbutton19.Enabled = true;
                button22.Enabled = true;
            }

        }

        private void hmbutton25_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(hmtextBox25.Text);
            item.SubItems.Add(hmtextBox24.Text);
            item.SubItems.Add(hmtextBox23.Text);
            item.SubItems.Add(hmtextBox22.Text);
            item.SubItems.Add(hmtextBox21.Text);
            item.SubItems.Add(hmcomboBox5.Text);
            hmlistView5.Items.Add(item);
            hmtextBox25.Enabled = false;
            hmtextBox24.Enabled = false;
            hmtextBox23.Enabled = false;
            hmtextBox22.Enabled = false;
            hmtextBox21.Enabled = false;
            hmcomboBox5.Enabled = false;
            hmbutton25.Enabled = false;
            button26.Enabled = true;
            hmbutton24.Enabled = true;
            hmtextBox25.Clear();
            hmtextBox24.Clear();
            hmtextBox23.Clear();
            hmtextBox22.Clear();
            hmtextBox21.Clear();
            hmcomboBox5.ResetText();

        }

        private void hmbutton24_Click(object sender, EventArgs e)
        {
            if (hmlistView5.SelectedItems.Count > 0)
            {
                ListViewItem item = hmlistView5.SelectedItems[0];

                item.SubItems[0].Text = hmtextBox25.Text;
                item.SubItems[1].Text = hmtextBox24.Text;
                item.SubItems[2].Text = hmtextBox23.Text;
                item.SubItems[3].Text = hmtextBox22.Text;
                item.SubItems[4].Text = hmtextBox21.Text;
                item.SubItems[5].Text = hmcomboBox5.Text;

                MessageBox.Show("Updated successfully.");
                hmtextBox25.Text = "";
                hmtextBox24.Text = "";
                hmtextBox23.Text = "";
                hmtextBox22.Text = "";
                hmtextBox21.Text = "";
                hmcomboBox5.SelectedIndex = -1;

            }
        }

        private void hmbutton23_Click(object sender, EventArgs e)
        {
            hmtextBox25.Clear();
            hmtextBox24.Clear();
            hmtextBox23.Clear();
            hmtextBox22.Clear();
            hmtextBox21.Clear();
            hmcomboBox5.Text = "";
            hmbutton23.Enabled = false;
            button26.Enabled = true;

            if (hmlistView5.SelectedItems.Count > 0)
            {
                hmlistView5.Items.Remove(hmlistView5.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Please select an item to delete.");
            }

        }

        private void hmlistView5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hmlistView5.SelectedItems.Count > 0)
            {
                ListViewItem item = hmlistView5.SelectedItems[0];

                hmtextBox25.Text = item.SubItems[0].Text;
                hmtextBox24.Text = item.SubItems[1].Text;
                hmtextBox23.Text = item.SubItems[2].Text;
                hmtextBox22.Text = item.SubItems[3].Text;
                hmtextBox21.Text = item.SubItems[4].Text;
                hmcomboBox5.Text = item.SubItems[5].Text;

                hmtextBox25.Enabled = true;
                hmtextBox24.Enabled = true;
                hmtextBox23.Enabled = true;
                hmtextBox22.Enabled = true;
                hmtextBox21.Enabled = true;
                hmcomboBox5.Enabled = true;

                hmbutton23.Enabled = true;
                button26.Enabled = true;
            }

        }

        private void ebutton29_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(etextBox30.Text);
            item.SubItems.Add(etextBox29.Text);
            item.SubItems.Add(etextBox28.Text);
            item.SubItems.Add(etextBox27.Text);
            item.SubItems.Add(etextBox26.Text);
            item.SubItems.Add(ecomboBox6.Text);
            elistView6.Items.Add(item);
            etextBox30.Enabled = false;
            etextBox29.Enabled = false;
            etextBox28.Enabled = false;
            etextBox27.Enabled = false;
            etextBox26.Enabled = false;
            ecomboBox6.Enabled = false;
            button30.Enabled = false;
            ebutton29.Enabled = true;
            ebutton28.Enabled = true;
            etextBox30.Clear();
            etextBox29.Clear();
            etextBox28.Clear();
            etextBox27.Clear();
            etextBox26.Clear();
            ecomboBox6.ResetText();

        }

        private void ebutton28_Click(object sender, EventArgs e)
        {
            if (elistView6.SelectedItems.Count > 0)
            {
                ListViewItem item = elistView6.SelectedItems[0];

                item.SubItems[0].Text = etextBox30.Text;
                item.SubItems[1].Text = etextBox29.Text;
                item.SubItems[2].Text = etextBox28.Text;
                item.SubItems[3].Text = etextBox27.Text;
                item.SubItems[4].Text = etextBox26.Text;
                item.SubItems[5].Text = ecomboBox6.Text;

                MessageBox.Show("Updated successfully.");
                etextBox30.Text = "";
                etextBox29.Text = "";
                etextBox28.Text = "";
                etextBox27.Text = "";
                etextBox26.Text = "";
                ecomboBox6.SelectedIndex = -1;

            }
        }

        private void ebutton27_Click(object sender, EventArgs e)
        {
            etextBox30.Clear();
            etextBox29.Clear();
            etextBox28.Clear();
            etextBox27.Clear();
            etextBox26.Clear();
            ecomboBox6.Text = "";
            ebutton27.Enabled = false;
            button30.Enabled = true;

            if (elistView6.SelectedItems.Count > 0)
            {
                elistView6.Items.Remove(elistView6.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Please select an item to delete.");
            }

        }

        private void elistView6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (elistView6.SelectedItems.Count > 0)
            {
                ListViewItem item = elistView6.SelectedItems[0];

                etextBox30.Text = item.SubItems[0].Text;
                etextBox29.Text = item.SubItems[1].Text;
                etextBox28.Text = item.SubItems[2].Text;
                etextBox27.Text = item.SubItems[3].Text;
                etextBox26.Text = item.SubItems[4].Text;
                ecomboBox6.Text = item.SubItems[5].Text;

                etextBox30.Enabled = true;
                etextBox29.Enabled = true;
                etextBox28.Enabled = true;
                etextBox27.Enabled = true;
                etextBox26.Enabled = true;
                ecomboBox6.Enabled = true;

                ebutton28.Enabled = true;
                ebutton27.Enabled = true;
            }

        }

        private void hkbutton33_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(hktextBox35.Text);
            item.SubItems.Add(hktextBox34.Text);
            item.SubItems.Add(hktextBox33.Text);
            item.SubItems.Add(hktextBox32.Text);
            item.SubItems.Add(hktextBox31.Text);
            item.SubItems.Add(hkcomboBox7.Text);
            hklistView2.Items.Add(item);
            hktextBox35.Enabled = false;
            hktextBox34.Enabled = false;
            hktextBox33.Enabled = false;
            hktextBox32.Enabled = false;
            hktextBox31.Enabled = false;
            hkcomboBox7.Enabled = false;
            hkbutton33.Enabled = false;
            button34.Enabled = true;
            hkbutton32.Enabled = true;
            hktextBox35.Clear();
            hktextBox34.Clear();
            hktextBox33.Clear();
            hktextBox32.Clear();
            hktextBox31.Clear();
            hkcomboBox7.ResetText();

        }

        private void hkbutton32_Click(object sender, EventArgs e)
        {
            if (hklistView2.SelectedItems.Count > 0)
            {
                ListViewItem item = hklistView2.SelectedItems[0];

                item.SubItems[0].Text = hktextBox35.Text;
                item.SubItems[1].Text = hktextBox34.Text;
                item.SubItems[2].Text = hktextBox33.Text;
                item.SubItems[3].Text = hktextBox32.Text;
                item.SubItems[4].Text = hktextBox31.Text;
                item.SubItems[5].Text = hkcomboBox7.Text;

                MessageBox.Show("Updated successfully.");
                hktextBox35.Text = "";
                hktextBox34.Text = "";
                hktextBox33.Text = "";
                hktextBox32.Text = "";
                hktextBox31.Text = "";
                hkcomboBox7.SelectedIndex = -1;


            }
        }

        private void hkbutton31_Click(object sender, EventArgs e)
        {
            hktextBox35.Clear();
            hktextBox34.Clear();
            hktextBox33.Clear();
            hktextBox32.Clear();
            hktextBox31.Clear();
            hkcomboBox7.Text = "";
            hkbutton31.Enabled = false;
            button34.Enabled = true;

            if (hklistView2.SelectedItems.Count > 0)
            {
                hklistView2.Items.Remove(hklistView2.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Please select an item to delete.");
            }

        }

        private void hklistView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hklistView2.SelectedItems.Count > 0)
            {
                ListViewItem item = hklistView2.SelectedItems[0];

                hktextBox35.Text = item.SubItems[0].Text;
                hktextBox34.Text = item.SubItems[1].Text;
                hktextBox33.Text = item.SubItems[2].Text;
                hktextBox32.Text = item.SubItems[3].Text;
                hktextBox31.Text = item.SubItems[4].Text;
                hkcomboBox7.Text = item.SubItems[5].Text;

                hktextBox35.Enabled = true;
                hktextBox34.Enabled = true;
                hktextBox33.Enabled = true;
                hktextBox32.Enabled = true;
                hktextBox31.Enabled = true;
                hkcomboBox7.Enabled = true;

                hkbutton32.Enabled = true;
                hkbutton31.Enabled = true;
            }

        }

        private void babutton37_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(batextBox40.Text);
            item.SubItems.Add(batextBox39.Text);
            item.SubItems.Add(batextBox38.Text);
            item.SubItems.Add(batextBox37.Text);
            item.SubItems.Add(batextBox36.Text);
            item.SubItems.Add(bacomboBox8.Text);
            balistView8.Items.Add(item);
            batextBox40.Enabled = false;
            batextBox39.Enabled = false;
            batextBox38.Enabled = false;
            batextBox37.Enabled = false;
            batextBox36.Enabled = false;
            bacomboBox8.Enabled = false;
            babutton37.Enabled = false;
            button38.Enabled = true;
            babutton36.Enabled = true;
            batextBox40.Clear();
            batextBox39.Clear();
            batextBox38.Clear();
            batextBox37.Clear();
            batextBox36.Clear();
            bacomboBox8.ResetText();

        }

        private void babutton36_Click(object sender, EventArgs e)
        {
            if (balistView8.SelectedItems.Count > 0)
            {
                ListViewItem item = balistView8.SelectedItems[0];

                item.SubItems[0].Text = batextBox40.Text;
                item.SubItems[1].Text = batextBox39.Text;
                item.SubItems[2].Text = batextBox38.Text;
                item.SubItems[3].Text = batextBox37.Text;
                item.SubItems[4].Text = batextBox36.Text;
                item.SubItems[5].Text = bacomboBox8.Text;

                MessageBox.Show("Updated successfully.");
                batextBox40.Text = "";
                batextBox39.Text = "";
                batextBox38.Text = "";
                batextBox37.Text = "";
                batextBox36.Text = "";
                bacomboBox8.SelectedIndex = -1;

            }

        }

        private void babutton35_Click(object sender, EventArgs e)
        {
            batextBox40.Clear();
            batextBox39.Clear();
            batextBox38.Clear();
            batextBox37.Clear();
            batextBox36.Clear();
            bacomboBox8.Text = "";
            babutton35.Enabled = false;
            button38.Enabled = true;

            if (balistView8.SelectedItems.Count > 0)
            {
                balistView8.Items.Remove(balistView8.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Please select an item to delete.");
            }

        }

        private void balistView8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (balistView8.SelectedItems.Count > 0)
            {
                ListViewItem item = balistView8.SelectedItems[0];

                batextBox40.Text = item.SubItems[0].Text;
                batextBox39.Text = item.SubItems[1].Text;
                batextBox38.Text = item.SubItems[2].Text;
                batextBox37.Text = item.SubItems[3].Text;
                batextBox36.Text = item.SubItems[4].Text;
                bacomboBox8.Text = item.SubItems[5].Text;

                batextBox40.Enabled = true;
                batextBox39.Enabled = true;
                batextBox38.Enabled = true;
                batextBox37.Enabled = true;
                batextBox36.Enabled = true;
                bacomboBox8.Enabled = true;

                babutton36.Enabled = true;
                babutton35.Enabled = true;
            }

        }

        private void label57_Click(object sender, EventArgs e)//WLAY LABOT
        {

        }
    }
}