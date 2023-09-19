using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projeto1.models;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;
using projeto1.Models;
using Newtonsoft.Json;

namespace projeto1
{
    public partial class frmTelaInicial1 : Form
    {
        string className;
        public frmTelaInicial1(string className = null)
        {
            this.className = className;
          
            InitializeComponent();
            if (className != null)
            {
                carregar_liga_inglesa();
            }
            else
            {
                MessageBox.Show("Selecione uma liga");
            }
        }

        private void btnJogos_Click(object sender, EventArgs e)
        {
            Form ligas = new frmligas(false);
            ligas.WindowState = FormWindowState.Maximized;
            ligas.Show();
            this.Hide();
        }

        private async void carregar_liga_inglesa()
        {
            using (var client = new HttpClient())
            {
                string apiUrl = "http://api.football-data.org/v4/competitions/PL/matches/";
                string apiKey = "f49c8fa332e54e61afa3fbfa995e7cf6";

                //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("X-Auth-Token", apiKey);

                HttpResponseMessage response = await client.GetAsync(apiUrl);
                //MessageBox.Show("r: " + response.ToString());

                if (response.IsSuccessStatusCode)
                {
                    string jsonContent = await response.Content.ReadAsStringAsync();

                    var data = new LigaInglesa();
                    if (className == "LigaInglesa")
                    {
                        data = await response.Content.ReadAsAsync<LigaInglesa>();
                    }
                    else
                    {
                        MessageBox.Show("Liga ainda não implementada");
                        return;
                    }


                    dataGVtimes.Columns.Clear();

                    // Adicione colunas baseadas nos dados da API
                    dataGVtimes.Columns.Add("UtcDate", "Dia do Jogo");
                    dataGVtimes.Columns.Add("HomeTeam", "Time da Casa");
                    dataGVtimes.Columns.Add("AwayTeam", "Time Visitante");
                    dataGVtimes.Columns.Add("HomeScore", "Placar Casa");
                    dataGVtimes.Columns.Add("AwayScore", "Placar Visitante");

                    foreach (var match in data.matches)
                    {
                        dataGVtimes.Rows.Add(match.utcDate, match.homeTeam.name, match.awayTeam.name, match.score.fullTime.home, match.score.fullTime.away);
                    }
                }
                else
                {
                    MessageBox.Show("Erro ao fazer a requisição à API.");
                }
            }
        }
    }
}
