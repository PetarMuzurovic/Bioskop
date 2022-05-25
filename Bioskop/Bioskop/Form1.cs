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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Email.Text == "" || Lozinka.Text == "")
            {
                MessageBox.Show("Unesite Email i Lozinku");
            }
            else
            {
                SqlConnection veza = Konekcija.Connect();
                SqlCommand komanda = new SqlCommand("SELECT * FROM Korisnik WHERE Email = '" + Email.Text + "'", veza);
                SqlDataAdapter adapter = new SqlDataAdapter(komanda);
                DataTable tabela = new DataTable();
                adapter.Fill(tabela);

                int brojac = tabela.Rows.Count;
                if (brojac >= 1)
                {
                    if (String.Compare(tabela.Rows[0]["Lozinka"].ToString(), Lozinka.Text) == 0)
                    {
                        MessageBox.Show("Uspesno prijavljivanje!");
                        Program.ID = Convert.ToInt32(tabela.Rows[0]["ID"]); 
                        this.Hide();
                        Rezervacije rez = new Rezervacije();
                        rez.Show();
                    }
                    else
                    {
                        MessageBox.Show("Neispravna lozinka");
                    }
                }
                else
                {
                    MessageBox.Show("Nepostojeci Email");
                }
            }
        }
    }
}
