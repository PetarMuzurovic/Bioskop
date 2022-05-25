using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bioskop
{
    public partial class Rezervisi : Form
    {
        public string film;
        public string dat;
        public int ID;

        public Rezervisi()
        {
            InitializeComponent();
        }

        public string Obrni(string niz)
        {
            char[] pomoc = new char[niz.Length + 1];
            pomoc[0] = niz[6];
            pomoc[1] = niz[7];
            pomoc[2] = niz[8];
            pomoc[3] = niz[9];
            pomoc[4] = '-';
            pomoc[5] = niz[3];
            pomoc[6] = niz[4];
            pomoc[7] = '-';
            pomoc[8] = niz[0];
            pomoc[9] = niz[1];
            niz = new string(pomoc);
            return niz;
        }

        public void Ucitaj_Mesta(int id)
        {
            SqlConnection veza = Konekcija.Connect();
            SqlCommand komanda = new SqlCommand("SELECT Br_mesta FROM Film WHERE ID = '" + id + "'", veza);
            SqlDataAdapter adapter = new SqlDataAdapter(komanda);
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);
            int br_mesta = Convert.ToInt32(tabela.Rows[0]["Br_mesta"]);

            tabela = new DataTable();
            komanda = new SqlCommand("SELECT Mesto FROM Rezervacije WHERE ID_Film = '" + id + "' AND ID_korisnik = '" + Program.ID + "'", veza);
            adapter = new SqlDataAdapter(komanda);
            adapter.Fill(tabela);
            for (int i = 1; i <= br_mesta; i++)
            {
                bool flag = true;
                for (int l = 0; l < tabela.Rows.Count; l++)
                {
                    if (i == Convert.ToInt32(tabela.Rows[l]["Mesto"])) flag = false; 
                }
                if (flag) Mesto.Items.Add(i);
            }

        }

        private void Rezervisi_Load(object sender, EventArgs e)
        {
            SqlConnection veza = Konekcija.Connect();
            SqlCommand komanda = new SqlCommand("SELECT DISTINCT Naziv FROM Film WHERE Datum > GETDATE()", veza);
            SqlDataAdapter adapter = new SqlDataAdapter(komanda);
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);
            dataGridView1.DataSource = tabela;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Datum.Items.Clear();
            Vreme.Items.Clear();
            Mesto.Items.Clear();
            Datum.Text = "";
            Vreme.Text = "";
            Mesto.Text = "";
            film = dataGridView1.SelectedCells[0].Value.ToString();
            SqlConnection veza = Konekcija.Connect();
            SqlCommand komanda = new SqlCommand("SELECT DISTINCT Datum FROM Film WHERE Naziv = '"+ film +"'", veza);
            SqlDataAdapter adapter = new SqlDataAdapter(komanda);
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);
            for (int i = 0; i < tabela.Rows.Count; i++) Datum.Items.Add(tabela.Rows[i]["Datum"]);
        }

        private void Datum_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vreme.Items.Clear();
            Mesto.Items.Clear();
            Vreme.Text = "";
            Mesto.Text = "";
            dat = Datum.Text;
            dat = Obrni(dat);
            SqlConnection veza = Konekcija.Connect();
            SqlCommand komanda = new SqlCommand("SELECT Vreme FROM Film WHERE Naziv = '" + film + "' AND Convert(varchar(10),Datum) LIKE Convert(varchar(10),'"+ dat +"')", veza);
            SqlDataAdapter adapter = new SqlDataAdapter(komanda);
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);
            for (int i = 0; i < tabela.Rows.Count; i++) Vreme.Items.Add(tabela.Rows[i]["Vreme"]);
        }

        private void Vreme_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mesto.Items.Clear();
            Mesto.Text = "";
            SqlConnection veza = Konekcija.Connect();
            SqlCommand komanda = new SqlCommand("SELECT ID FROM Film WHERE Naziv = '" + film + "' AND Convert(varchar(10),Datum) LIKE Convert(varchar(10),'" + dat + "') AND Convert(varchar(5),Vreme) LIKE Convert(varchar(5),'" + Vreme.Text + "')", veza);
            SqlDataAdapter adapter = new SqlDataAdapter(komanda);
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);
            ID = Convert.ToInt32(tabela.Rows[0]["ID"]);
            Ucitaj_Mesta(ID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Mesto.Text == "")
            {
                MessageBox.Show("Nisu izabrani svi podaci");
            }
            else
            {
                SqlConnection veza = Konekcija.Connect();
                SqlCommand komanda = new SqlCommand("INSERT INTO Rezervacije VALUES ("+ Program.ID +", "+ ID +", "+ Convert.ToInt32(Mesto.Text) +")", veza);
                
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();

                Mesto.Items.Clear();
                Mesto.Text = "";
                Ucitaj_Mesta(ID);
            }
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rezervacije rez = new Rezervacije();
            rez.Show();
        }
    }
}