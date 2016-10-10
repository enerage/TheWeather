using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Threading;

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

            for (int i = 0; i < 5; i++)
            {

                var jToken = currentResult.SelectToken(string.Format("query.results.channel.item.forecast[{0}]", i));
                var dateAndDay = jToken.SelectToken("date").ToString() + " " + jToken.SelectToken("day").ToString();
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
                highestTemp.Add(jToken.SelectToken("high").ToString());
                lowestTemp.Add(jToken.SelectToken("low").ToString());
                text.Add(jToken.SelectToken("text").ToString());
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
            label2.Text = "Forecast for " + cityTextBox.Text;
        }

        

        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
