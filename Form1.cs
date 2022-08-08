using Newtonsoft.Json;
using System.Net;

namespace Weather_WinForms
{
    public partial class Form1 : Form
    {
        string APIKey = "b6f26e1190ac1d36dac9d2da79890c4a";


        public Form1()
        {
            InitializeComponent();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                getWeather();
            }
            catch (Exception)
            {
                MessageBox.Show("NotFound");
                //throw;
            }

        }

        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", TBCity.Text, APIKey);
                var json = web.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                picicon.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                labcondition.Text = Info.weather[0].main;
                labdetails.Text = Info.weather[0].description;
                labelsanset.Text = convertDate(Info.sys.sunset).ToShortTimeString();
                labelsunrise.Text = convertDate(Info.sys.sunrise).ToShortTimeString();

                labspeed.Text = Info.wind.speed.ToString();
                labpressure.Text = Info.main.pressure.ToString();
                templabel.Text = Info.main.temp.ToString();
            }
        }

        DateTime convertDate(long sec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(sec).ToLocalTime();
            return day;
        }
    }
}