using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace TheWeather
{
    public partial class MainForm : Form
    {
        private JObject currentResult;


        public MainForm()
        {
            InitializeComponent();
            
        }

        private void PopulateData(JObject currentResult)
        {
            this.currentResult = currentResult;
            var highestTemp = new List<string>();
            var lowestTemp = new List<string>();
            var text = new List<string>();
            var title = currentResult.SelectToken("query.results.channel.description");
            var windSpeed = currentResult.SelectToken("query.results.channel.wind.speed");
            var humidity = currentResult.SelectToken("query.results.channel.atmosphere.humidity");
            var sunRise = currentResult.SelectToken("query.results.channel.astronomy.sunrise");
            var sunSet = currentResult.SelectToken("query.results.channel.astronomy.sunset");
            var currentDate = currentResult.SelectToken("query.results.channel.item.condition.date");
            var currentTemp = currentResult.SelectToken("query.results.channel.item.condition.temp");
            var currentText = currentResult.SelectToken("query.results.channel.item.condition.text");
            label2.Text = title.ToString();
            label3.Text = "Current weather information - " + currentDate;
            dataGridView1.Rows.Clear();
            dataGridView1.Rows[0].SetValues(currentText, currentTemp, sunRise, sunSet, windSpeed, humidity);
            for (int i = 0; i < 5; i++)
            {

                var jTokenForecast = currentResult.SelectToken(string.Format("query.results.channel.item.forecast[{0}]", i));
                var dateAndDay = jTokenForecast.SelectToken("date").ToString() + " " + jTokenForecast.SelectToken("day").ToString();
                switch (i)
                {
                    case 0:
                        this.OneDayFromToday.HeaderText = dateAndDay;
                        break;
                    case 1:
                        this.TwoDayFromToday.HeaderText = dateAndDay;
                        break;
                    case 2:
                        this.ThreeDayFromToday.HeaderText = dateAndDay;
                        break;
                    case 3:
                        this.FourDayFromToday.HeaderText = dateAndDay;
                        break;
                    case 4:
                        this.FiveDayFromToday.HeaderText = dateAndDay;
                        break;
                    default:
                        break;
                }
                highestTemp.Add(jTokenForecast.SelectToken("high").ToString());
                lowestTemp.Add(jTokenForecast.SelectToken("low").ToString());
                text.Add(jTokenForecast.SelectToken("text").ToString());
            }

            this.dataGridView2.Rows.Add(text[0], text[1], text[2], text[3], text[4]);
            this.dataGridView2.Rows.Add(highestTemp[0], highestTemp[1], highestTemp[2], highestTemp[3], highestTemp[4]);
            this.dataGridView2.Rows.Add(lowestTemp[0], lowestTemp[1], lowestTemp[2], lowestTemp[3], lowestTemp[4]);
            this.dataGridView2.Rows[0].HeaderCell.Value = "Text Information";
            this.dataGridView2.Rows[1].HeaderCell.Value = "Max Temperature";
            this.dataGridView2.Rows[2].HeaderCell.Value = "Min Temperature";
            this.dataGridView2.AutoResizeRowHeadersWidth(System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var currentResult =await TakeWeatherInformation.GetAsync(cityTextBox.Text);
            dataGridView2.Rows.Clear();
            PopulateData(currentResult);
        }

        

        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
