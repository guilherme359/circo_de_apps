using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace circideapps
{
    public partial class frmclima : Form
    {
        private const string Apikey = "a76e98b418728200c0cfb6520e085262";
        private const string ApiBaseURL = "http://api.openweathermap.org/data/2.5/weather";
        public frmclima()
        {
            InitializeComponent();
        }

        private async void btnpesquisar_Click(object sender, EventArgs e)
        {
            string city = txtcidade.Text.Trim();
            if (!string.IsNullOrEmpty(city))
            {
                string apiUrl = $"{ApiBaseURL}?lang=pt-br&q={city}&appid={Apikey}&units=metric";
                try
                {
                    string jsonresponse = await FetchDataAsync(apiUrl);
                    DisplayWeather(jsonresponse);
                }
                catch (Exception er)
                {
                    MessageBox.Show($"Erro: {er.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor insira o nome da cidade.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async Task<string> FetchDataAsync(string apiUrl)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    throw new HttpRequestException($"Falha. Não consegui recuperar os dados! código{response.StatusCode}.");
                }
            }
        }
        private void DisplayWeather(string jsonresponse)
        {
            JObject data = JObject.Parse(jsonresponse);
            string nomeCidade = data["name"].ToString();
            string temperatura = data["main"]["temp"].ToString();
            string descricao = data["weather"][0]["description"].ToString();
            string umidade = data["main"]["humidity"].ToString();
            string pressao = data["main"]["humidity"].ToString();
            string pais = data["sys"]["country"].ToString();
            lblcidade.Text = $"Cidade:  {nomeCidade}";
            lbltemperatura.Text = $"Temperatura: {temperatura}°C";
            lbldescricao.Text = $"Descrição: {descricao}";
            lblumidade.Text = $"Umidade: {umidade}";
            lblpressao.Text = $"Pressão: {pressao}";
            lblpais.Text = $"Pais: {pais}";


        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
