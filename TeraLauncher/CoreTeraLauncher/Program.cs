using Fiddler;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Launcher__version_0._1_beta_;

namespace CoreTeraLauncher
{
    internal class Program
    {
        private static void Main()
        {
            string loginText;
            int rewriteCount = 0;
            {
                using (StreamReader reader = new StreamReader("TeraLauncher.login.js"))
                {
                    loginText = reader.ReadToEnd();
                }
            }
            string login = Launcher__version_0._1_beta_.UserData.Login;
            FiddlerApplication.BeforeRequest += delegate (Session session) {
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
            };
            CONFIG.IgnoreServerCertErrors = false;
            FiddlerApplication.Startup(0x97dd, true, true);
            Thread.Sleep(750);
            try
            {
                Process.Start("TERA-Launcher.exe");
                while (rewriteCount != 2)
                {
                    Thread.Sleep(750);
                }
            }
            catch
            {
                Console.WriteLine("Can't find TERA-Launcher.exe");
            }
            FiddlerApplication.Shutdown();
            Thread.Sleep(750);
        }
    }
}

