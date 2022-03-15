using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace Boarding_House_System
{
    public partial class Main : Form
    {


        string connection = (@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Sanz\Desktop\DAN2X SANZ\Boarding House System\Database1.mdf;Integrated Security=True");
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Sanz\Desktop\DAN2X SANZ\Boarding House System\Database1.mdf;Integrated Security=True");
        public Main()
        {
            InitializeComponent();
            Course();
            Major();
            Municipality();
            Province();
            Relation();
            Monthly();
            Rooms();
            RoomG();
            log();
            
            comboBOYS();
            comboGIRLS();
            //birth();


        }

        string picloc = "";

        //void birth()
        //{
        //    string query = "select * from Register;";
        //    SqlConnection sqlCon = new SqlConnection(connection);
        //    SqlCommand sqlCom = new SqlCommand(query, sqlCon);
        //    SqlDataReader myReader;

        //    sqlCon.Open();
        //    myReader = sqlCom.ExecuteReader();

        //    try
        //    {
        //        while (myReader.Read())
        //        {

        //            string birth = myReader.GetString(0);
        //            listBox3.Items.Add(birth);



        //        }


        //    }

        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        void comboBOYS()
        {
            string query = "select * from Rooms;";
            SqlConnection sqlCon = new SqlConnection(connection);
            SqlCommand sqlCom = new SqlCommand(query, sqlCon);
            SqlDataReader myReader;

            sqlCon.Open();
            myReader = sqlCom.ExecuteReader();

            try
            {
                while (myReader.Read())
                {

                    string rooms = myReader.GetString(0);
                    comboBox11.Items.Add(rooms);



                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void comboGIRLS()
        {
            string query = "select * from RoomG;";
            SqlConnection sqlCon = new SqlConnection(connection);
            SqlCommand sqlCom = new SqlCommand(query, sqlCon);
            SqlDataReader myReader;

            sqlCon.Open();
            myReader = sqlCom.ExecuteReader();

            try
            {
                while (myReader.Read())
                {

                    string rooms = myReader.GetString(0);
                    comboBox10.Items.Add(rooms);



                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        void log()
        {
            string query = "select * from logIn;";
            SqlConnection sqlCon = new SqlConnection(connection);
            SqlCommand sqlCom = new SqlCommand(query, sqlCon);
            SqlDataReader myReader;

            sqlCon.Open();
            myReader = sqlCom.ExecuteReader();

            try
            {
                while (myReader.Read())
                {

                    string log = myReader.GetString(0);
                    comboBox9.Items.Add(log);


                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        void RoomG()
        {
            string query = "select * from RoomG;";
            SqlConnection sqlCon = new SqlConnection(connection);
            SqlCommand sqlCom = new SqlCommand(query, sqlCon);
            SqlDataReader myReader;

            sqlCon.Open();
            myReader = sqlCom.ExecuteReader();

            try
            {
                while (myReader.Read())
                {

                    string rooms = myReader.GetString(0);
                    listBox2.Items.Add(rooms);



                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        void Rooms()
        {
            string query = "select * from Rooms;";
            SqlConnection sqlCon = new SqlConnection(connection);
            SqlCommand sqlCom = new SqlCommand(query, sqlCon);
            SqlDataReader myReader;

            sqlCon.Open();
            myReader = sqlCom.ExecuteReader();

            try
            {
                while (myReader.Read())
                {

                    string rooms = myReader.GetString(0);
                    listBox1.Items.Add(rooms);



                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        void Monthly()
        {
            string query = "select * from Monthly;";
            SqlConnection sqlCon = new SqlConnection(connection);
            SqlCommand sqlCom = new SqlCommand(query, sqlCon);
            SqlDataReader myReader;

            sqlCon.Open();
            myReader = sqlCom.ExecuteReader();

            try
            {
                while (myReader.Read())
                {

                    string month = myReader.GetString(0);
                    comboBox8.Items.Add(month);
                    comboBox3.Items.Add(month);



                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        void Relation()
        {
            string query = "select * from Relation;";
            SqlConnection sqlCon = new SqlConnection(connection);
            SqlCommand sqlCom = new SqlCommand(query, sqlCon);
            SqlDataReader myReader;

            sqlCon.Open();
            myReader = sqlCom.ExecuteReader();

            try
            {
                while (myReader.Read())
                {

                    string course = myReader.GetString(0);
                    comboBox4.Items.Add(course);


                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        void Province()
        {
            string query = "select * from Province;";
            SqlConnection sqlCon = new SqlConnection(connection);
            SqlCommand sqlCom = new SqlCommand(query, sqlCon);
            SqlDataReader myReader;

            sqlCon.Open();
            myReader = sqlCom.ExecuteReader();

            try
            {
                while (myReader.Read())
                {

                    string course = myReader.GetString(0);
                    comboBox2.Items.Add(course);


                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        void Municipality()
        {
            string query = "select * from Municipality;";
            SqlConnection sqlCon = new SqlConnection(connection);
            SqlCommand sqlCom = new SqlCommand(query, sqlCon);
            SqlDataReader myReader;

            sqlCon.Open();
            myReader = sqlCom.ExecuteReader();

            try
            {
                while (myReader.Read())
                {

                    string course = myReader.GetString(0);
                    comboBox1.Items.Add(course);


                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        void Major()
        {
            string query = "select * from Major;";
            SqlConnection sqlCon = new SqlConnection(connection);
            SqlCommand sqlCom = new SqlCommand(query, sqlCon);
            SqlDataReader myReader;

            sqlCon.Open();
            myReader = sqlCom.ExecuteReader();

            try
            {
                while (myReader.Read())
                {

                    string course = myReader.GetString(0);
                    comboBox6.Items.Add(course);


                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        void Course()
        {
            string query = "select * from Course;";
            SqlConnection sqlCon = new SqlConnection(connection);
            SqlCommand sqlCom = new SqlCommand(query, sqlCon);
            SqlDataReader myReader;

            sqlCon.Open();
            myReader = sqlCom.ExecuteReader();

            try
            {
                while (myReader.Read())
                {

                    string course = myReader.GetString(0);
                    comboBox5.Items.Add(course);


                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }











        private int imageNumber = 1;
        private void LoadImage()
        {




            if (imageNumber == 7)
            {
                imageNumber = 1;

            }
            slidePic.ImageLocation = string.Format(@"C:\Users\Sanz\Desktop\DAN2XSANZ\Boarding House System\Resources\ImagesImages\{0}.jpg", imageNumber);
            imageNumber++;
        }


        private void Main_Load(object sender, EventArgs e)
        {
            timer1.Start();

            label11.Text = DateTime.Now.ToLongTimeString();
            label12.Text = DateTime.Now.ToLongDateString();

            connect.Open();
            SqlCommand cmd = connect.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Register";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            foreach (DataRow sample in dt.Rows)
            {

                string name = sample["Surname"].ToString();
                int monthNow = DateTime.Now.Month;
                int dayNow = DateTime.Now.Day;
                string bDate = sample["Birthdate"].ToString();
                DateTime convertdate = DateTime.Parse(bDate);
                int birthMonth = convertdate.Month;
                int birtDate = convertdate.Day;

                if (monthNow == birthMonth && dayNow == birtDate)
                {
                  
                    button3.ForeColor = Color.Green;
                }



            }
            connect.Close();
           
   
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label11.Text = DateTime.Now.ToLongTimeString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = false;



            button8.Enabled = false;
            label71.Visible = false;
            label70.Visible = false;
            panel3.Visible = true;
            panel2.Visible = false;
            panel15.Visible = true;
        }

        private void rectangleShape2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Boarding_House_System.Properties.Resources._9a4d27a778c87a025fd800c4e6edd61f;
            pictureBox1.BackColor = Color.White;
            tabControl1.Visible = false;

            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            label119.Text = "000000";
            label123.Text = "000000";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            LoadImage();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //MENU
            panel15.Visible = true;
            button8.Enabled = false;
            //////////
            button4.Focus();
            button4.ForeColor = Color.Aquamarine;
            button4.BackColor = Color.DarkSlateGray;
            button5.BackColor = Color.Aquamarine;
            button5.ForeColor = Color.DarkSlateGray;
            button6.BackColor = Color.Aquamarine;
            button6.ForeColor = Color.DarkSlateGray;
            panel4.Visible = true;
            panel11.Visible = false;
            panel13.Visible = false;


        }

        private void button5_Click(object sender, EventArgs e)
        {
            //MENU
            panel15.Visible = true;
            button8.Enabled = false;
            //////////
            button5.BackColor = Color.DarkSlateGray;
            button5.ForeColor = Color.Aquamarine;
            button4.BackColor = Color.Aquamarine;
            button4.ForeColor = Color.DarkSlateGray;
            button6.BackColor = Color.Aquamarine;
            button6.ForeColor = Color.DarkSlateGray;
            panel4.Visible = false;
            panel11.Visible = true;
            panel13.Visible = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {   //MENU
            panel15.Visible = true;
            button8.Enabled = true;
            //////////
            button6.BackColor = Color.DarkSlateGray;
            button6.ForeColor = Color.Aquamarine;
            button4.BackColor = Color.Aquamarine;
            button4.ForeColor = Color.DarkSlateGray;
            button5.BackColor = Color.Aquamarine;
            button5.ForeColor = Color.DarkSlateGray;
            panel4.Visible = false;
            panel11.Visible = false;
            panel13.Visible = true;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png| All Files(*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = new Bitmap(dlg.FileName);

                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.BorderStyle = BorderStyle.FixedSingle;
                string location = dlg.FileName;
                textBox41.Text = location;
                //FileStream re = new FileStream(record, FileMode.Append, FileAccess.Write);


                //StreamWriter r = new StreamWriter(re);
                //r.WriteLine(pictureBox2.Image);
                //r.Close();
                //re.Close();
            }
            //picloc = pictureBox2.ImageLocation;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var exit = MessageBox.Show("Are you sure you want to exit ?", "Exit Program",
             MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (exit == DialogResult.Yes)
            {
                this.Close();
            }
            else if (exit == DialogResult.No)
            {

            }


        }

        private void button8_Click(object sender, EventArgs e)
        {
            Main main = new Main();


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime From = dateTimePicker1.Value;
            DateTime To = DateTime.Now;
            TimeSpan TSpan = To - From;
            Double Days = TSpan.TotalDays;
            textBox5.Text = (Days / 365).ToString("0");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.ToString() == "")
            {
                label33.Text = ("");

                dateTimePicker3.Value = DateTime.Now;

            }
            else if (double.Parse(textBox2.Text.ToString()) > 0)
            {
                double total = double.Parse(comboBox8.Text.ToString()) * double.Parse(textBox2.Text.ToString());
                label33.Text = total.ToString() + "";
                label36.Text = label33.Text.ToString();

            }
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

            groupBox4.Visible = false;
            groupBox5.Visible = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

            groupBox4.Visible = true;
            groupBox5.Visible = false;

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (textBox11.Text.ToString() == "")
                {
                    label46.Text = ("0000");

                    dateTimePicker2.Value = DateTime.Now;

                }
                else if (double.Parse(textBox11.Text.ToString()) > 0)
                {
                    double total = double.Parse(comboBox3.Text.ToString()) * double.Parse(textBox11.Text.ToString());
                    label46.Text = total.ToString() + "";
                    dateTimePicker2.Value = dateTimePicker2.Value.AddMonths(int.Parse(textBox11.Text));

                }

            }
            catch
            {

            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (textBox12.Text == "")
            {
            }
            else if (double.Parse(textBox12.Text) >= double.Parse(label46.Text))
            {
                label48.Text = double.Parse(textBox12.Text) - double.Parse(label46.Text) + "";
            }
            else
            {
                label48.Text = "0000";
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            panel14.Visible = true;
            string room;
            room = listBox1.SelectedItem.ToString();
            label56.Text = room;


            string query = "select * from Rooms where Room ='" + listBox1.SelectedItem + "' ; ";
            SqlConnection sqlCon = new SqlConnection(connection);
            SqlCommand sqlCom = new SqlCommand(query, sqlCon);
            SqlDataReader myReader;

            sqlCon.Open();
            myReader = sqlCom.ExecuteReader();

            try
            {
                while (myReader.Read())
                {  //deck1
                    string deck1 = myReader.GetString(1);
                    if (deck1 == "VACANT")
                    {
                        label57.ForeColor = Color.SkyBlue;
                        radioButton5.Enabled = true;
                        label57.Text = deck1;

                    }
                    else
                    {
                        radioButton5.Enabled = false;
                        label57.Text = deck1;
                    }
                    //deck2
                    string deck2 = myReader.GetString(2);
                    if (deck2 == "VACANT")
                    {
                        label58.ForeColor = Color.SkyBlue;
                        radioButton6.Enabled = true;
                        label58.Text = deck2;

                    }
                    else
                    {
                        radioButton6.Enabled = false;

                        label58.Text = deck2;
                    }
                    //deck3
                    string deck3 = myReader.GetString(3);
                    if (deck3 == "VACANT")
                    {
                        label59.ForeColor = Color.SkyBlue;
                        radioButton7.Enabled = true;
                        label59.Text = deck3;

                    }
                    else
                    {
                        radioButton7.Enabled = false;

                        label59.Text = deck3;
                    }
                    //deck4
                    string deck4 = myReader.GetString(4);
                    if (deck4 == "VACANT")
                    {
                        label60.ForeColor = Color.SkyBlue;
                        radioButton8.Enabled = true;
                        label60.Text = deck4;

                    }
                    else
                    {
                        radioButton8.Enabled = false;

                        label60.Text = deck4;
                    }
                    //deck5
                    string deck5 = myReader.GetString(5);
                    if (deck5 == "VACANT")
                    {
                        label61.ForeColor = Color.SkyBlue;
                        radioButton9.Enabled = true;
                        label61.Text = deck5;

                    }
                    else
                    {
                        radioButton9.Enabled = false;

                        label61.Text = deck5;
                    }
                    //deck6
                    string deck6 = myReader.GetString(6);
                    if (deck6 == "VACANT")
                    {
                        label62.ForeColor = Color.SkyBlue;
                        radioButton10.Enabled = true;
                        label62.Text = deck6;

                    }
                    else
                    {
                        radioButton10.Enabled = false;

                        label62.Text = deck6;
                    }

                    Refresh();
                }


            }
            catch
            {
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                label57.ForeColor = Color.PaleGreen;
                label57.Text = textBox10.Text.ToString();
            }
            else
            {
                label57.Text = "VACANT";
                label57.ForeColor = Color.SkyBlue;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                label58.ForeColor = Color.PaleGreen;
                label58.Text = textBox10.Text.ToString() + "";
            }
            else
            {
                label58.Text = "VACANT";
                label58.ForeColor = Color.SkyBlue;
            }

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                label59.ForeColor = Color.PaleGreen;
                label59.Text = textBox10.Text.ToString();
            }
            else
            {
                label59.Text = "VACANT";
                label59.ForeColor = Color.SkyBlue;
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked == true)
            {
                label60.ForeColor = Color.PaleGreen;
                label60.Text = textBox10.Text.ToString();
            }
            else
            {
                label60.Text = "VACANT";
                label60.ForeColor = Color.SkyBlue;
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {
                label61.ForeColor = Color.PaleGreen;
                label61.Text = textBox10.Text.ToString();
            }
            else
            {
                label61.Text = "VACANT";
                label61.ForeColor = Color.SkyBlue;
            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked == true)
            {
                label62.ForeColor = Color.PaleGreen;
                label62.Text = textBox10.Text.ToString();
            }
            else
            {
                label62.Text = "VACANT";
                label62.ForeColor = Color.SkyBlue;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel15.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            listBox2.Visible = false;
            groupBox7.Visible = false;
            listBox1.Visible = false;
            groupBox6.Visible = false;


            //////REFRESH
            textBox10.Text = "";
            textBox9.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            textBox5.Text = "";
            //GENDER
            listBox2.Visible = false;
            groupBox7.Visible = false;
            listBox1.Visible = false;
            groupBox6.Visible = false;

            radioButton1.Checked = false;

            radioButton2.Checked = false;

            textBox6.Text = "";
            //GUARDIAN
            textBox7.Text = "";
            comboBox4.Text = "";
            textBox1.Text = "";
            //EDUCATIONAL INFO
            textBox8.Text = "";
            comboBox5.Text = "";
            comboBox6.Text = "";
            //IMAGE
            pictureBox2.Image = null;
            //CASH
            comboBox3.Text = "";
            textBox11.Text = "";
            label46.Text = "0000";
            textBox12.Text = "";
            label48.Text = "0000";
            checkBox1.Checked = false;
            dateTimePicker2.Value = DateTime.Now;
            //CREDIT
            comboBox8.Text = "";
            textBox2.Text = "";
            label33.Text = "0000";
            label36.Text = "0000";
            dateTimePicker3.Value = DateTime.Now;
            //CASH||CREDIT 
            if (radioButton3.Checked)
            {
                radioButton3.Checked = false;
            }
            if (radioButton4.Checked)
            {
                radioButton4.Checked = false;
            }
            //GROUP
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            //BUTTON MEN||WOMEN
            if (radioButton11.Checked)
            {
                radioButton11.Checked = false;
            }
            if (radioButton12.Checked)
            {
                radioButton12.Checked = false;
            }



        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            var register = MessageBox.Show("Are you sure to Add a New Boarder ?", "Addd Boarder",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //try
            //{


            if (register == DialogResult.Yes)
            {
                //////////////////////////////////////////////////////////////
                if (radioButton4.Checked == true)
                {
                    panel18.Visible = true;
                    label94.Text = textBox10.Text + " " + textBox9.Text + " " + textBox3.Text;
                    label85.Text = comboBox8.Text;
                    label93.Text = textBox2.Text;
                    label87.Text = label33.Text;

                    button13.Visible = true;
                }
                else if (radioButton3.Checked == true)
                {
                    panel19.Visible = true;
                    label79.Text = textBox10.Text + " " + textBox9.Text + " " + textBox3.Text;
                    label83.Text = comboBox3.Text;
                    label78.Text = textBox11.Text;
                    label72.Text = label46.Text;
                    label77.Text = textBox12.Text;
                    if (checkBox1.Checked == true)
                    {
                        label76.Text = label48.Text;
                    }
                    else
                    {
                        label75.Text = label46.Text;
                    }
                    label74.Text = dateTimePicker2.Value.ToLongDateString();

                }
                button11.Visible = true;
                button13.Visible = true;
                button14.Visible = true;
                ////////////////////////////////////////////////////////////
                connect.Open();
                string surname = textBox10.Text.ToString();
                string fn = textBox9.Text.ToString();
                string mn = textBox3.Text.ToString();
                string brgy = textBox4.Text.ToString();
                string mu = comboBox1.Text.ToString();
                string pro = comboBox2.Text.ToString();
                string birthdate = dateTimePicker1.Value.ToString();
                string age = textBox5.Text.ToString();
                //GENDER
                string gender = "";
                if (radioButton1.Checked = true)
                {
                    gender = "MALE";
                }
                else if (radioButton2.Checked = true)
                {
                    gender = "FEMALE";
                }

                string contactNo = textBox6.Text.ToString();
                //GUARDIAN
                string contactPerson = textBox7.Text.ToString();
                string relation = comboBox4.Text.ToString();
                string contactPer_No = textBox1.Text.ToString();
                //EDUCATIONAL INFO
                string id_No = textBox8.Text.ToString();
                string course = comboBox5.Text.ToString();
                string major = comboBox6.Text.ToString();
                //IMAGE


                string path = "";
                path = textBox41.Text.ToString();

                //CASH 
                string monthlybill = comboBox3.Text.ToString();
                string no_MOnth = textBox11.Text.ToString();
                string total_Payment = label46.Text.ToString();
                string deposit = "";
                if (checkBox1.Checked)
                {
                    deposit = label48.Text.ToString();
                }
                else
                {
                    deposit = "0000";
                }
                string duedate = dateTimePicker2.Value.ToString();
                //CREDIT
                string credit_Monthlybill = comboBox8.Text.ToString();
                string creditNo_Months = textBox2.Text.ToString();
                string credit_Total = label36.Text.ToString();
                string credit_charge = "0000";
                string charge = "0000";


                string sql = "Insert into Register values ('" + surname + "','" + fn + "','" + mn + "','" + brgy + "','" + mu + "','" + pro + "','" + birthdate + "','" + age + "','" + gender + "','" + contactNo + "','" + contactPerson + "','" + relation + "','" + contactPer_No + "','" + path.ToString() + "','" + id_No + "','" + course + "','" + major + "','" + monthlybill + "','" + no_MOnth + "','" + total_Payment + "','" + deposit + "','" + credit_Monthlybill + "','" + creditNo_Months + "','" + credit_Total + "','" + duedate + "','" + credit_charge + "','" + charge + "')";
                SqlCommand command = new SqlCommand(sql, connect);
                command.ExecuteNonQuery();

                //GIRLS ROOM
                if (radioButton12.Checked == true)
                {

                    SqlConnection con = new SqlConnection(connection);

                    string sqlCon = " update RoomG set Room ='" + listBox2.SelectedItem.ToString() + "',Deck1 ='" + label64.Text + "',Deck2 ='" + label66.Text + "',Deck3 ='" + label68.Text + "',Deck4 ='" + label67.Text + "',Deck5 ='" + label65.Text + "',Deck6 ='" + label63.Text + "'  where Room = '" + listBox2.SelectedItem.ToString() + "' ;";
                    SqlCommand com = new SqlCommand(sqlCon, con);
                    SqlDataReader myReader;

                    con.Open();
                    myReader = com.ExecuteReader();


                    while (myReader.Read())
                    {

                    }
                    con.Close();
                    Refresh();
                }
                //BOYS ROOM
                if (radioButton11.Checked == true)
                {
                    SqlConnection con = new SqlConnection(connection);

                    string sqlCon = " update Rooms set Room ='" + listBox1.SelectedItem.ToString() + "',Deck1 = '" + label57.Text + "',Deck2 ='" + label58.Text + "',Deck3 ='" + label59.Text + "',Deck4 ='" + label60.Text + "',Deck5 ='" + label61.Text + "',Deck6 ='" + label62.Text + "'  where Room = '" + listBox1.SelectedItem.ToString() + "' ;";
                    SqlCommand com = new SqlCommand(sqlCon, con);
                    SqlDataReader myReader;

                    con.Open();
                    myReader = com.ExecuteReader();


                    while (myReader.Read())
                    {

                    }
                    con.Close();
                    Refresh();
                }


                Refresh();
                //////REFRESH
                textBox10.Text = "";
                textBox9.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                label71.Visible = false;
                label70.Visible = false;
                dateTimePicker1.Value = DateTime.Now;
                textBox5.Text = "";
                //GENDER
                listBox2.Visible = false;
                groupBox7.Visible = false;
                listBox1.Visible = false;
                groupBox6.Visible = false;

                radioButton1.Checked = false;

                radioButton2.Checked = false;

                textBox6.Text = "";
                //GUARDIAN
                textBox7.Text = "";
                comboBox4.Text = "";
                textBox1.Text = "";
                //EDUCATIONAL INFO
                textBox8.Text = "";
                comboBox5.Text = "";
                comboBox6.Text = "";
                //IMAGE
                pictureBox2.Image = null;
                //CASH
                comboBox3.Text = "";
                textBox11.Text = "";
                label46.Text = "0000";
                textBox12.Text = "";
                label48.Text = "0000";
                checkBox1.Checked = false;
                dateTimePicker2.Value = DateTime.Now;
                //CREDIT
                comboBox8.Text = "";
                textBox2.Text = "";
                label33.Text = "0000";
                label36.Text = "0000";
                dateTimePicker3.Value = DateTime.Now;
                //CASH||CREDIT 
                if (radioButton3.Checked)
                {
                    radioButton3.Checked = false;
                }
                if (radioButton4.Checked)
                {
                    radioButton4.Checked = false;
                }
                //GROUP
                groupBox4.Visible = false;
                groupBox5.Visible = false;
                //BUTTON MEN||WOMEN
                if (radioButton11.Checked)
                {
                    radioButton11.Checked = false;
                }
                if (radioButton12.Checked)
                {
                    radioButton12.Checked = false;
                }

                connect.Close();
                Refresh();
                //    }
                //}
                //catch
                //{
                //    MessageBox.Show(" Please fill Up the form properly ", "Fill Form",
                //    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Checked == true)
            {
                listBox2.Visible = false;
                groupBox7.Visible = false;
                listBox1.Visible = true;
                groupBox6.Visible = true;
                label70.Visible = true;
                label71.Visible = false;


            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            panel17.Visible = true;
            string room;
            room = listBox2.SelectedItem.ToString();
            label69.Text = room;


            string query = "select * from RoomG where Room ='" + listBox2.SelectedItem + "' ; ";
            SqlConnection sqlCon = new SqlConnection(connection);
            SqlCommand sqlCom = new SqlCommand(query, sqlCon);
            SqlDataReader myReader;

            sqlCon.Open();
            myReader = sqlCom.ExecuteReader();

            try
            {
                while (myReader.Read())
                {  //deck1
                    string deck1 = myReader.GetString(1);
                    if (deck1 == "VACANT")
                    {
                        label64.ForeColor = Color.SkyBlue;
                        radioButton14.Enabled = true;
                        label64.Text = deck1;

                    }
                    else
                    {
                        radioButton14.Enabled = false;
                        label64.Text = deck1;
                    }
                    //deck2
                    string deck2 = myReader.GetString(2);
                    if (deck2 == "VACANT")
                    {
                        label66.ForeColor = Color.SkyBlue;
                        radioButton13.Enabled = true;
                        label66.Text = deck2;

                    }
                    else
                    {
                        radioButton13.Enabled = false;

                        label66.Text = deck2;
                    }
                    //deck3
                    string deck3 = myReader.GetString(3);
                    if (deck3 == "VACANT")
                    {
                        label68.ForeColor = Color.SkyBlue;
                        radioButton17.Enabled = true;
                        label68.Text = deck3;

                    }
                    else
                    {
                        radioButton17.Enabled = false;

                        label68.Text = deck3;
                    }
                    //deck4
                    string deck4 = myReader.GetString(4);
                    if (deck4 == "VACANT")
                    {
                        label67.ForeColor = Color.SkyBlue;
                        radioButton18.Enabled = true;
                        label67.Text = deck4;

                    }
                    else
                    {
                        radioButton18.Enabled = false;

                        label67.Text = deck4;
                    }
                    //deck5
                    string deck5 = myReader.GetString(5);
                    if (deck5 == "VACANT")
                    {
                        label65.ForeColor = Color.SkyBlue;
                        radioButton16.Enabled = true;
                        label65.Text = deck5;

                    }
                    else
                    {
                        radioButton16.Enabled = false;

                        label65.Text = deck5;
                    }
                    //deck6
                    string deck6 = myReader.GetString(6);
                    if (deck6 == "VACANT")
                    {
                        label63.ForeColor = Color.SkyBlue;
                        radioButton15.Enabled = true;
                        label63.Text = deck6;

                    }
                    else
                    {
                        radioButton15.Enabled = false;

                        label63.Text = deck6;
                    }

                    Refresh();
                }


            }
            catch
            {
            }
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton14.Checked == true)
            {
                label64.ForeColor = Color.PaleGreen;
                label64.Text = textBox10.Text.ToString();
            }
            else
            {
                label64.Text = "VACANT";
                label64.ForeColor = Color.SkyBlue;
            }
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton13.Checked == true)
            {
                label66.ForeColor = Color.PaleGreen;
                label66.Text = textBox10.Text.ToString();
            }
            else
            {
                label66.Text = "VACANT";
                label66.ForeColor = Color.SkyBlue;
            }
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton17.Checked == true)
            {
                label68.ForeColor = Color.PaleGreen;
                label68.Text = textBox10.Text.ToString();
            }
            else
            {
                label68.Text = "VACANT";
                label68.ForeColor = Color.SkyBlue;
            }
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton18.Checked == true)
            {
                label67.ForeColor = Color.PaleGreen;
                label67.Text = textBox10.Text.ToString();
            }
            else
            {
                label67.Text = "VACANT";
                label67.ForeColor = Color.SkyBlue;
            }
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton16.Checked == true)
            {
                label65.ForeColor = Color.PaleGreen;
                label65.Text = textBox10.Text.ToString();
            }
            else
            {
                label65.Text = "VACANT";
                label65.ForeColor = Color.SkyBlue;
            }
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton15.Checked == true)
            {
                label63.ForeColor = Color.PaleGreen;
                label63.Text = textBox10.Text.ToString();
            }
            else
            {
                label63.Text = "VACANT";
                label63.ForeColor = Color.SkyBlue;
            }
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton12.Checked == true)
            {
                listBox1.Visible = false;
                groupBox6.Visible = false;
                listBox2.Visible = true;
                groupBox7.Visible = true;
                label70.Visible = false;
                label71.Visible = true;

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //////REFRESH
            textBox10.Text = "";
            textBox9.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            textBox5.Text = "";
            label71.Visible = false;
            label70.Visible = false;
            //GENDER
            listBox2.Visible = false;
            groupBox7.Visible = false;
            listBox1.Visible = false;
            groupBox6.Visible = false;

            radioButton1.Checked = false;

            radioButton2.Checked = false;

            textBox6.Text = "";
            //GUARDIAN
            textBox7.Text = "";
            comboBox4.Text = "";
            textBox1.Text = "";
            //EDUCATIONAL INFO
            textBox8.Text = "";
            comboBox5.Text = "";
            comboBox6.Text = "";
            //IMAGE
            pictureBox2.Image = null;
            //CASH
            comboBox3.Text = "";
            textBox11.Text = "";
            label46.Text = "0000";
            textBox12.Text = "";
            label48.Text = "0000";
            checkBox1.Checked = false;
            dateTimePicker2.Value = DateTime.Now;
            //CREDIT
            comboBox8.Text = "";
            textBox2.Text = "";
            label33.Text = "0000";
            label36.Text = "0000";
            dateTimePicker3.Value = DateTime.Now;
            //CASH||CREDIT 
            if (radioButton3.Checked)
            {
                radioButton3.Checked = false;
            }
            if (radioButton4.Checked)
            {
                radioButton4.Checked = false;
            }
            //GROUP
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            //BUTTON MEN||WOMEN
            if (radioButton11.Checked)
            {
                radioButton11.Checked = false;
            }
            if (radioButton12.Checked)
            {
                radioButton12.Checked = false;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.ForeColor = Color.DarkSlateGray;
            View view = new View();
            view.Show();
            this.Hide();

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void slidePic_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (panel19.Visible == true)
            {
                Bitmap bm = new Bitmap(this.panel19.Width, this.panel19.Height);
                panel19.DrawToBitmap(bm, new Rectangle(0, 0, this.panel19.Width, this.panel19.Height));
                e.Graphics.DrawImage(bm, 0, 0);

            }
            else if (panel18.Visible == true)
            {
                Bitmap bm = new Bitmap(this.panel18.Width, this.panel18.Height);
                panel18.DrawToBitmap(bm, new Rectangle(0, 0, this.panel18.Width, this.panel18.Height));
                e.Graphics.DrawImage(bm, 0, 0);


            }


        }

        private void button11_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void button14_Click(object sender, EventArgs e)
        {

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            panel15.Visible = true;
            button8.Enabled = false;
            //////////
            button4.Focus();
            button4.ForeColor = Color.Aquamarine;
            button4.BackColor = Color.DarkSlateGray;
            button5.BackColor = Color.Aquamarine;
            button5.ForeColor = Color.DarkSlateGray;
            button6.BackColor = Color.Aquamarine;
            button6.ForeColor = Color.DarkSlateGray;
            panel4.Visible = true;
            panel11.Visible = false;
            panel13.Visible = false;

            button3.Visible = true;
            button9.Visible = false;

            listBox1.SelectedIndex = 0;


            pictureBox9.Visible = true;
            pictureBox3.Visible = false;
            panel18.Visible = false;
            panel19.Visible = false;
            button14.Visible = false;
            button1.Visible = true;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            button4.Focus();
            panel3.Visible = true;
            panel11.Visible = false;
            button4.BackColor = Color.DarkSlateGray;
            button4.ForeColor = Color.Aquamarine;
            button5.BackColor = Color.Aquamarine;
            button5.ForeColor = Color.DarkSlateGray;

            radioButton4.ForeColor = Color.Aquamarine;
            radioButton3.ForeColor = Color.Aquamarine;

            textBox12.Text = "";




            button11.Visible = false;
            button13.Visible = false;
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap b = new Bitmap(this.panel18.Width, this.panel18.Height);
            panel18.DrawToBitmap(b, new Rectangle(0, 0, this.panel8.Width, this.panel18.Height));
            e.Graphics.DrawImage(b, 0, 0);
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog2_Load(object sender, EventArgs e)
        {

        }


        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                tabControl1.Visible = true;
                pictureBox1.Image = Boarding_House_System.Properties.Resources.iconfinder_General_Office_42_3592829;
                pictureBox1.BackColor = Color.White;
                tabControl1.SelectedIndex = 0;
                show();

                int a = 0, b = 0, c = 0, d = 0, f = 0;
                for (a = 0; a < dataGridView1.Rows.Count; a++)
                {
                    b += Convert.ToInt32(dataGridView1.Rows[a].Cells[1].Value);
                    //c += Convert.ToInt32(dataGridView1.Rows[a].Cells[4].Value);
                    //d += Convert.ToInt32(dataGridView1.Rows[a].Cells[5].Value);
                    //f += Convert.ToInt32(dataGridView1.Rows[a].Cells[6].Value);
                }
                //label105.Text = b.ToString();
                //label106.Text = c.ToString();
                //label107.Text = d.ToString();
                //label108.Text = f.ToString();


                if (b == 0)
                {
                    label111.Text = "0000";
                }
                else
                {
                    label111.Text = b.ToString();

                }
               
                if (label111.Text=="0000")
                {
                    button17.Enabled = false;
                    
                }
            }
            catch
            {
            }
        }

        void show()
        {

            SqlDataAdapter sda = new SqlDataAdapter("select * from Annual", connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = dr[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = dr[1].ToString();
                ////dataGridView1.Rows[n].Cells[2].Value = dr[17].ToString();
                ////dataGridView1.Rows[n].Cells[3].Value = dr[23].ToString();
                ////dataGridView1.Rows[n].Cells[4].Value = dr[25].ToString();
                ////dataGridView1.Rows[n].Cells[5].Value = dr[26].ToString();
                ////dataGridView1.Rows[n].Cells[6].Value = dr[19].ToString();

            }

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label106_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {


        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            groupBox10.Visible = true;
            double expences = 0;

            if (textBox13.Text == "")
            {
                textBox13.Text = "0";
            }
            if (textBox14.Text == "")
            {
                textBox14.Text = "0";
            }
            if (textBox15.Text == "")
            {
                textBox15.Text = "0";
            }
            expences = double.Parse(textBox13.Text.ToString()) + double.Parse(textBox14.Text.ToString()) + double.Parse(textBox15.Text.ToString());
            label119.Text = expences.ToString();

            double annual = double.Parse(label111.Text) - expences;
            label123.Text = annual.ToString();
         int  d = DateTime.Now.Year;
        label108.Text = d.ToString();
        int i = 1;
       double x = double.Parse(d.ToString()) + double.Parse(i.ToString());
       label109.Text = x.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            label119.Text = "000000";
            label123.Text = "000000";
        }

        private void textBox13_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            tabControl2.SelectedIndex = 5;
            pictureBox1.Image = Boarding_House_System.Properties.Resources.iconfinder_General_Office_56_3592841;
            pictureBox1.BackColor = Color.White;
            tabControl1.SelectedIndex = 1;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            var add = MessageBox.Show("Are you sure to add a new room for girls ?", "Addd Room for Girls",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (add == DialogResult.Yes)
            {
                connect.Open();
                SqlConnection sqlCon = new SqlConnection(connection);
                string rooM = "ROOM";
                string room = rooM + " " + textBox16.Text;
                string deck1 = textBox17.Text;
                string deck2 = textBox18.Text;
                string deck3 = textBox19.Text;
                string deck4 = textBox20.Text;
                string deck5 = textBox21.Text;
                string deck6 = textBox22.Text;

                string sql = "Insert into RoomG values ('" + room + "','" + deck1 + "','" + deck2 + "','" + deck3 + "','" + deck4 + "','" + deck5 + "','" + deck6 + "')";
                SqlCommand command = new SqlCommand(sql, connect);
                command.ExecuteNonQuery();

                connect.Close();
                Refresh();

                MessageBox.Show("Successfully Saved");
                textBox16.Text = "";
                Refresh();


                Main view = new Main();
                view.Show();
                this.Hide();
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            var add = MessageBox.Show("Are you sure to add a new room for boys ?", "Addd Room for Boys",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (add == DialogResult.Yes)
            {
                connect.Open();
                SqlConnection sqlCon = new SqlConnection(connection);
                string rooM = "ROOM";
                string room = rooM + " " + textBox29.Text;
                string deck1 = textBox28.Text;
                string deck2 = textBox27.Text;
                string deck3 = textBox26.Text;
                string deck4 = textBox25.Text;
                string deck5 = textBox24.Text;
                string deck6 = textBox23.Text;

                string sql = "Insert into Rooms values ('" + room + "','" + deck1 + "','" + deck2 + "','" + deck3 + "','" + deck4 + "','" + deck5 + "','" + deck6 + "')";
                SqlCommand command = new SqlCommand(sql, connect);
                command.ExecuteNonQuery();

                connect.Close();
                Refresh();

                MessageBox.Show("Successfully Saved");
                textBox29.Text = "";
                Refresh();
                Main view = new Main();
                view.Show();
                this.Hide();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            tabControl2.SelectedIndex = 5;
            pictureBox1.Image = Boarding_House_System.Properties.Resources.iconfinder_General_Office_56_3592841;
            pictureBox1.BackColor = Color.White;
            tabControl1.SelectedIndex = 1;
        }

        private void button23_Click(object sender, EventArgs e)
        {

            connect.Open();

            string mun = textBox30.Text.ToString();

            if (mun == "")
            {
                MessageBox.Show("Please Input Data...");
            }
            else
            {
                string sql = " Insert into Municipality values ('" + mun + "')";
                SqlCommand command = new SqlCommand(sql, connect);


                command.ExecuteNonQuery();
                connect.Close();
                Refresh();
                MessageBox.Show("Succesfully Added...");
                textBox30.Text = "";
                textBox30.Focus();
            }
            Refresh();
            Main view = new Main();
            view.Show();
            this.Hide();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            connect.Open();

            string pro = textBox31.Text.ToString();
            if (pro == "")
            {
                MessageBox.Show("Please Input Data...");
            }
            else
            {
                string sql = " Insert into Province values ('" + pro + "')";
                SqlCommand command = new SqlCommand(sql, connect);


                command.ExecuteNonQuery();
                connect.Close();
                Refresh();
                MessageBox.Show("Succesfully Added...");
                textBox13.Text = "";
                textBox13.Focus();

                Main view = new Main();
                view.Show();
                this.Hide();
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            connect.Open();

            string relation = textBox32.Text.ToString();


            if (relation == "")
            {
                MessageBox.Show("Please Input Data...");
            }
            else
            {
                string sql = " Insert into Relation values ('" + relation + "')";
                SqlCommand command = new SqlCommand(sql, connect);


                command.ExecuteNonQuery();
                connect.Close();
                Refresh();
                MessageBox.Show("Succesfully Added...");
                textBox32.Text = "";
                textBox32.Focus();
            }
            Refresh();
            Main view = new Main();
            view.Show();
            this.Hide();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            connect.Open();

            string course = textBox33.Text.ToString();
            if (course == "")
            {
                MessageBox.Show("Please Input Data...");
            }
            else
            {
                string sql = " Insert into Course values ('" + course + "')";
                SqlCommand command = new SqlCommand(sql, connect);


                command.ExecuteNonQuery();
                connect.Close();
                Refresh();
                MessageBox.Show("Succesfully Added...");
                textBox33.Text = "";
                textBox33.Focus();
            }
            Refresh();
            Main view = new Main();
            view.Show();
            this.Hide();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            connect.Open();

            string major = textBox34.Text.ToString();

            if (major == "")
            {
                MessageBox.Show("Please Input Data...");
            }
            else
            {
                string sql = " Insert into Major values ('" + major + "')";
                SqlCommand command = new SqlCommand(sql, connect);


                command.ExecuteNonQuery();
                connect.Close();
                Refresh();
                MessageBox.Show("Succesfully Added...");
                textBox34.Text = "";
                textBox34.Focus();
            }
            Refresh();
            Main view = new Main();
            view.Show();
            this.Hide();
        }

        private void button28_Click(object sender, EventArgs e)
        {

            connect.Open();

            string bill = textBox35.Text.ToString();
            if (bill == "")
            {

                MessageBox.Show("Please Input Data...");
            }
            else
            {
                string sql = " Insert into Monthly values ('" + bill + "')";
                SqlCommand command = new SqlCommand(sql, connect);


                command.ExecuteNonQuery();
                connect.Close();
                Refresh();
                MessageBox.Show("Succesfully Added...");
                textBox35.Text = "";
                textBox35.Focus();
            }
            Refresh();
            Main view = new Main();
            view.Show();
            this.Hide();
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e)
        {

            if (textBox37.Text != textBox36.Text)
            {
                MessageBox.Show("Password did not match.. ");
                textBox38.Text = "";
                textBox37.Text = "";
                textBox36.Text = "";
                textBox38.Focus();
            }
            else
            {
                connect.Open();
                string Username = textBox38.Text.ToString();
                string Password = textBox37.Text.ToString();
                string sql = " Insert into logIn values ('" + Username + "','" + Password + "')";
                SqlCommand command = new SqlCommand(sql, connect);
                command.ExecuteNonQuery();
                MessageBox.Show("New User was added : " + Username);

                Refresh();
                connect.Close();

                textBox38.Text = "";
                textBox37.Text = "";
                textBox36.Text = "";
                Main view = new Main();
                view.Show();
                this.Hide();
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            textBox38.Text = "";
            textBox37.Text = "";
            textBox36.Text = "";
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (comboBox4.Items.Count <= 2)
            {
                MessageBox.Show("You need to remain atleast one Username & Password");
            }
            else
            {

                SqlConnection sqlCon = new SqlConnection(connection);
                string sql = " delete from login where username ='" + this.textBox40.Text + "' ;";

                SqlCommand sqlCom = new SqlCommand(sql, sqlCon);
                SqlDataReader myReader;

                sqlCon.Open();
                myReader = sqlCom.ExecuteReader();
                MessageBox.Show("Successfully Deleted..");

                while (myReader.Read())
                {
                    this.textBox40.Text = "";
                    this.textBox39.Text = "";
                }

                comboBox9.SelectedItem = "";
                this.textBox40.Text = "";
                this.textBox39.Text = "";
                Refresh();

                Main view = new Main();
                view.Show();
                this.Hide();
            }
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

            string query = "select * from login where Username ='" + comboBox9.Text + "' ; ";
            SqlConnection sqlCon = new SqlConnection(connection);
            SqlCommand sqlCom = new SqlCommand(query, sqlCon);
            SqlDataReader myReader;

            sqlCon.Open();
            myReader = sqlCom.ExecuteReader();

            try
            {
                while (myReader.Read())
                {
                    string username = myReader.GetString(0);
                    textBox40.Text = username;
                    string password = myReader.GetString(1);
                    textBox39.Text = password;
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            sqlCon.Close();
            Refresh();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            comboBox9.Text = "";
            textBox40.Text = "";
            textBox39.Text = "";
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox7.Text == "ADD GIRLS ROOM")
            {
                tabControl2.Visible = true;
                panel21.Visible = true;
                tabControl2.SelectedIndex = 0;
            }

            if (comboBox7.Text == "ADD BOYS ROOM")
            {
                tabControl2.Visible = true;
                panel21.Visible = true;
                tabControl2.SelectedIndex = 1;
            }

            if (comboBox7.Text == "ADD ITEMS")
            {
                tabControl2.Visible = true;
                panel21.Visible = true;
                tabControl2.SelectedIndex = 2;
            }

            if (comboBox7.Text == "ADD USER")
            {
                tabControl2.Visible = true;
                panel21.Visible = true;
                tabControl2.SelectedIndex = 3;
            }

            if (comboBox7.Text == "DELETE USER")
            {
                tabControl2.Visible = true;
                panel21.Visible = true;
                tabControl2.SelectedIndex = 4;
            }

        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Boarding_House_System.Properties.Resources.iconfinder_General_Office_42_3592829;
            pictureBox1.BackColor = Color.White;
            tabControl1.Visible = true;
            tabControl1.SelectedIndex = 2;
            groupBox9.Visible = false;
            groupBox8.Visible = false;
            radioButton19.Checked = false;
            radioButton20.Checked = false;
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton20.Checked == true)
            {

                groupBox8.Visible = true;
                comboBox11.Text = "";
                textBox53.Text = "";
                textBox52.Text = "";
                textBox51.Text = "";
                textBox50.Text = "";
                textBox49.Text = "";
                textBox48.Text = "";
                comboBox11.Text = "";

            }
            else
            {

                groupBox8.Visible = false;

            }
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton19.Checked == true)
            {

                groupBox9.Visible = true;
                comboBox10.Text = "";
                textBox47.Text = "";
                textBox46.Text = "";
                textBox45.Text = "";
                textBox44.Text = "";
                textBox43.Text = "";
                textBox42.Text = "";
                comboBox10.Text = "";
                comboBox10.Text = "";


            }
            else
            {
                groupBox9.Visible = false;
            }

        }




        private void panel5_MouseEnter(object sender, EventArgs e)
        {
          
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
          
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox10_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string query = "select * from RoomG where Room ='" + comboBox10.Text.ToString() + "' ; ";
            SqlConnection sqlCon = new SqlConnection(connection);
            SqlCommand sqlCom = new SqlCommand(query, sqlCon);
            SqlDataReader myReader;

            sqlCon.Open();
            myReader = sqlCom.ExecuteReader();

            try
            {
                while (myReader.Read())
                {
                    string deck1 = myReader.GetString(1);
                    textBox47.Text = deck1;
                    if (deck1 != "VACANT")
                    {
                        textBox47.ForeColor = Color.DarkSlateGray;
                    }
                    else
                    {
                        textBox47.Enabled = true;
                        textBox47.ForeColor = Color.SpringGreen;
                    }

                    string deck2 = myReader.GetString(2);
                    textBox46.Text = deck2;
                    if (deck2 != "VACANT")
                    {
                        textBox46.ForeColor = Color.DarkSlateGray;
                    }
                    else
                    {
                        textBox46.Enabled = true;
                        textBox46.ForeColor = Color.SpringGreen;
                    }

                    string deck3 = myReader.GetString(3);
                    textBox45.Text = deck3;
                    if (deck3 != "VACANT")
                    {
                        textBox45.ForeColor = Color.DarkSlateGray;
                    }
                    else
                    {
                        textBox45.Enabled = true;
                        textBox45.ForeColor = Color.SpringGreen;
                    }
                    string deck4 = myReader.GetString(4);
                    textBox44.Text = deck4;
                    if (deck4 != "VACANT")
                    {
                        textBox44.ForeColor = Color.DarkSlateGray;
                    }
                    else
                    {
                        textBox44.Enabled = true;
                        textBox44.ForeColor = Color.SpringGreen;
                    }

                    string deck5 = myReader.GetString(5);
                    textBox43.Text = deck5;
                    if (deck5 != "VACANT")
                    {
                        textBox43.ForeColor = Color.DarkSlateGray;
                    }
                    else
                    {
                        textBox43.Enabled = true;
                        textBox43.ForeColor = Color.SpringGreen;
                    }

                    string deck6 = myReader.GetString(6);
                    textBox42.Text = deck6;
                    if (deck6 != "VACANT")
                    {
                        textBox42.ForeColor = Color.DarkSlateGray;
                    }
                    else
                    {
                        textBox42.Enabled = true;
                        textBox42.ForeColor = Color.SpringGreen;
                    }

                    Refresh();
                }
            }

            catch
            {
            }
            sqlCon.Close();
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select * from Rooms where Room ='" + comboBox11.Text.ToString() + "' ; ";
            SqlConnection sqlCon = new SqlConnection(connection);
            SqlCommand sqlCom = new SqlCommand(query, sqlCon);
            SqlDataReader myReader;

            sqlCon.Open();
            myReader = sqlCom.ExecuteReader();

            try
            {
                while (myReader.Read())
                {
                    string deck1 = myReader.GetString(1);
                    textBox53.Text = deck1;
                    if (deck1 != "VACANT")
                    {
                        textBox53.ForeColor = Color.DarkSlateGray;
                    }
                    else
                    {
                        textBox53.Enabled = true;
                        textBox53.ForeColor = Color.SpringGreen;
                    }

                    string deck2 = myReader.GetString(2);
                    textBox52.Text = deck2;
                    if (deck2 != "VACANT")
                    {
                        textBox52.ForeColor = Color.DarkSlateGray;
                    }
                    else
                    {
                        textBox52.Enabled = true;
                        textBox52.ForeColor = Color.SpringGreen;
                    }

                    string deck3 = myReader.GetString(3);
                    textBox51.Text = deck3;
                    if (deck3 != "VACANT")
                    {
                        textBox51.ForeColor = Color.DarkSlateGray;
                    }
                    else
                    {
                        textBox51.Enabled = true;
                        textBox51.ForeColor = Color.SpringGreen;
                    }
                    string deck4 = myReader.GetString(4);
                    textBox50.Text = deck4;
                    if (deck4 != "VACANT")
                    {
                        textBox50.ForeColor = Color.DarkSlateGray;
                    }
                    else
                    {
                        textBox50.Enabled = true;
                        textBox50.ForeColor = Color.SpringGreen;
                    }

                    string deck5 = myReader.GetString(5);
                    textBox49.Text = deck5;
                    if (deck5 != "VACANT")
                    {
                        textBox49.ForeColor = Color.DarkSlateGray;
                    }
                    else
                    {
                        textBox49.Enabled = true;
                        textBox49.ForeColor = Color.SpringGreen;
                    }

                    string deck6 = myReader.GetString(6);
                    textBox48.Text = deck6;
                    if (deck6 != "VACANT")
                    {
                        textBox48.ForeColor = Color.DarkSlateGray;
                    }
                    else
                    {
                        textBox48.Enabled = true;
                        textBox48
                            .ForeColor = Color.SpringGreen;
                    }

                    Refresh();
                }
            }

            catch
            {
            }
            sqlCon.Close();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            var register = MessageBox.Show("Are you sure to save ?", "Save Boarder",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (register == DialogResult.Yes)
            {
                string deck1 = textBox47.Text;
                string deck2 = textBox46.Text;
                string deck3 = textBox45.Text;
                string deck4 = textBox44.Text;
                string deck5 = textBox43.Text;
                string deck6 = textBox42.Text;


                SqlConnection sqlCon = new SqlConnection(connection);
                string sql = " update RoomG set Room ='" + comboBox10.Text + "', Deck1 ='" + deck1 + "', Deck2 ='" + deck2 + "',Deck3='" + deck3 + "',Deck4 = '" + deck4 + "',Deck5 = '" + deck5 + "',Deck6 = '" + deck6 + "'     where Room = '" + comboBox10.Text + "' ;";

                SqlCommand sqlCom = new SqlCommand(sql, sqlCon);
                SqlDataReader myReader;

                sqlCon.Open();
                myReader = sqlCom.ExecuteReader();


                while (myReader.Read())
                {

                }
                Refresh();
                sqlCon.Close();
                Refresh();
                MessageBox.Show("Successfully Saved");

                textBox47.Text = "";
                textBox46.Text = "";
                textBox45.Text = "";
                textBox44.Text = "";
                textBox43.Text = "";
                textBox42.Text = "";
                comboBox10.Text = "";


                Main view = new Main();
                view.Show();
                this.Hide();

            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            textBox47.Text = "";
            textBox46.Text = "";
            textBox45.Text = "";
            textBox44.Text = "";
            textBox43.Text = "";
            textBox42.Text = "";
            comboBox10.Text = "";
            comboBox10.Text = "";

        }

        private void button37_Click(object sender, EventArgs e)
        {
            var register = MessageBox.Show("Are you sure to save ?", "Save Boarder",
          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (register == DialogResult.Yes)
            {
                string deck1 = textBox53.Text;
                string deck2 = textBox52.Text;
                string deck3 = textBox51.Text;
                string deck4 = textBox50.Text;
                string deck5 = textBox49.Text;
                string deck6 = textBox48.Text;


                SqlConnection sqlCon = new SqlConnection(connection);
                string sql = " update Rooms set Room ='" + comboBox11.Text + "', Deck1 ='" + deck1 + "', Deck2 ='" + deck2 + "',Deck3='" + deck3 + "',Deck4 = '" + deck4 + "',Deck5 = '" + deck5 + "',Deck6 = '" + deck6 + "'     where Room = '" + comboBox11.Text + "' ;";

                SqlCommand sqlCom = new SqlCommand(sql, sqlCon);
                SqlDataReader myReader;

                sqlCon.Open();
                myReader = sqlCom.ExecuteReader();


                while (myReader.Read())
                {

                }
                Refresh();
                sqlCon.Close();
                Refresh();
                MessageBox.Show("Successfully Saved");

                textBox53.Text = "";
                textBox52.Text = "";
                textBox51.Text = "";
                textBox50.Text = "";
                textBox49.Text = "";
                textBox48.Text = "";
                comboBox11.Text = "";


                Main view = new Main();
                view.Show();
                this.Hide();

            }

        }

        private void button36_Click(object sender, EventArgs e)
        {
            textBox53.Text = "";
            textBox52.Text = "";
            textBox51.Text = "";
            textBox50.Text = "";
            textBox49.Text = "";
            textBox48.Text = "";
            comboBox11.Text = "";
            tabControl1.Visible = true;
            tabControl2.SelectedIndex = 5;
            pictureBox1.Image = Boarding_House_System.Properties.Resources.iconfinder_General_Office_56_3592841;
            pictureBox1.BackColor = Color.White;
            tabControl1.SelectedIndex = 1;
        }

        private void panel5_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button38_Click(object sender, EventArgs e)
        {
            var add = MessageBox.Show("Make sure all boarders was paid for the whole year.                               Continue to add to Yearly Report ? ", "Add Report",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);




            if (add == DialogResult.Yes)
            {
               


                    connect.Open();
                    SqlConnection sqlCon = new SqlConnection(connection);
                    sqlCon.Open();
                    string year = label108.Text + "-" +label109.Text + "";
                    string income = label123.Text;
                    string expences = label119.Text.ToString();
                    string sQl = "Insert into View_Annual values ('" + year + "','" + income + "','" +expences  + "')";
                    SqlCommand command = new SqlCommand(sQl, connect);
                    command.ExecuteNonQuery();


                    Refresh();
                    sqlCon.Close();
                    connect.Close();
                    Refresh();
                    MessageBox.Show("Successfully Saved");


               
                    textBox13.Text = "";
                    textBox14.Text = "";
                    textBox15.Text = "";
                    label119.Text = "000000";
                    label123.Text = "000000";
                    
                    groupBox10.Visible = false;






                    string sql = " delete from Annual ";

                    SqlCommand sqlCom = new SqlCommand(sql, sqlCon);
                    SqlDataReader myReader;

                    sqlCon.Open();
                    myReader = sqlCom.ExecuteReader();
                

                    while (myReader.Read())
                    {

                    }
                    sqlCon.Close();
                    Refresh();




                    try
                    {
                        tabControl1.Visible = true;
                        pictureBox1.Image = Boarding_House_System.Properties.Resources.iconfinder_General_Office_18_3592864;
                        pictureBox1.BackColor = Color.White;
                        tabControl1.SelectedIndex = 0;
                        show();

                        int a = 0, b = 0, c = 0, d = 0, f = 0;
                        for (a = 0; a < dataGridView1.Rows.Count; a++)
                        {
                            b += Convert.ToInt32(dataGridView1.Rows[a].Cells[1].Value);
                            //c += Convert.ToInt32(dataGridView1.Rows[a].Cells[4].Value);
                            //d += Convert.ToInt32(dataGridView1.Rows[a].Cells[5].Value);
                            //f += Convert.ToInt32(dataGridView1.Rows[a].Cells[6].Value);
                        }
                        //label105.Text = b.ToString();
                        //label106.Text = c.ToString();
                        //label107.Text = d.ToString();
                        //label108.Text = f.ToString();



                        label111.Text = b.ToString();
                    }
                    catch
                    {
                    }

                
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button39_Click(object sender, EventArgs e)
        {
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            label119.Text = "000000";
            label123.Text = "000000";
          
            groupBox10.Visible = false;
        }

        private void label108_Click(object sender, EventArgs e)
        {

        }
        void view()
        {

            SqlDataAdapter sda = new SqlDataAdapter("select * from View_Annual", connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView2.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                int n = dataGridView2.Rows.Add();
                dataGridView2.Rows[n].Cells[0].Value = dr[0].ToString();
                dataGridView2.Rows[n].Cells[1].Value = dr[1].ToString();
                dataGridView2.Rows[n].Cells[2].Value = dr[2].ToString();
                ////dataGridView1.Rows[n].Cells[2].Value = dr[17].ToString();
                ////dataGridView1.Rows[n].Cells[3].Value = dr[23].ToString();
                ////dataGridView1.Rows[n].Cells[4].Value = dr[25].ToString();
                ////dataGridView1.Rows[n].Cells[5].Value = dr[26].ToString();
                ////dataGridView1.Rows[n].Cells[6].Value = dr[19].ToString();

            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button40_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            pictureBox1.Image = Boarding_House_System.Properties.Resources.iconfinder_General_Office_18_3592864;
            pictureBox1.BackColor = Color.White;
            tabControl1.SelectedIndex = 3;
            view();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            tabControl2.SelectedIndex = 5;
            pictureBox1.Image = Boarding_House_System.Properties.Resources.iconfinder_General_Office_56_3592841;
            pictureBox1.BackColor = Color.White;
            tabControl1.SelectedIndex = 1;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
