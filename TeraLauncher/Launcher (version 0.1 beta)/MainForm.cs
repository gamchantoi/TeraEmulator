using Fiddler;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace Launcher__version_0._1_beta_
{
    public partial class MainForm : Form
    {
        string dir = Application.StartupPath;
    
        public MainForm()
        {
            InitializeComponent();           
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            label1.Text = UserData.Login;
            //string myHost = System.Net.Dns.GetHostName();
            //string myIP = System.Net.Dns.GetHostByName(myHost).AddressList[0].ToString();
            //label2.Text = myIP;
            //WebClient ip1 = new WebClient();
            //string html = ip1.DownloadString("http://www.myip.ru/get_ip.php?loc=");
            //string ip = Regex.Match(html, @"(?<ip>\d?\d?\d\.\ d?\d?\d\.\d?\d?\d\ .\d?\d?\d)").Groups["ip"].Value;
            //label2.Text = ip;
            label2.Text = "Tera Revolution Launcher 1.0";
            
          
        }


        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AppManager.LoginForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AppManager.LoginForm.Visible = true;
        }

        public struct PROCESS_INFORMATION
        {
            public IntPtr hProcess;
            public IntPtr hThread;
            public uint dwProcessId;
            public uint dwThreadId;
        }

        public struct STARTUPINFO
        {
            public uint cb;
            public string lpReserved;
            public string lpDesktop;
            public string lpTitle;
            public uint dwX;
            public uint dwY;
            public uint dwXSize;
            public uint dwYSize;
            public uint dwXCountChars;
            public uint dwYCountChars;
            public uint dwFillAttribute;
            public uint dwFlags;
            public short wShowWindow;
            public short cbReserved2;
            public IntPtr lpReserved2;
            public IntPtr hStdInput;
            public IntPtr hStdOutput;
            public IntPtr hStdError;
        }
  
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            AppManager.webApi.Servers_Callback(this.webBrowser1.DocumentText);
            int i = 0;
        }


        private void ServerCont_Enter(object sender, EventArgs e)
        {
           
        }

        [DllImport("kernel32.dll")]
        static extern bool CreateProcess(string lpApplicationName, string lpCommandLine, IntPtr lpProcessAttributes, IntPtr lpThreadAttributes,
                                bool bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment,
                                string lpCurrentDirectory, ref STARTUPINFO lpStartupInfo, out PROCESS_INFORMATION lpProcessInformation);


        private void f_location_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
         
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void webBrowser3_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {         
       
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string loginText;
            int rewriteCount = 0;
            {
                using (StreamReader reader = new StreamReader("TeraLauncher.login.js"))
                {
                    loginText = reader.ReadToEnd();
                }
            }// UP

            string login = label1.Text;
            FiddlerApplication.BeforeRequest += delegate(Session session) //RUN Dance S Bubnom
            {
                if (session.uriContains("download.frogster-online.com"))
                {
                    session.Abort();
                    Console.WriteLine("Download patch aborted...");
                }
                if (session.uriContains("/app/mainwindow/_js/login.js"))
                {
                    session.utilCreateResponseAndBypassServer();
                    session.utilSetResponseBody(loginText.Replace("#ACCOUNT_NAME#", login).Replace("#ACCOUNT_EMAIL#", login).Replace("#SESSION_TICKET#", login + "_session"));
                    rewriteCount++;
                }
            };//END

            CONFIG.IgnoreServerCertErrors = false;
            FiddlerApplication.Startup(0x97dd, false, true);
            Thread.Sleep(750);
            try
            {
                string LaunchString = " 1 " + UserData.Password + " 0 1 " + UserData.Login + " en";
                ProcessStartInfo Tera = new ProcessStartInfo();
                Tera.FileName = "TERA-Launcher.exe";
                Tera.Arguments = LaunchString;
                Process.Start(Tera);
            }
            catch
            {
                MessageBox.Show("Not enough TERA-Launcher.exe!"); //Not found Tera Launcher
            }
            //END
            FiddlerApplication.Shutdown(); // Kill Fiddler Aplication
            Application.Exit(); //kill Application
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
