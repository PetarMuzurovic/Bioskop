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
    public partial class Rezervacije : Form
    {
        public Rezervacije()
        {
            InitializeComponent();
        }

        private void Rezervacije_Load(object sender, EventArgs e)
        {
            SqlConnection veza = Konekcija.Connect();
            SqlCommand komanda = new SqlCommand("Select Film.Naziv, Film.Datum, Film.Vreme, Mesto from Rezervacije join Film on Rezervacije.ID_Film = Film.ID where ID_korisnik = '"+ Program.ID +"'", veza);
            SqlDataAdapter adapter = new SqlDataAdapter(komanda);
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);
            if (tabela.Rows.Count >= 1) dataGridView1.DataSource = tabela;
        }

        private void Rezervisi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rezervisi rez = new Rezervisi();
            rez.Show();
        }
    }
}
