using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace Launcher__version_0._1_beta_
{
    public class WebApi
    {
        public static string ServerUrl { get; set; }
        public static string BaseUrl { get; set; }
        private WebClient webClient;
        public UserData user;
        public List<ServerData> servers;

        public WebApi()
        {
            this.webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;
            this.user = new UserData();
            this.servers = new List<ServerData>();

        }


        public string GetLoginUrl(string login, string password)
        {
            return string.Format("{0}?action=login&login={1}&password={2}", WebApi.ServerUrl, login, password);
        }

        public string GetRegisterUrl(string lg, string ps, string em, string fn, string ln)
        {
            return string.Format("{0}?action=register" +
                                 "&login={1}" +
                                 "&password={2}" +
                                 "&email={3}" +
                                 "&first_name={4}" +
                                 "&last_name={5}",
                                 WebApi.ServerUrl, lg, ps, em, fn, ln);
        }

        public string GetServersUrl()
        {
            return string.Format("{0}?action=servers", WebApi.ServerUrl);
        }



        public void Login_Callback(string result, bool Error)
        {
            if (Error)
            {
                JObject jObject = JObject.Parse(result);
                string flag = (string)jObject["success"];

                if (flag.Equals("true"))
                {
                    UserData.Login = (string)jObject["login"];
                    UserData.Password = (string)jObject["password"];
                    this.user.Id = (int)jObject["id"];
                    this.user.FirstName = (string)jObject["first_name"];
                    this.user.LastName = (string)jObject["last_name"];
                    this.user.Email = (string)jObject["email"];
                    this.user.Money = (double)jObject["money"];


                    //AppManager.mainForm.InitData();
                    this.InitData();
                    AppManager.mainForm.Show();
                    AppManager.LoginForm.Visible = false;
                    string act = AppManager.webApi.GetServersUrl();
                    AppManager.mainForm.webBrowser1.Navigate(act);


                }
                else
                {
                    MessageBox.Show("Такой пользователь уже существует,измените логин");
                }
                int i = 0;
            }
            else
            {
                Console.WriteLine(result);
            }

        }


        public void InitData()
        {

        }

        public void Servers_Callback(string result)
        {


            JObject jObject = JObject.Parse(result);
            string flag = (string)jObject["success"];

            servers.Clear();

            if (flag.Equals("true"))
            {
                int count = (int)jObject["count"];

                for (int i = 0; i < count; i++)
                {
                    ServerData dat = new ServerData();
                    JObject temp = (JObject)jObject[i.ToString()];

                    dat.Id = (string)temp["id"];
                    dat.Title = (string)temp["title"];
                    dat.SmallText = (string)temp["small_text"];
                    dat.ImgUrl = (string)temp["img"];

                    servers.Add(dat);

                }

            }
        }
    }
}
           
