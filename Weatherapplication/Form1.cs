using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace Weatherapplication
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string API_KEY = "4cb0b3eac18d0a3d9b9d43add2649959";
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            getWeather();
        }

        void getWeather()
        {
            using (WebClient web = new WebClient()) 
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}" , TBcity.Text , API_KEY);
                var json = web.DownloadString(url);
                Weatherinfo.root Info = JsonConvert.DeserializeObject<Weatherinfo.root>(json);

                picIcon.ImageLocation = "https://api.openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                labDetail.Text = Info.weather[0].description;
                labSunset.Text = convetDateTime(Info.sys.sunset).ToShortTimeString();
                labSunrise.Text = convetDateTime(Info.sys.sunrise).ToShortTimeString();

                labWindspeed.Text = Info.wind.speed.ToString();
                labPressure.Text = Info.main.pressure.ToString();

            }
        }

       DateTime convetDateTime(long sec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(sec).ToLocalTime();


            return day;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void labSunset_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
