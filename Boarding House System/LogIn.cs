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

namespace Boarding_House_System
{
    public partial class r : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Sanz\Desktop\DAN2X SANZ\Boarding House System\Database1.mdf;Integrated Security=True");

        public r()
        {
            InitializeComponent();
            textBox1.Focus();
        }

      


        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
            button3.Visible = false;
            button4.Visible = true;
           
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

            textBox2.UseSystemPasswordChar = true;
            button3.Visible = true;
            button4.Visible = false;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("Select count (*) From logIn where Username='" + textBox1.Text + "' and Password='" + textBox2.Text + "'", connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);



            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("You're now Logged In ");
                this.Hide();
                Main form = new Main();
                form.Show();
            }


            else
            {
                MessageBox.Show("Wrong Input..Try Again");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox1.Focus();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
        }

       
       
       
    }
}
