using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Launcher__version_0._1_beta_
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            WebApi.ServerUrl = @"http://10.0.0.4/tera/api.php";
            //WebApi.ServerUrl = @"http://127.0.0.1/api.php";
            WebApi.BaseUrl = @"http://10.0.0.5/tera/";

            AppManager.LoginForm = this;
            AppManager.mainForm = new MainForm();
            AppManager.webApi = new WebApi();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           ShowLoginForm();
            //this.BackColor = Color.White;

         this.l_login.Text = "Введите логин";
          this.l_password.Text = "123";

        }
        
        private void ShowLoginForm()
        {
            // 355; 310
            this.Width = 632;
            this.Height = 488;


          login_content.BackColor = Color.White;
            login_content.Visible = true;
           login_content.Location = new Point(0,0);


            register_content.BackColor = Color.White;
          register_content.Visible = false;
            register_content.Location = new Point(0,0);


        }


        private void button1_Click(object sender, EventArgs e)
        {
            string l = login.Text; string p = password.Text;
            this.webBrowser1.Navigate(AppManager.webApi.GetLoginUrl(l,p));
            login.Clear(); password.Clear();

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            AppManager.webApi.Login_Callback(this.webBrowser1.DocumentText, true);
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            //label5.Cursor = Cursor.
        }
        // размер регистрации
        private void label5_Click(object sender, EventArgs e)
        {
            login_content.Visible = false;
           register_content.Visible = true;
           this.Height = 488;
        }
       //логин контент

        private void label6_Click(object sender, EventArgs e)
        {
          login_content.Visible = true;
            register_content.Visible = false;
            this.Height = 488;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (l_login.Text == "")
            {
                MessageBox.Show("Введите логин!");
                return;
            }
            if (l_password.Text == "")
            {
                MessageBox.Show("Введите пароль!");
                return;                
            }

            this.webBrowser1.Navigate(AppManager.webApi.GetLoginUrl(l_login.Text, l_password.Text));
            l_login.Clear();
            l_password.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (r_login.Text == "")
            {
                MessageBox.Show("Введите логин!");
                return;
            }

            if (r_password.Text == "")
            {
                MessageBox.Show("Введите пароль!");
                return;
            }

            if (r_repeat_password.Text == "")
            {
                MessageBox.Show("Введите пароль еще раз!");
                return;
            }
            if (r_email.Text == "")
            {
                MessageBox.Show("Введите email!");
                return;
            }
            if (r_first_name.Text == "")
            {
                MessageBox.Show("Ведите имя!");
                return;
            }
            if (r_last_name.Text == "")
            {
                MessageBox.Show("Введите фамилию!");
                return;
            }

            if (!r_password.Text.Equals(r_repeat_password.Text))
            {
                MessageBox.Show("Ошибка, пароли не совпадают!");
                return;
            }

            this.webBrowser1.Navigate(AppManager.webApi.GetRegisterUrl(
                r_login.Text,
                r_password.Text,
                r_email.Text,
                r_first_name.Text,
                r_last_name.Text));

            r_login.Clear();
            r_password.Clear();
            r_email.Clear();
            r_first_name.Clear();
            r_last_name.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
     
        private void login_content_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void l_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lineShape2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void register_content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
